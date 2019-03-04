using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4
{
    class ClassCustomer
    {
        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string Phone { get; set; }

        public ClassCustomer(string firstName, string lastName, string streetAddress, string city, string state, string zipCode, string phone)
        {
            FirstName = firstName;
            LastName = lastName;
            StreetAddress = streetAddress;
            City = city;
            State = state;
            ZipCode = zipCode;
            Phone = phone;
        }
    }
}
