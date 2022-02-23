using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bov.classes
{
    public class Bike
    {
        public BikeModel bikeModel;
        public bool bikeStatus;
        public Bike(BikeModel bikeModel)
        {
            this.bikeModel = bikeModel;
            bikeStatus = false;
        }

       

    }
}
