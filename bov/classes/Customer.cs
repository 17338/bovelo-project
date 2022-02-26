using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bov.classes
{
    public class Customer
    {
        public string lastName;
        public string firstName;
        public string adress;
        public string tva;

        public Customer(string firstName, string lastName,string adress,string tva)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.adress = adress;
            this.tva = tva;
        }
    }
}
