using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using ZXing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using ZXing.Common;

namespace Barcoder
{
    public partial class Barcoder : Form
    {
        AppMode curMode = AppMode.Petrovich;
        string fileName = "";
        List<Paint> db;
        XmlSerializer formatter;
        List<Button> btnList;

        public Barcoder()
        {
            MainInit();
        }

        void MainInit()
        {
            db = new List<Paint>();
            formatter = new XmlSerializer(typeof(List<Paint>));
            btnList = new List<Button>();

            InitializeComponent();
            InitializeButtons();
            LockAndClearButtons();
            InitRanges();
            //IniializeDB();

            switch (curMode)
            {
                case AppMode.Maxidom:
                    fileName = "dbM.xml";
                    break;
                case AppMode.Petrovich:
                    fileName = "dbP.xml";
                    break;
            }

            using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate))
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
            copiedLabel.Text = "Выберите продукт";

            foreach (var paint in db)
            {
                if (paint.Brand.Equals(brandsBox.SelectedItem.ToString()))
                {
                    productsBox.Items.Add(paint.Product);
                }
            }
            productsBox.Focus();
        }

        private void productsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LockAndClearButtons();
            copiedLabel.Text = string.Empty;

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
                            btnList[i].Text = $"{curBase} | {curVolume} | {curBarcode}";
                            btnList[i].Image = GenerateBarcode(curBarcode);
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

        private Image GenerateBarcode(string input)
        {
            // create a barcode writer instance
            BarcodeWriter writer = new BarcodeWriter
            {
                Format = BarcodeFormat.CODE_128 // specify the barcode format
            };

            // set encoding options to include margin
            EncodingOptions encodingOptions = new EncodingOptions
            {
                Margin = 2, // add 10 pixels margin around the barcode
                PureBarcode = true, // add human-readable text under the barcode
                Height = 35, // specify the height of the barcode image
                Width = 50
            };
            writer.Options = encodingOptions;

            // generate the barcode image
            Bitmap barcodeBitmap = writer.Write(input);

            // return the new bitmap as an image
            return barcodeBitmap;
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
            string barcode = dataBtn1.Text.Substring(dataBtn1.Text.Length - (int)curMode);
            Clipboard.SetData(DataFormats.Text, barcode);
            copiedLabel.Text = $"Скопирован: {barcode}";
        }

        private void dataBtn2_Click(object sender, EventArgs e)
        {
            string barcode = dataBtn2.Text.Substring(dataBtn2.Text.Length - (int)curMode);
            Clipboard.SetData(DataFormats.Text, barcode);
            copiedLabel.Text = $"Скопирован: {barcode}";
        }

        private void dataBtn3_Click(object sender, EventArgs e)
        {
            string barcode = dataBtn3.Text.Substring(dataBtn3.Text.Length - (int)curMode);
            Clipboard.SetData(DataFormats.Text, barcode);
            copiedLabel.Text = $"Скопирован: {barcode}";
        }

        private void dataBtn4_Click(object sender, EventArgs e)
        {
            string barcode = dataBtn4.Text.Substring(dataBtn4.Text.Length - (int)curMode);
            Clipboard.SetData(DataFormats.Text, barcode);
            copiedLabel.Text = $"Скопирован: {barcode}";
        }

        private void dataBtn5_Click(object sender, EventArgs e)
        {
            string barcode = dataBtn5.Text.Substring(dataBtn5.Text.Length - (int)curMode);
            Clipboard.SetData(DataFormats.Text, barcode);
            copiedLabel.Text = $"Скопирован: {barcode}";
        }

        private void dataBtn6_Click(object sender, EventArgs e)
        {
            string barcode = dataBtn6.Text.Substring(dataBtn6.Text.Length - (int)curMode);
            Clipboard.SetData(DataFormats.Text, barcode);
            copiedLabel.Text = $"Скопирован: {barcode}";
        }

        private void dataBtn7_Click(object sender, EventArgs e)
        {
            string barcode = dataBtn7.Text.Substring(dataBtn7.Text.Length - (int)curMode);
            Clipboard.SetData(DataFormats.Text, barcode);
            copiedLabel.Text = $"Скопирован: {barcode}";
        }

        private void dataBtn8_Click(object sender, EventArgs e)
        {
            string barcode = dataBtn8.Text.Substring(dataBtn8.Text.Length - (int)curMode);
            Clipboard.SetData(DataFormats.Text, barcode);
            copiedLabel.Text = $"Скопирован: {barcode}";
        }
        void InitRanges()
        {
            switch (curMode)
            {
                case AppMode.Maxidom:
                    this.brandsBox.AutoCompleteCustomSource.AddRange(new string[] {
                        "Aura",
                        "Dufa",
                        "Dulux",
                        "Eskaro",
                        "Finncolor",
                        "Hammerite",
                        "Holzer",
                        "Marshall",
                        "Parade",
                        "Pinotex",
                        "Rossetti",
                        "TEKC",
                        "Tikkurila",
                        "Лакра",
                        "Текстурол"});
                    this.brandsBox.Items.AddRange(new object[] {
                        "Aura",
                        "Dufa",
                        "Dulux",
                        "Eskaro",
                        "Finncolor",
                        "Hammerite",
                        "Holzer",
                        "Marshall",
                        "Parade",
                        "Pinotex",
                        "Rossetti",
                        "TEKC",
                        "Tikkurila",
                        "Лакра",
                        "Текстурол"});
                    break;
                case AppMode.Petrovich:
                    this.brandsBox.AutoCompleteCustomSource.AddRange(new string[] {
                        "Aura",
                        "Dufa",
                        "Dulux",
                        "Eskaro",
                        "Finncolor",
                        "Hammerite",
                        "L'Impression",
                        "Marshall",
                        "Parade",
                        "Pinotex",
                        "TEKC",
                        "Tikkurila"});
                    this.brandsBox.Items.AddRange(new object[] {
                        "Aura",
                        "Dufa",
                        "Dulux",
                        "Eskaro",
                        "Finncolor",
                        "Hammerite",
                        "L'Impression",
                        "Marshall",
                        "Parade",
                        "Pinotex",
                        "TEKC",
                        "Tikkurila"});
                    break;
                default:
                    break;
            }
        }
    }
}