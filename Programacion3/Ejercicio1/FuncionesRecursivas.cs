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
    public partial class FuncionesRecursivas : Form
    {
        public FuncionesRecursivas()
        {
            InitializeComponent();
        }

        private void EjecutarButton_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                listBox1.Items.Clear();
            }
            RecorrerDeUnoEnUno(1, 10);
        }

        private void RecorrerDeUnoEnUno(int num1, int num2)
        {
            listBox1.Items.Add(num1);
            if (num1 < num2)
            {
                RecorrerDeUnoEnUno(num1 + 1, num2);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 10; i++)
            {
                listBox1.Items.Add(i);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El Factorial de " + textBox1.Text + " es: " + FactorialDe(Convert.ToDecimal(textBox1.Text)).ToString());
        }

        private decimal FactorialDe(decimal numero)
        {
            if (numero == 1)
            {
                return numero;
            }
            else
            {
                return numero * FactorialDe(numero - 1);
            }
        }



    }
}
