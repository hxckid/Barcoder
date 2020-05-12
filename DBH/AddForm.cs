﻿using System;
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
            if (brandBox.SelectedItem == null || productBox.Text.Equals(null))
                return;

            Paint paint = new Paint();

            paint.Brand = brandBox.SelectedItem.ToString();
            paint.Product = productBox.Text;
            
            if (string.IsNullOrEmpty(volumeBox1.Text) || string.IsNullOrEmpty(bcBox1.Text))
                paint.Data.Add(new ProductData());
            else
                paint.Data.Add(new ProductData(baseBox1.Text, volumeBox1.Text, bcBox1.Text));

            if (string.IsNullOrEmpty(volumeBox2.Text) || string.IsNullOrEmpty(bcBox2.Text))
                paint.Data.Add(new ProductData());
            else
                paint.Data.Add(new ProductData(baseBox2.Text, volumeBox2.Text, bcBox2.Text));
            
            if (string.IsNullOrEmpty(volumeBox3.Text) || string.IsNullOrEmpty(bcBox3.Text))
                paint.Data.Add(new ProductData());
            else
                paint.Data.Add(new ProductData(baseBox3.Text, volumeBox3.Text, bcBox3.Text));
            
            if (string.IsNullOrEmpty(volumeBox4.Text) || string.IsNullOrEmpty(bcBox4.Text))
                paint.Data.Add(new ProductData());
            else
                paint.Data.Add(new ProductData(baseBox4.Text, volumeBox4.Text, bcBox4.Text));

            if (string.IsNullOrEmpty(volumeBox5.Text) || string.IsNullOrEmpty(bcBox5.Text))
                paint.Data.Add(new ProductData());
            else
                paint.Data.Add(new ProductData(baseBox5.Text, volumeBox5.Text, bcBox5.Text));

            if (string.IsNullOrEmpty(volumeBox6.Text) || string.IsNullOrEmpty(bcBox6.Text))
                paint.Data.Add(new ProductData());
            else
                paint.Data.Add(new ProductData(baseBox6.Text, volumeBox6.Text, bcBox6.Text));

            RemoveOld(paint);

            Helper.db.Add(paint);
            Helper.WriteDB();
            
            this.Close();
        }

        private void RemoveOld(Paint _paint)
        {
            foreach (var paint in Helper.db)
            {
                if (_paint.Product == paint.Product)
                {
                    Helper.db.Remove(paint);
                    break;
                }
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
