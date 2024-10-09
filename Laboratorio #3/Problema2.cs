using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;


namespace Laboratorio__3
{
    public partial class Problema2 : Form
    {

        private int currentCellIndex = 0;

        public Problema2()
        {
            InitializeComponent();
            dgvNumeros.ColumnCount = 5;
            dgvNumeros.RowCount = 5;
            dgvNumeros.AllowUserToAddRows = false;
            dgvNumeros.AllowUserToDeleteRows = false;
            dgvNumeros.AllowUserToResizeColumns = false;
            dgvNumeros.AllowUserToResizeRows = false;

        }

        private void Problema2_Load(object sender, EventArgs e)
        {

        }

        private void dgvNumeros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            ListaNumeros lista = new ListaNumeros(dgvNumeros);
            string input = Interaction.InputBox("Ingrese el número que desea eliminar:", "Eliminar Número", "0");

            if (int.TryParse(input, out int numberToRemove))
            {
                lista.RemoverNumeros(numberToRemove);
            }
            else
            {
                MessageBox.Show("Por favor ingrese un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (currentCellIndex < 25)
            {

                string input = Interaction.InputBox("Ingrese un número para el siguiente espacio en el grid:", "Ingresar Número", "0");

                if (int.TryParse(input, out int number))
                {
                    int rowIndex = currentCellIndex / 5;
                    int colIndex = currentCellIndex % 5;

                    if (rowIndex >= 0 && rowIndex < 5 && colIndex >= 0 && colIndex < 5)
                    {
                        dgvNumeros[colIndex, rowIndex].Value = number;
                        currentCellIndex++;
                    }
                }
                else
                {
                    MessageBox.Show("Por favor ingrese un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("El DataGridView ya está lleno.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

