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
        List<Button> btnList = new List<Button>();

        public Barcoder()
        {
            InitializeComponent();
            InitializeButtons();
            LockAndClearButtons();
            //IniializeDB();

            using (FileStream fs = new FileStream("db.xml", FileMode.OpenOrCreate))
            {
                db = (List<Paint>)formatter.Deserialize(fs);
            }
        }

        private void InitializeButtons()
        {
            btnList.Add(dataBtn1);
            btnList.Add(dataBtn2);
            btnList.Add(dataBtn3);
            btnList.Add(dataBtn4);
            btnList.Add(dataBtn5);
            btnList.Add(dataBtn6);
            btnList.Add(dataBtn7);
            btnList.Add(dataBtn8);
        }

        private void brandsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            productsBox.Items.Clear();
            productsBox.Text = "";
            LockAndClearButtons();
            label.Text = "Выберите продукт";

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
            LockAndClearButtons();
            label.Text = string.Empty;

            foreach (var paint in db)
            {
                if (productsBox.SelectedItem.Equals(paint.Product))
                {
                    for (int i = 0; i < paint.Data.Count; i++)
                    {
                        if (!string.IsNullOrEmpty(paint.Data[i].Base) && !string.IsNullOrEmpty(paint.Data[i].Volume) && !string.IsNullOrEmpty(paint.Data[i].Barcode))
                        {
                            string curBase = paint.Data[i].Base.ToUpper().Replace(" ", "");
                            string curVolume = paint.Data[i].Volume.Replace(" ", "");
                            string curBarcode = paint.Data[i].Barcode.Replace(" ", "");
                            btnList[i].Visible = true;
                            btnList[i].Text = $"{curBase}  |  {curVolume}  |  {curBarcode}";
                            switch (curBase)
                            {
                                case "A":
                                case "AP":
                                case "BB":
                                case "BT":
                                case "BW":
                                case "VVA":
                                case "MRA":
                                    btnList[i].BackColor = Color.White;
                                    break;
                                case "BC":
                                case "C":
                                case "D":
                                case "TR":
                                case "MRC":
                                case "VC":
                                    btnList[i].BackColor = Color.IndianRed;
                                    break;
                                case "EP":
                                case "EC":
                                case "NEU":
                                    btnList[i].BackColor = Color.AntiqueWhite;
                                    break;
                                case "ORO":
                                    btnList[i].BackColor = Color.Gold;
                                    break;
                                case "ARG":
                                    btnList[i].BackColor = Color.Silver;
                                    break;
                                case "BRO":
                                    btnList[i].BackColor = Color.DarkOrange;
                                    break;
                                case "PER":
                                case "DD":
                                    btnList[i].BackColor = Color.LightCyan;
                                    break;
                                default:
                                    btnList[i].BackColor = Color.White;
                                    break;
                            }
                        }
                    }
                }
            }
        }

        private void IniializeDB()
        {
            Paint paint = new Paint();
            paint.Brand = "";
            paint.Product = "";
            paint.Data.Add(new ProductData() { Base = "", Volume = "", Barcode = "" });
            paint.Data.Add(new ProductData() { Base = "", Volume = "", Barcode = "" });
            paint.Data.Add(new ProductData() { Base = "", Volume = "", Barcode = "" });
            paint.Data.Add(new ProductData() { Base = "", Volume = "", Barcode = "" });
            paint.Data.Add(new ProductData() { Base = "", Volume = "", Barcode = "" });
            paint.Data.Add(new ProductData() { Base = "", Volume = "", Barcode = "" });
            paint.Data.Add(new ProductData() { Base = "", Volume = "", Barcode = "" });
            paint.Data.Add(new ProductData() { Base = "", Volume = "", Barcode = "" });

            db.Add(paint);

            using (FileStream fs = new FileStream("db.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                //fs.SetLength(0);
                formatter.Serialize(fs, db);
            }
        }

        private void LockAndClearButtons()
        {
            dataBtn1.Visible = false;
            dataBtn2.Visible = false;
            dataBtn3.Visible = false;
            dataBtn4.Visible = false;
            dataBtn5.Visible = false;
            dataBtn6.Visible = false;
            dataBtn7.Visible = false;
            dataBtn8.Visible = false;
        }

        private void dataBtn1_Click(object sender, EventArgs e)
        {
            string barcode = dataBtn1.Text.Substring(dataBtn1.Text.Length - 5);
            Clipboard.SetData(DataFormats.Text, barcode);
            label.Text = $"Скопирован: {barcode}";
        }

        private void dataBtn2_Click(object sender, EventArgs e)
        {
            string barcode = dataBtn2.Text.Substring(dataBtn2.Text.Length - 5);
            Clipboard.SetData(DataFormats.Text, barcode);
            label.Text = $"Скопирован: {barcode}";
        }

        private void dataBtn3_Click(object sender, EventArgs e)
        {
            string barcode = dataBtn3.Text.Substring(dataBtn3.Text.Length - 5);
            Clipboard.SetData(DataFormats.Text, barcode);
            label.Text = $"Скопирован: {barcode}";
        }

        private void dataBtn4_Click(object sender, EventArgs e)
        {
            string barcode = dataBtn4.Text.Substring(dataBtn4.Text.Length - 5);
            Clipboard.SetData(DataFormats.Text, barcode);
            label.Text = $"Скопирован: {barcode}";
        }

        private void dataBtn5_Click(object sender, EventArgs e)
        {
            string barcode = dataBtn5.Text.Substring(dataBtn5.Text.Length - 5);
            Clipboard.SetData(DataFormats.Text, barcode);
            label.Text = $"Скопирован: {barcode}";
        }

        private void dataBtn6_Click(object sender, EventArgs e)
        {
            string barcode = dataBtn6.Text.Substring(dataBtn6.Text.Length - 5);
            Clipboard.SetData(DataFormats.Text, barcode);
            label.Text = $"Скопирован: {barcode}";
        }

        private void dataBtn7_Click(object sender, EventArgs e)
        {
            string barcode = dataBtn7.Text.Substring(dataBtn7.Text.Length - 5);
            Clipboard.SetData(DataFormats.Text, barcode);
            label.Text = $"Скопирован: {barcode}";
        }

        private void dataBtn8_Click(object sender, EventArgs e)
        {
            string barcode = dataBtn8.Text.Substring(dataBtn8.Text.Length - 5);
            Clipboard.SetData(DataFormats.Text, barcode);
            label.Text = $"Скопирован: {barcode}";
        }

        private void Barcoder_Load(object sender, EventArgs e)
        {

        }

        private void label_Click(object sender, EventArgs e)
        {

        }
    }
}