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
    public partial class FuncionesDeFecha : Form
    {
        public FuncionesDeFecha()
        {
            InitializeComponent();
        }

        private void EjecutarButton_Click(object sender, EventArgs e)
        {
            DateTime fechaIngresada = FechaDateTimePicker.Value;

            NumeroDiaTextBox.Text = fechaIngresada.Day.ToString();
            NumeroMestextBox.Text = fechaIngresada.Month.ToString();
            AnioTextBox.Text = fechaIngresada.Year.ToString();
            HoraTextBox.Text = fechaIngresada.Hour.ToString();

            MesTextBox.Text = fechaIngresada.ToString("MMMM");

            int numeroDias = Convert.ToInt32(AgregarDiastextBox.Text);
            int numeroDiasARestar = Convert.ToInt32(DiasARestartextBox.Text);

            NuevaFechaConDiastextBox.Text = fechaIngresada.AddDays(numeroDias).ToShortDateString();
            NuevaFechaRestadatextBox.Text = fechaIngresada.AddDays(-numeroDiasARestar).ToShortDateString();

            EdadTextBox.Text = DevolverEdad(fechaIngresada).ToString();



        }

        private int DevolverEdad(DateTime fechaNacimiento)
        {
            DateTime _fechaNacimiento = fechaNacimiento;
            DateTime _fechaActual = DateTime.Now;

            int edad;

            if (_fechaNacimiento >= _fechaActual)
            {
                return 0;
            }
            else
            {
                edad = _fechaActual.Year - _fechaNacimiento.Year;
                if (_fechaNacimiento.Month > _fechaActual.Month)
                {
                    --edad;
                }
                return edad;
            }

        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            HoraLabel.Text = DateTime.Now.ToLongTimeString();
        }

        private void FuncionesDeFecha_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
    }
}
