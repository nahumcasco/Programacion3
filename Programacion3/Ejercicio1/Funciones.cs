using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Funciones : Form
    {
        public Funciones()
        {
            InitializeComponent();
        }

        private void LimpiarButton_Click(object sender, EventArgs e)
        {
            LimpiarControles();
        }

        private void LimpiarControles()
        {
            Numero1TextBox.Clear();
            Numero2TextBox.Clear();
            ResultadoLabel.Text = string.Empty;
            //Numero1TextBox.Text = "";
            //Numero1TextBox.Text = string.Empty;
        }

        private int Sumar(int valor1, int valor2)
        {
            return valor1 + valor2;
        }

        private int Resta(int valor1, int valor2)
        {
            int resta = valor1 - valor2;
            return resta;
        }

        private int Multiplicar(int valor1, int valor2)
        {
            return valor1 * valor2;
        }
        private int Dividir(int valor1, int valor2)
        {
            return valor1 / valor2;
        }


        private void SumaButton_Click(object sender, EventArgs e)
        {
           ResultadoLabel.Text = Sumar(Convert.ToInt32(Numero1TextBox.Text), Convert.ToInt32(Numero2TextBox.Text)).ToString();
        }

        private void RestaButton_Click(object sender, EventArgs e)
        {
            ResultadoLabel.Text = Resta(Convert.ToInt32(Numero1TextBox.Text), Convert.ToInt32(Numero2TextBox.Text)).ToString();
        }

        private void MultiplicarButton_Click(object sender, EventArgs e)
        {
            ResultadoLabel.Text = Multiplicar(Convert.ToInt32(Numero1TextBox.Text), Convert.ToInt32(Numero2TextBox.Text)).ToString();
        }

        private void DividirButton_Click(object sender, EventArgs e)
        {
            ResultadoLabel.Text = Dividir(Convert.ToInt32(Numero1TextBox.Text), Convert.ToInt32(Numero2TextBox.Text)).ToString();
        }
    }
}
