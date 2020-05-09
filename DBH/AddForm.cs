using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Barcoder;

namespace DBH
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            Paint paint = new Paint();

            paint.Brand = brandBox.SelectedItem.ToString();
            paint.Product = productBox.Text;
            paint.Data[0].Base = baseBox1.SelectedItem.ToString();
            paint.Data[0].Volume = float.Parse(volumeBox1.Text);
            paint.Data[0].Barcode = int.Parse(bcBox1.Text);
            paint.Data[1].Base = baseBox2.SelectedItem.ToString();
            paint.Data[1].Volume = float.Parse(volumeBox2.Text);
            paint.Data[1].Barcode = int.Parse(bcBox2.Text);
            paint.Data[2].Base = baseBox3.SelectedItem.ToString();
            paint.Data[2].Volume = float.Parse(volumeBox3.Text);
            paint.Data[2].Barcode = int.Parse(bcBox3.Text);
            paint.Data[3].Base = baseBox4.SelectedItem.ToString();
            paint.Data[3].Volume = float.Parse(volumeBox4.Text);
            paint.Data[3].Barcode = int.Parse(bcBox4.Text);
            paint.Data[4].Base = baseBox5.SelectedItem.ToString();
            paint.Data[4].Volume = float.Parse(volumeBox5.Text);
            paint.Data[4].Barcode = int.Parse(bcBox5.Text);
            paint.Data[5].Base = baseBox6.SelectedItem.ToString();
            paint.Data[5].Volume = float.Parse(volumeBox6.Text);
            paint.Data[5].Barcode = int.Parse(bcBox6.Text);

            Helper.db.Add(paint);

            //Дописать сериализацию объекта и обновление списка продуктов главного окна

        }
    }
}
