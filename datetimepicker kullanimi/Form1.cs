using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace datetimepicker_kullanimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime baslangic, bitis;

            baslangic = dateTimePicker1.Value;
            bitis = dateTimePicker2.Value;

            TimeSpan ts;

            ts = bitis - baslangic;

            MessageBox.Show(ts.Days.ToString() + " Gün");

        }
    }
}
