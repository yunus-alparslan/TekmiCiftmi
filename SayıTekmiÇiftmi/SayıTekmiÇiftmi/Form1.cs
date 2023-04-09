using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SayıTekmiÇiftmi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int sayı = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            sayı = Convert.ToInt16(textBox1.Text);

            if (sayı % 2 == 0)
            {
                label2.Text = "Çift";
                this.BackColor = Color.AliceBlue;
            }
            else
            {
                label2.Text = "Tek";
                this.BackColor = Color.Aqua;
            }


            


        }
    }
}
