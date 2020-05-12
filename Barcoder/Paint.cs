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
        public List<ProductData> Data;

        public Paint() 
        {
            Brand = "New Brand";
            Product = "New Product";
            Data = new List<ProductData>();
        }
    }

    [Serializable]
    public class ProductData
    {
        public string Base { get; set; }
        public string Volume { get; set; }
        public string Barcode { get; set; }

        public ProductData()
        {
            Base = "";
            Volume = "";
            Barcode = "";
        }

        public ProductData(string _base, string _volume, string _barcode)
        {
            Base = _base;
            Volume = _volume;
            Barcode = _barcode;
        }
    }
}
