using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barcoder
{
    [Serializable]
    public class Paint
    {
        public string Brand { get; set; }
        public string Product { get; set; }
        public string Base { get; set; }
        public float Volume { get; set; }
        public int Barcode { get; set; }

        public Paint() 
        {
            Brand = "New Brand";
            Product = "New Product";
            Base = "New Base";
            Volume = 0;
            Barcode = 0;
        }
    }
}
