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
using Barcoder;

namespace DBH
{
    public enum AppMode { Maxidom = 5, Petrovich = 6 }

    public partial class Helper : Form
    {
        AppMode curMode;
        static string fileName = "";
        public static List<Paint> db = new List<Paint>();
        static XmlSerializer formatter = new XmlSerializer(typeof(List<Paint>));
        public static List<string> brands = new List<string>();

        public Helper()
        {
            SetRetailer();
            switch (curMode) 
            {
                case AppMode.Maxidom:
                    fileName = "dbM.xml";
                    break;
                case AppMode.Petrovich:
                    fileName = "dbP.xml";
                    break;
            }

            InitializeComponent();
            InitRanges();
            ReadDB();
        }

        private void SetRetailer()
        {
            string configFile = "settings.ini";
            int currentModeInt = 0;

            // Read the settings.ini file and extract the CurrentMode value
            if (File.Exists(configFile))
            {
                string[] lines = File.ReadAllLines(configFile);
                foreach (string line in lines)
                {
                    if (line.StartsWith("CurrentMode="))
                    {
                        string modeStr = line.Substring("CurrentMode=".Length);
                        if (int.TryParse(modeStr, out currentModeInt))
                        {
                            break;
                        }
                    }
                }
            }

            // Set the AppMode variable based on the CurrentMode value
            switch (currentModeInt)
            {
                case 5:
                    curMode = AppMode.Maxidom;
                    break;
                case 6:
                    curMode = AppMode.Petrovich;
                    break;
                default:
                    throw new Exception("Invalid CurrentMode value in settings.ini. 5 - Maxidom, 6 - Petrovich");
            }
        }

        internal static void WriteDB()
        {
            using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                fs.SetLength(0);
                formatter.Serialize(fs, db);
            }
        }

        private void ReadDB()
        {
            using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                db = (List<Paint>)formatter.Deserialize(fs);
            }
        }

        public void brandsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (brandsBox.SelectedItem == null)
                return;

            productsBox.Items.Clear();

            foreach (var paint in db)
            {
                if (paint.Brand.Equals(brandsBox.SelectedItem.ToString()))
                {
                    productsBox.Items.Add(paint.Product);
                }
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm();
            addForm.Show();
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            if (productsBox.SelectedItem == null)
                return;

            foreach(var paint in db)
            {
                if (productsBox.SelectedItem.ToString() == paint.Product)
                {
                    db.Remove(paint);
                    break;
                }
            }

            WriteDB();

            brandsBox_SelectedIndexChanged(new object(), new EventArgs());
        }

        void InitRanges()
        {
            switch (curMode)
            {
                case AppMode.Maxidom:
                    brands.AddRange(new[] {
                "Aura", "Dufa", "Dulux", "Eskaro", "Finncolor",
                "Hammerite", "Holzer", "Marshall", "Parade",
                "Pinotex", "Rossetti", "TEKC", "Tikkurila",
                "Лакра", "Текстурол" });
                    break;
                case AppMode.Petrovich:
                    brands.AddRange(new[] {
                "Aura", "CarteBlanche", "Dufa", "Dulux",
                "Eskaro", "Finncolor", "Hammerite",
                "L'Impression", "Marshall", "Parade",
                "Pinotex", "Pragmatic", "TEKC", "Tikkurila" });
                    break;
                default:
                    return;
            }

            brandsBox.AutoCompleteCustomSource.AddRange(brands.ToArray());
            brandsBox.Items.AddRange(brands.ToArray());
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (productsBox.SelectedItem == null)
                return;

            Paint currentPaint = new Paint();

            foreach (var paint in db)
            {
                if (productsBox.SelectedItem.ToString() == paint.Product)
                {
                    currentPaint = paint;
                    break;
                }
            }

            AddForm add = new AddForm();

            add.brandBox.Text = currentPaint.Brand.ToString(); 
            add.brandBox.Enabled = false;
            add.productBox.Text = currentPaint.Product;
            add.productBox.Enabled = true;

            add.baseBox1.Text =  currentPaint.Data[0].Base.Replace(" ","");
            add.volumeBox1.Text = currentPaint.Data[0].Volume.ToString().Replace(" ","");;
            add.bcBox1.Text = currentPaint.Data[0].Barcode.ToString();

            add.baseBox2.Text = currentPaint.Data[1].Base.Replace(" ","");;
            add.volumeBox2.Text = currentPaint.Data[1].Volume.ToString().Replace(" ","");;
            add.bcBox2.Text = currentPaint.Data[1].Barcode.ToString();

            add.baseBox3.Text = currentPaint.Data[2].Base.Replace(" ","");;
            add.volumeBox3.Text = currentPaint.Data[2].Volume.ToString().Replace(" ","");;
            add.bcBox3.Text = currentPaint.Data[2].Barcode.ToString();

            add.baseBox4.Text = currentPaint.Data[3].Base.Replace(" ","");;
            add.volumeBox4.Text = currentPaint.Data[3].Volume.ToString().Replace(" ","");;
            add.bcBox4.Text = currentPaint.Data[3].Barcode.ToString();

            add.baseBox5.Text = currentPaint.Data[4].Base.Replace(" ","");;
            add.volumeBox5.Text = currentPaint.Data[4].Volume.ToString().Replace(" ","");;
            add.bcBox5.Text = currentPaint.Data[4].Barcode.ToString();

            add.baseBox6.Text = currentPaint.Data[5].Base.Replace(" ","");;
            add.volumeBox6.Text = currentPaint.Data[5].Volume.ToString().Replace(" ","");;
            add.bcBox6.Text = currentPaint.Data[5].Barcode.ToString();

            add.baseBox7.Text = currentPaint.Data[6].Base.Replace(" ","");;
            add.volumeBox7.Text = currentPaint.Data[6].Volume.ToString().Replace(" ","");;
            add.bcBox7.Text = currentPaint.Data[6].Barcode.ToString();

            add.baseBox8.Text = currentPaint.Data[7].Base.Replace(" ","");;
            add.volumeBox8.Text = currentPaint.Data[7].Volume.ToString().Replace(" ","");;
            add.bcBox8.Text = currentPaint.Data[7].Barcode.ToString();

            add.Show();
        }
    }
}
