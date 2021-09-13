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
    public partial class FuncionesDeTexto : Form
    {
        public FuncionesDeTexto()
        {
            InitializeComponent();
        }

        private void EjecutarButton_Click(object sender, EventArgs e)
        {
            string cadena = CadenaTextBox.Text;

            //Obtener la longitud de la cadena ingresada
            LongitudTextBox.Text = Convert.ToString(cadena.Length);// .ToString();

            //Obtener el primer elemento o caracter
            PrimerCaractertextBox.Text = cadena.Substring(0, 1);

            //Obtener el último elemento o caracter
            UltimoTextBox.Text = cadena.Substring(cadena.Length - 1, 1);

            //Rango de x a y
            RangoTextBox.Text = cadena.Substring(5, 15);

            //Convertir a mayúsculas
            MayusculaTextBox.Text = cadena.ToUpper();

            //Convertir a Minúscula
            MinusculaTextBox.Text = cadena.ToLower();

            //Reemplazar
            ReemplazarTextBox.Text = cadena.Replace("a", "b");

            //Primer Letra en Mayúscula
            PrimeraMextBox.Text = cadena.Substring(0, 1).ToUpper() + cadena.Substring(1, cadena.Length -1).ToLower();

        }
    }
}
