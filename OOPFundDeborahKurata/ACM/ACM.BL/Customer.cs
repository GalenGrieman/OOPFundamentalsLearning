using Acme.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{

    /*** When giving a specification for a new program, start by 
     * Identifying classes
     * --Represents busines entities
     * --Defines properties(data)
     * -- defines methods (actions/behaviors)
     * 
     * Separate Responsibilites
     * -- Minimize coupling by making sure each class has a single purpose
     * -- Maximise cohesion by reviewing the properties and methods of each class to make sure they belong
     * -- Single purpose classes are two fold,
     *      Simplifies maintenance,
     *      Improves testability
     * Establish Relationships
     * -- Defines how objects work together to perform the operations of the application
     * Leverage reuse
     * -- Involves Extractting commonality,
     *      if multiple classes require same methods, put those methods in single class for all them to call on -- inheritance
     * -- Building reusable classes / components
     * -- define interfaces
     * 
     * -- Further learning
     * Defensive Codeing in C#
     * Clean COde: Writing code for humans
     * C# Interfaces
     * Design Patterns on-ramp
     * 
     * **/
    public class Customer : EntityBase, ILoggable
    {
        public Customer(): this(0)
        {

        }
        public Customer(int customerId)
        {
            CustomerId = customerId;
            AddressList = new List<Address>();
        }

        public List<Address> AddressList { get; set; }
        public int CustomerId { get; private set; }
        public int CustomerType { get; set; }
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }

        public string FullName
        {
            get
            {
                string fullName = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += ", ";
                    }
                    fullName += FirstName;
                }
                return fullName;
            }
        }

        public static int InstanceCount { get; set; }

        private string _lastName;
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }
        public override string ToString() => FullName;

        // Logs Data, Logging is done across all classes but the specific class gives the requirements on what is to be logged,
        // this means all code for the that specific log has to be done whithin that class
        // Such as below, the log can be called anywhere, but this class provides what is to be passed within that log
        public string Log() =>
            $"{CustomerId}: {FullName} Email: {EmailAddress} Status: {EntityState.ToString()}";

        /// Validates the customer data.
        public override bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;

            return isValid;
        }

    }
}
