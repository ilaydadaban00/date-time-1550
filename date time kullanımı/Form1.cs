using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace date_time_kullanımı
{
    public partial class Form1 : Form
    {
        DateTime bugun = DateTime.Now;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = bugun.Date.ToString();

        }

        private void btnBuyukTarih_Click(object sender, EventArgs e)
        {
            label1.Text = bugun.Month.ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            label1.Text = bugun.Day.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = bugun.Year.ToString();

        }
    }
}
