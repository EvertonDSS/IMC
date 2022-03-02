using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMCForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void altura_MouseDown(object sender, MouseEventArgs e)
        {
           
        }

        private void calcular_Click(object sender, EventArgs e)
        {

            double imc, peso, altura;

            peso = Convert.ToDouble(txtpeso.Text);
            altura = Convert.ToDouble(txtaltura.Text);

            imc = (double)peso / Math.Pow(altura, 2.0);

            

            if (imc < 18.5) {
                txtgrau.Text = "Magreza";
                    }
            else if (imc < 25)
            {
                txtgrau.Text = "Normal";
            }
            else if ( imc < 30)
            {
                txtgrau.Text = "Sobrepeso";
            }
            else
            {
                txtgrau.Text =  "Obesidade"; 
            }

            txtimc.Text = imc.ToString("F2");
        }
    }
}
