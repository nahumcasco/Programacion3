using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO
{
    public partial class CuentaBancaria : Form
    {
        public CuentaBancaria()
        {
            InitializeComponent();
        }

        Cliente cliente;
        Cuenta cuenta;
        MovimientosCuenta movimientosCuenta;
        List<MovimientosCuenta> listaMovimientosCuenta;


        private void CrearCuentaButton_Click(object sender, EventArgs e)
        {
            // 1.Crear el Cliente
            cliente = new Cliente(IdentidadClienteTextBox.Text, NombreClienteTextBox.Text);

            // 2.Crear La Cuenta
            cuenta = new Cuenta(NumeroCuentaTextBox.Text, cliente, DateTime.Now);

            SaldoTextBox.Text = cuenta.Saldo.ToString("N");

        }

        private void AgregarMovimientoButton_Click(object sender, EventArgs e)
        {
            if (MontoMovimientoTextBox.Text == string.Empty)
            {
                MessageBox.Show("Ingrese el monto del movimiento");
                MontoMovimientoTextBox.Focus();
                return;
            }
            if (string.IsNullOrEmpty(TipoMovimeintoComboBox.Text))
            {
                MessageBox.Show("Seleccione el tipo de movimiento");
                return;
            }

            if (TipoMovimeintoComboBox.Text == "Depósito")
            {
                cuenta.Depositar(Convert.ToDecimal(MontoMovimientoTextBox.Text));

                movimientosCuenta = new MovimientosCuenta(cuenta, DateTime.Now, 
                                                Convert.ToDecimal(MontoMovimientoTextBox.Text),
                                                TipoMovimeintoComboBox.Text);

                listaMovimientosCuenta = new List<MovimientosCuenta>();
                listaMovimientosCuenta.Add(movimientosCuenta);

                MovimientosListBox.Items.Add("Depósito a la cuenta N." + cuenta.NumeroCuenta + " por la cantidad de L." +
                                                Convert.ToDecimal(MontoMovimientoTextBox.Text) + " con fecha: " +
                                                movimientosCuenta.FechaMovimiento.ToShortDateString());

                SaldoTextBox.Text = cuenta.Saldo.ToString("N");
            }
            else if (TipoMovimeintoComboBox.Text == "Retiro")
            {
                bool pudoRetirar = cuenta.Retirar(Convert.ToDecimal(MontoMovimientoTextBox.Text));
                if (pudoRetirar)
                {
                    movimientosCuenta = new MovimientosCuenta(cuenta, DateTime.Now,
                                                Convert.ToDecimal(MontoMovimientoTextBox.Text),
                                                TipoMovimeintoComboBox.Text);

                    listaMovimientosCuenta = new List<MovimientosCuenta>();
                    listaMovimientosCuenta.Add(movimientosCuenta);

                    MovimientosListBox.Items.Add("Retiro a la cuenta N." + cuenta.NumeroCuenta + " por la cantidad de L." +
                                                    Convert.ToDecimal(MontoMovimientoTextBox.Text) + " con fecha: " +
                                                    movimientosCuenta.FechaMovimiento.ToShortDateString());

                    SaldoTextBox.Text = cuenta.Saldo.ToString("N");
                }
                else
                {
                    MessageBox.Show("No tiene saldo suficiente para realizar la transacción");
                }
            }
            MontoMovimientoTextBox.Clear();

        }
    }
}
