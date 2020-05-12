using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Barcoder
{
    public partial class Barcoder : Form
    {
        List<Paint> db = new List<Paint>();
        XmlSerializer formatter = new XmlSerializer(typeof(List<Paint>));

        public Barcoder()
        {
            InitializeComponent();
            //IniializeDB();

            using (FileStream fs = new FileStream("db.xml", FileMode.OpenOrCreate))
            {
                db = (List<Paint>)formatter.Deserialize(fs);
            }
        }

        private void brandsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            productsBox.Items.Clear();
            productsBox.Text = "";
            dataBox.Items.Clear();
            label.Text = string.Empty;

            foreach (var paint in db)
            {
                if (paint.Brand.Equals(brandsBox.SelectedItem.ToString()))
                {
                    productsBox.Items.Add(paint.Product);
                }
            }
        }

        private void productsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataBox.Items.Clear();
            label.Text = "";

            foreach (var paint in db)
            {
                if (productsBox.SelectedItem.Equals(paint.Product))
                {
                    foreach (var data in paint.Data)
                    {
                        if(data.Volume == "")
                        {
                            continue;
                        }
                        dataBox.Items.Add($"{data.Base} | {data.Volume} | {data.Barcode}");
                    }
                }
            }
        }

        private void IniializeDB()
        {
            Paint first = new Paint();
            first.Brand = "Tikkurila";
            first.Product = "Harmony";
            first.Data.Add(new ProductData() { Base = "A", Volume = "0.9", Barcode = "15859" });
            first.Data.Add(new ProductData() { Base = "A", Volume = "2.7", Barcode = "15858" });
            first.Data.Add(new ProductData() { Base = "A", Volume = "9.0", Barcode = "15857" });
            first.Data.Add(new ProductData() { Base = "C", Volume = "0.9", Barcode = "15855" });
            first.Data.Add(new ProductData() { Base = "C", Volume = "2.7", Barcode = "15854" });
            first.Data.Add(new ProductData() { Base = "", Volume = "", Barcode = "" });

            Paint second = new Paint();
            second.Brand = "Tikkurila";
            second.Product = "Euro Matt 3";
            second.Data.Add(new ProductData() { Base = "A", Volume = "0.9", Barcode = "16034" });
            second.Data.Add(new ProductData() { Base = "A", Volume = "2.7", Barcode = "16035" });
            second.Data.Add(new ProductData() { Base = "A", Volume = "9.0", Barcode = "16036" });
            second.Data.Add(new ProductData() { Base = "C", Volume = "0.9", Barcode = "16037" });
            second.Data.Add(new ProductData() { Base = "C", Volume = "2.7", Barcode = "16038" });
            second.Data.Add(new ProductData() { Base = "C", Volume = "9.0", Barcode = "16039" });
            Paint third = new Paint();
            third.Brand = "Rossetti";
            third.Product = "Karma";
            third.Data.Add(new ProductData() { Base = "ORO", Volume = "1.0", Barcode = "19194" });
            third.Data.Add(new ProductData() { Base = "ARG", Volume = "1.0", Barcode = "19196" });
            third.Data.Add(new ProductData() { Base = "ARG", Volume = "3.0", Barcode = "19197" });
            third.Data.Add(new ProductData() { Base = "BRO", Volume = "1.0", Barcode = "25000" });
            third.Data.Add(new ProductData() { Base = "", Volume = "", Barcode = "" });
            third.Data.Add(new ProductData() { Base = "", Volume = "", Barcode = "" });
            db.Add(first);
            db.Add(second);
            db.Add(third);

            using (FileStream fs = new FileStream("db.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                fs.SetLength(0);
                formatter.Serialize(fs, db);
            }
        }

        private void dataBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dataBox.SelectedItem == null)
                return;

            string barcode = dataBox.SelectedItem.ToString().Substring(dataBox.SelectedItem.ToString().Length - 5);
            Clipboard.SetData(DataFormats.Text, barcode);
            label.Text = $"Скопирован: {barcode}";
        }
    }
}