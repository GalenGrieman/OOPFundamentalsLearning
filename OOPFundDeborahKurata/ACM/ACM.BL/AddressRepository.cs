using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class AddressRepository
    {
        // Retrieve one Address
        public Address Retrieve(int addressId)
        {
            // Create the instance of the Address Class
            // Pass in the requested Id
            Address address = new Address(addressId);

            // Code that retreives the defined address

            // Temporary hard coded values to return a 
            // populated address

            if( addressId == 1)
            {
                address.AddressType = 1;
                address.StreetLine1 = "Bad End";
                address.StreetLine2 = "Bagshot row";
                address.City = "Hobbiton";
                address.StateOrProvince = "Shire";
                address.Country = "Middle Earth";
                address.PostalCode = "144";
            }

            return address;
        }

        public IEnumerable<Address> RetrieveByCustomerId(int customerId)
        {
            //  code that retreives the defined addresses for the customer

            // Temp hard-coded values for treuan a set of adress for a customer
            var addressList = new List<Address>();
            Address address = new Address(1)
            {
                AddressType = 1,
                StreetLine1 = "Bad End",
                StreetLine2 = "Bagshot Row",
                City = "Hobbiton",
                StateOrProvince = "Shire",
                Country = "Middle Earth",
                PostalCode = "144"
            };
            addressList.Add(address);

            address = new Address(2)
            {

                AddressType = 2,
                StreetLine1 = "Green Dragon",
                City = "Bywater",
                StateOrProvince = "Shire",
                Country = "Middle Earth",
                PostalCode = "146"
            };
            addressList.Add(address);

            return addressList;
        }

        // Saves the current address
        public bool Save(Address address)
        {
            var success = true;
            if (address.HasChanges)
            {
                if (address.IsValid)
                {
                    if (address.IsNew)
                    {
                        // Call an insert stored Procedure
                    }
                    else
                    {
                        // call an update stored procedure
                    }
                }
                else
                {
                    success = false;
                }
            }

            return success;
        }
    }
}
