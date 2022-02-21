using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bov.classes
{
    public class Bike
    {
        public Bike_model bike_model;
        public bool bike_status;
        public Bike(Bike_model bike_model)
        {
            this.bike_model = bike_model;
            bike_status = false;
        }

       

    }
}
