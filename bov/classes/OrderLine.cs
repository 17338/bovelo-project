using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bov.classes
{
    public class OrderLine
    {
        public List<Bike> list_bike;
        public Bike_model bike_Model;
        public int quantity;
        public int size;
        public string color;
        

        public OrderLine(Bike_model bike_Model,int quantity, int size, string color)
        {
            this.bike_Model = bike_Model;
            this.quantity = quantity;
            this.size = size;
            this.color = color;
            this.list_bike = new List<Bike>();
        }

        public void AllBikes()
        {
            for (int i= 0;i<this.quantity;i++)
            {
                Bike bike = new Bike(this.bike_Model);
                list_bike.Add(bike);
            }
        }

        
    }
}
