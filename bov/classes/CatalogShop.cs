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
        public List<BikeModel> bikesModel;
        Database listBikesModel = new Database();

        public CatalogShop()
        {
            this.bikesModel = new List<BikeModel>();
        }

        public List<BikeModel> GetAllBikeModel()
        {
        
            foreach (List<string> bikeModel in listBikesModel.getfromdb("modelbike"))
            {
                Console.WriteLine(bikeModel[1]);
                BikeModel bike_model = new BikeModel(bikeModel[1], bikeModel[2], float.Parse(bikeModel[3]), float.Parse(bikeModel[4]), bikeModel[5]);
                this.bikesModel.Add(bike_model);
            }
            return this.bikesModel;


        }

        public List<string> Colors()
        {
            List<string> colors = new List<string>() ;
            foreach (List<string> color in listBikesModel.getfromdb("color"))
            {
                colors.Add(color[1]);
            }
            return colors;
        }

        public List<string> Sizes()
        {
            List<string> sizes = new List<string>();
            foreach (List<string> color in listBikesModel.getfromdb("size"))
            {
                sizes.Add(color[1]);
            }
            return sizes;
        }
    }
}
