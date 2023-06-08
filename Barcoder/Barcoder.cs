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
        AppMode curMode;
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
            SetRetailer();
            //InitializeDB();

            switch (curMode)
            {
                case AppMode.Maxidom:
                    fileName = "dbM.xml";
                    break;
                case AppMode.Petrovich:
                    fileName = "dbP.xml";
                    break;
            }
            InitRanges();

            using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                db = (List<Paint>)formatter.Deserialize(fs);
            }
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

        private void InitializeButtons()
        {
            btnList = new List<Button> { dataBtn1, dataBtn2, dataBtn3, dataBtn4, dataBtn5, dataBtn6, dataBtn7, dataBtn8 };
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
                                case "Б1":
                                    btnList[i].BackColor = Color.White;
                                    break;
                                case "BC":
                                case "C":
                                case "D":
                                case "TR":
                                case "MRC":
                                case "VC":
                                case "Б3":
                                    btnList[i].BackColor = Color.IndianRed;
                                    break;
                                case "EP":
                                case "EC":
                                case "NEU":
                                case "Гл":
                                case "Мат":
                                case "П/м":
                                case "П/гл":
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

        private void InitializeDB()
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
            foreach (Button btn in new Button[] { dataBtn1, dataBtn2, dataBtn3, dataBtn4, dataBtn5, dataBtn6, dataBtn7, dataBtn8 })
                btn.Visible = false;
        }

        private void DataBtnsHandler(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string barcode = button.Text.Substring(button.Text.Length - (int)curMode);
            Clipboard.SetData(DataFormats.Text, barcode);
            copiedLabel.Text = $"Скопирован: {barcode}";
        }

        void InitRanges()
        {
            var brands = new List<string>();

            var iniFile = File.ReadAllLines("settings.ini");
            var brandSection = (int)curMode == 5 ? "Maxidom Brands" : "Petrovich Brands";

            // Get the brands from the brand section
            brands = iniFile.SkipWhile(x => !x.StartsWith($"[{brandSection}]"))
                               .Skip(1)
                               .TakeWhile(x => !string.IsNullOrWhiteSpace(x))
                               .ToList();

            this.brandsBox.AutoCompleteCustomSource.AddRange(brands.ToArray());
            this.brandsBox.Items.AddRange(brands.ToArray());
        }
    }
}