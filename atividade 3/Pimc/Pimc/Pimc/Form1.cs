using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pimc
{
    public partial class Form1 : Form
    {
        double peso, altura, imc;

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            mskbxPeso.Text = "";
            mskbxAltura.Text = "";
            txtIMC.Text = "";
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(mskbxPeso.Text, out peso) || !double.TryParse(mskbxAltura.Text, out altura)){
                MessageBox.Show("Dados inválidos.");  
            }
            else
            {
                imc = peso / (altura * altura);
                imc = Math.Round(imc, 1);
                txtIMC.Text = imc.ToString("n2");
                if (imc < 18.5)
                {
                    MessageBox.Show("magreza");
                }
                else if (imc < 25) { MessageBox.Show("Normal");}
                else if (imc < 30) MessageBox.Show("sobrepeso");
                else if (imc < 35) MessageBox.Show("obesidade grau 1");
                else if (imc < 40) MessageBox.Show("obesidade grau 2");
                else MessageBox.Show("obesidade grau 3");
            }
        } 
    }
}
