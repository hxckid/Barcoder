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

            //Paint first = new Paint();
            //Paint second = new Paint();
            //db.Add(first);
            //db.Add(second);

            //using (FileStream fs = new FileStream("db.xml", FileMode.OpenOrCreate))
            //{
            //    formatter.Serialize(fs, db);
            //}

            using (FileStream fs = new FileStream("db.xml", FileMode.OpenOrCreate))
            {
                db = (List<Paint>)formatter.Deserialize(fs);
            }
        }

        private void brandsBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
