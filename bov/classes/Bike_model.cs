using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bov.classes
{
    public class Bike_model
    {
        public string name;
        public string description;
        public float price;
        public float building_time;


        public Bike_model(string name, string description, float price, float building_time)
        {
            this.name = name;
            this.description = description;
            this.price = price;
            this.building_time = building_time; 
           
            
        }


    }
}
