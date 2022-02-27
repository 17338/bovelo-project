using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bov.classes
{
    public class BikeModel
    {
        public string name;
        public string description;
        public float price;
        public float buildingTime;
        public string image;


        public BikeModel(string name, string description, float price, float buildingTime, string image)
        {
            this.name = name;
            this.description = description;
            this.price = price;
            this.buildingTime = buildingTime;
            this.image = image;
           
            
        }


    }
}
