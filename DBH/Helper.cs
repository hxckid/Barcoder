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
    public partial class Helper : Form
    {
        public static List<Paint> db = new List<Paint>();
        XmlSerializer formatter = new XmlSerializer(typeof(List<Paint>));

        public Helper()
        {
            InitializeComponent();

            ReadDB();
        }

        private void RefreshProductList(object lastItem)
        {
            productsBox.Items.Clear();
            brandsBox.SelectedItem = lastItem;
            brandsBox_SelectedIndexChanged(new object(), new EventArgs());
        }

        private void WriteDB()
        {
            using (FileStream fs = new FileStream("db.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                fs.SetLength(0);
                formatter.Serialize(fs, db);
            }
        }

        private void ReadDB()
        {
            using (FileStream fs = new FileStream("db.xml", FileMode.OpenOrCreate))
            {
                db = (List<Paint>)formatter.Deserialize(fs);
            }
        }

        private void brandsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (brandsBox.SelectedItem == null)
                return;

            foreach (var paint in db)
            {
                if (paint.Brand.Equals(brandsBox.SelectedItem.ToString()))
                {
                    productsBox.Items.Add(paint.Product);
                }
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            ReadDB();
            var lastItem = brandsBox.SelectedItem;
            RefreshProductList(lastItem);
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

            var lastItem = brandsBox.SelectedItem;
            RefreshProductList(lastItem);
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
            add.productBox.Enabled = false;
            switch (currentPaint.Data.Count)
            {
                case 1:
                    add.baseBox1.Text = currentPaint.Data[0].Base;
                    add.volumeBox1.Text = currentPaint.Data[0].Volume.ToString();
                    add.bcBox1.Text = currentPaint.Data[0].Barcode.ToString();
                    break;
                case 2:
                    add.baseBox1.Text =   currentPaint.Data[0].Base;
                    add.volumeBox1.Text = currentPaint.Data[0].Volume.ToString();
                    add.bcBox1.Text =     currentPaint.Data[0].Barcode.ToString();

                    add.baseBox2.Text =   currentPaint.Data[1].Base;
                    add.volumeBox2.Text = currentPaint.Data[1].Volume.ToString();
                    add.bcBox2.Text =     currentPaint.Data[1].Barcode.ToString();
                    break;
                case 3:
                    add.baseBox1.Text =   currentPaint.Data[0].Base;
                    add.volumeBox1.Text = currentPaint.Data[0].Volume.ToString();
                    add.bcBox1.Text =     currentPaint.Data[0].Barcode.ToString();

                    add.baseBox2.Text =   currentPaint.Data[1].Base;
                    add.volumeBox2.Text = currentPaint.Data[1].Volume.ToString();
                    add.bcBox2.Text =     currentPaint.Data[1].Barcode.ToString();

                    add.baseBox3.Text =   currentPaint.Data[2].Base;
                    add.volumeBox3.Text = currentPaint.Data[2].Volume.ToString();
                    add.bcBox3.Text =     currentPaint.Data[2].Barcode.ToString();
                    break;
                case 4:
                    add.baseBox1.Text =   currentPaint.Data[0].Base;
                    add.volumeBox1.Text = currentPaint.Data[0].Volume.ToString();
                    add.bcBox1.Text =     currentPaint.Data[0].Barcode.ToString();

                    add.baseBox2.Text =   currentPaint.Data[1].Base;
                    add.volumeBox2.Text = currentPaint.Data[1].Volume.ToString();
                    add.bcBox2.Text =     currentPaint.Data[1].Barcode.ToString();

                    add.baseBox3.Text =   currentPaint.Data[2].Base;
                    add.volumeBox3.Text = currentPaint.Data[2].Volume.ToString();
                    add.bcBox3.Text =     currentPaint.Data[2].Barcode.ToString();

                    add.baseBox4.Text =   currentPaint.Data[3].Base;
                    add.volumeBox4.Text = currentPaint.Data[3].Volume.ToString();
                    add.bcBox4.Text =     currentPaint.Data[3].Barcode.ToString();
                    break;
                case 5:
                    add.baseBox1.Text =   currentPaint.Data[0].Base;
                    add.volumeBox1.Text = currentPaint.Data[0].Volume.ToString();
                    add.bcBox1.Text =     currentPaint.Data[0].Barcode.ToString();

                    add.baseBox2.Text =   currentPaint.Data[1].Base;
                    add.volumeBox2.Text = currentPaint.Data[1].Volume.ToString();
                    add.bcBox2.Text =     currentPaint.Data[1].Barcode.ToString();

                    add.baseBox3.Text =   currentPaint.Data[2].Base;
                    add.volumeBox3.Text = currentPaint.Data[2].Volume.ToString();
                    add.bcBox3.Text =     currentPaint.Data[2].Barcode.ToString();

                    add.baseBox4.Text =   currentPaint.Data[3].Base;
                    add.volumeBox4.Text = currentPaint.Data[3].Volume.ToString();
                    add.bcBox4.Text =     currentPaint.Data[3].Barcode.ToString();

                    add.baseBox5.Text =   currentPaint.Data[4].Base;
                    add.volumeBox5.Text = currentPaint.Data[4].Volume.ToString();
                    add.bcBox5.Text =     currentPaint.Data[4].Barcode.ToString();
                    break;
                case 6:
                    add.baseBox1.Text =   currentPaint.Data[0].Base;
                    add.volumeBox1.Text = currentPaint.Data[0].Volume.ToString();
                    add.bcBox1.Text =     currentPaint.Data[0].Barcode.ToString();

                    add.baseBox2.Text =   currentPaint.Data[1].Base;
                    add.volumeBox2.Text = currentPaint.Data[1].Volume.ToString();
                    add.bcBox2.Text =     currentPaint.Data[1].Barcode.ToString();

                    add.baseBox3.Text =   currentPaint.Data[2].Base;
                    add.volumeBox3.Text = currentPaint.Data[2].Volume.ToString();
                    add.bcBox3.Text =     currentPaint.Data[2].Barcode.ToString();

                    add.baseBox4.Text =   currentPaint.Data[3].Base;
                    add.volumeBox4.Text = currentPaint.Data[3].Volume.ToString();
                    add.bcBox4.Text =     currentPaint.Data[3].Barcode.ToString();

                    add.baseBox5.Text =   currentPaint.Data[4].Base;
                    add.volumeBox5.Text = currentPaint.Data[4].Volume.ToString();
                    add.bcBox5.Text =     currentPaint.Data[4].Barcode.ToString();

                    add.baseBox6.Text =   currentPaint.Data[5].Base;
                    add.volumeBox6.Text = currentPaint.Data[5].Volume.ToString();
                    add.bcBox6.Text =     currentPaint.Data[5].Barcode.ToString();
                    break;
            }

            add.Show();
        }
    }
}
