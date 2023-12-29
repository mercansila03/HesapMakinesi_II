using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hesap_Makinesi_II
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      

    
       

        private void btnSonuc_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex==0)
            {
                double toplam=Convert.ToDouble(sayi1.Text) + Convert.ToDouble(sayi2.Text);
                labelSonuc.Text=Convert.ToString(toplam);
            }else

            if (comboBox1.SelectedIndex == 1)
            {
                double fark = Convert.ToDouble(sayi1.Text) - Convert.ToDouble(sayi2.Text);
                labelSonuc.Text = Convert.ToString(fark);
            }else

            if (comboBox1.SelectedIndex == 2)
            {
                double carpim = Convert.ToDouble(sayi1.Text) * Convert.ToDouble(sayi2.Text);
                labelSonuc.Text = Convert.ToString(carpim);
            }else

            if (comboBox1.SelectedIndex == 3)
            {
                double bolme = Convert.ToDouble(sayi1.Text) / Convert.ToDouble(sayi2.Text);
                labelSonuc.Text = Convert.ToString(bolme);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
