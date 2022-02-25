using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bov.classes
{
    public class Customer
    {
        public string name;
        public string adress;
        public string tva;

        public Customer(string name,string adress,string tva)
        {
            this.name = name;
            this.adress = adress;
            this.tva = tva;
        }
    }
}
