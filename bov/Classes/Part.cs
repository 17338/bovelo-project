using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bov.classes
{
    public class Part
    {
        public string name;
        public int color;
        public int size;
        public int quantity;

        public Part(string name, int color, int size, int quantity, int status)
        {
            this.name = name;
            this.color = color;
            this.size = size;
            this.quantity = quantity;
        }
    }
}
