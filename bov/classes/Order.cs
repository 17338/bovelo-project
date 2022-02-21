using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bov.classes
{
    public class Order
    {
        public List<OrderLine> list_orderLines;
        public DateTime date;
        public DateTime? estimate_date;
        public float total_price;
        public bool status;
        public float total_building_time;
        TimeSpan time;
        bool verif = true;

        public Order()
        {
            this.list_orderLines = new List<OrderLine>();
            this.date = DateTime.Today;
            this.estimate_date = DateTime.Today;
            this.total_price = 0;
            this.status = false;
        }

        public void TotalOrder()
        {
            
            foreach (OrderLine line in this.list_orderLines)
            {
                this.total_price += line.bike_Model.price * line.quantity;
                this.total_building_time += line.bike_Model.building_time * line.quantity;


            }
            this.time = TimeSpan.FromMinutes(total_building_time);
            Console.WriteLine(this.time.ToString());
            this.estimate_date += time;


        }

        public void addOrderLine(OrderLine line)
        {
            this.list_orderLines.Add(line);
        }

        public void checkiftheorderLineexist(OrderLine line)
        {
            foreach (OrderLine verify_line in this.list_orderLines)
            {
                
                if(line.color == verify_line.color && line.size == verify_line.size && line.bike_Model == verify_line.bike_Model)
                {
                    verify_line.quantity += line.quantity;                
                    verif = false;
                }

                
            }
            if(verif == true)
            {
                this.list_orderLines.Add(line);
            }


        }



    }
}
