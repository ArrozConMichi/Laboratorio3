using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Laboratorio__3
{
    public partial class Problema1 : Form
    {
        private CuentaBanco cuenta;
        public Problema1()
        {
            InitializeComponent();
        }

        private void btnAbrirCuenta_Click(object sender, EventArgs e)
        {
            string nomCliente = txtCliente.Text;
            decimal cantidadInicial;

            // Validar que el monto inicial sea numérico
            if (decimal.TryParse(txtMonInicial.Text, out cantidadInicial))
            {
                // Crear la cuenta
                cuenta = new CuentaBanco(nomCliente, cantidadInicial);

                // Mostrar el saldo inicial
                txtSaldo.Text = cuenta.GetFormattedBalance();
                // Habilitar los controles para realizar transacciones
                rdbDeposito.Enabled = true;
                rdbRetiro.Enabled = true;
                btnAbrirCuenta.Enabled = true;
            }
            else
            {
                MessageBox.Show("Por favor ingrese un monto válido");
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            // Limpiar los campos de entrada
            txtCliente.Clear();
            txtMonInicial.Clear();
            txtSaldo.Clear();

            // Limpiar los DataGridViews de retiros y depósitos
            dgvRetiro.Rows.Clear();
            dgvDeposito.Rows.Clear();

            // Deshabilitar las opciones de transacciones hasta que se abra una nueva cuenta
            rdbDeposito.Enabled = false;
            rdbRetiro.Enabled = false;

            // Deshabilitar el botón de transacción hasta que se abra una nueva cuenta
            btnAbrirCuenta.Enabled = true;
        }

        private void btnTransaccionar_Click(object sender, EventArgs e)
        {
            decimal monto;

            // Validar que el monto ingresado en txtCantidad sea numérico
            if (decimal.TryParse(txtCantidad.Text, out monto))
            {
                if (rdbDeposito.Checked)
                {
                    // Realizar depósito
                    cuenta.Deposito(monto);

                    // Añadir el depósito al DataGridView de depósitos
                    dgvDeposito.Rows.Add(monto);

                    // Actualizar el saldo en txtSaldo
                    txtSaldo.Text = cuenta.GetFormattedBalance();
                }
                else if (rdbRetiro.Checked)
                {
                    // Verificar si el retiro es válido
                    if (cuenta.Withdraw(monto))
                    {
                        // Añadir el retiro al DataGridView de retiros
                        dgvRetiro.Rows.Add(monto);

                        // Actualizar el saldo en txtSaldo
                        txtSaldo.Text = cuenta.GetFormattedBalance();
                    }
                    else
                    {
                        MessageBox.Show("Saldo insuficiente para el retiro.");
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione si desea realizar un depósito o retiro.");
                }

                // Limpiar el campo de monto
                txtCantidad.Clear();
            }
            else
            {
                MessageBox.Show("Ingrese un monto válido.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Configurar las columnas del DataGridView de Retiros
            dgvRetiro.ColumnCount = 1;
            dgvRetiro.Columns[0].Name = "Monto Retiro";
            dgvRetiro.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Configurar las columnas del DataGridView de Depósitos
            dgvDeposito.ColumnCount = 1;
            dgvDeposito.Columns[0].Name = "Monto Depósito";
            dgvDeposito.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Evitar que los usuarios editen directamente las celdas
            dgvRetiro.ReadOnly = true;
            dgvDeposito.ReadOnly = true;

            // Configurar para que los DataGridView crezcan dinámicamente según las transacciones
            dgvRetiro.AllowUserToAddRows = false;  // No permitir agregar filas manualmente
            dgvDeposito.AllowUserToAddRows = false;  // No permitir agregar filas manualmente
        }
    }
}
