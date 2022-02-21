using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bov.classes
{
    public class CatalogShop
    {
        public List<Bike_model> list_bike_model;

        public CatalogShop()
        {
            this.list_bike_model = new List<Bike_model>();
        }

        public void getAllbikemodel()
        {
            string[] list = null;
            foreach (string line in File.ReadLines(@"C:\Users\zakbu\source\repos\bov\bov\bike_model.txt"))
            {
                list = line.Split(';');
                Bike_model bike_model = new Bike_model(list[0], list[1], float.Parse(list[2]), float.Parse(list[3]));
                list_bike_model.Add(bike_model);
            }
        }
    }
}
