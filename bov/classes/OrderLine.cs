using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bov.classes
{
    public class OrderLine
    {
        public List<Bike> bikes;
        public BikeModel bikeModel;
        public int quantity;
        public int size;
        public string color;
        

        public OrderLine(BikeModel bikeModel, int quantity, int size, string color)
        {
            this.bikeModel = bikeModel;
            this.quantity = quantity;
            this.size = size;
            this.color = color;
            bikes = new List<Bike>();
        }

        public void AllBikes()
        {
            for (int i= 0;i<this.quantity;i++)
            {
                Bike bike = new Bike(bikeModel);
                bikes.Add(bike);
            }
        }

        
    }
}
