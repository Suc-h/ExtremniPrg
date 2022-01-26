using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spolecny_ukol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vyberte z dvou políček. Pokud chcete vypočítat mocninu tak zaškrtněte první políčko a pokud faktoriál tak druhé.");
        }

        private void checkBoxMocnina_CheckedChanged(object sender, EventArgs e)
        {
            labelVysledek.Text = " ";
            int a, n;
            a = Convert.ToInt32(numericUpDown1.Value);
            n = Convert.ToInt32(numericUpDown2.Value);
            long mocnina = a;
            while (n-1 != 0)
            {
                mocnina *= a; 
                n--;
            }
            labelVysledek.Text = mocnina.ToString();
        }

        private void checkBoxFaktorial_CheckedChanged(object sender, EventArgs e)
        {
            labelVysledek.Text = " ";
            long faktorial=1;
            int n;   
            n = Convert.ToInt32(numericUpDown2.Value);
            if(n>0)
            {
                while(n!=0)
                {
                    faktorial *= n;
                    n--;
                }
                labelVysledek.Text = faktorial.ToString();
            }
            else
            {
                labelVysledek.Text = "Zadna hodnota pro vypocet!";
            }
        }
    }
}
