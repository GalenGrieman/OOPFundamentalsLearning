using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Acme.Common;

namespace ACM.BL
{
    public class Product : EntityBase, ILoggable
    {
        public Product()
        {

        }

        public Product(int productId)
        {
            ProductId = productId;
        }

        public decimal? CurrentPrice { get; set; }
        public string ProductDescription { get; set; }
        public int ProductId { get; private set; }
        private string _prodcutName;
        public string ProductName
        {
            get 
            {
                return _prodcutName.InsertSpaces();
            }
            set { _prodcutName = value; }
        }

        // Logs Data, Logging is done across all classes but the specific class gives the requirements on what is to be logged,
        // this means all code for the that specific log has to be done whithin that class
        // Such as below, the log can be called anywhere, but this class provides what is to be passed within that log
        public string Log() =>
            $"{ProductId}: {ProductName} Detail: {ProductDescription} Status: {EntityState.ToString()}";

        public override string ToString() => ProductName;
        // Validates the product data
        public override bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (CurrentPrice == null) isValid = false;

            return isValid;

        }
    }
}
