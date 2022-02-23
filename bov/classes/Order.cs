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
        public List<OrderLine> orderLines;
        public DateTime date;
        public DateTime? estimateDate;
        public float totalPrice;
        public bool status;
        public float totalBuildingTime;
        TimeSpan time;
        bool verif = true;

        public Order()
        {
            this.orderLines = new List<OrderLine>();
            this.date = DateTime.Today;
            this.estimateDate = DateTime.Today;
            this.totalPrice = 0;
            this.status = false;
        }

        public void TotalOrder()
        {
            
            foreach (OrderLine line in this.orderLines)
            {
                this.totalPrice += line.bikeModel.price * line.quantity;
                this.totalBuildingTime += line.bikeModel.buildingTime * line.quantity;


            }
            this.time = TimeSpan.FromMinutes(totalBuildingTime);
            Console.WriteLine(this.time.ToString());
            this.estimateDate += time;


        }

        public void AddOrderLine(OrderLine line)
        {
            this.orderLines.Add(line);
        }

        public void DeleteOrderLine(int index)
        {
            this.orderLines.RemoveAt(index);
        }

        public void CheckOrderLineExist(OrderLine line)
        {
            foreach (OrderLine verifyLine in this.orderLines)
            {
                
              if(line.color == verifyLine.color && line.size == verifyLine.size && line.bikeModel.name == verifyLine.bikeModel.name)
                {
                    verifyLine.quantity += line.quantity;                
                    verif = false;
                }

                
            }
            if(verif == true)
            {
                this.orderLines.Add(line);
            }
            verif = true;


        }



    }
}
