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

        private ListaNumeros listaNumeros;

        public Problema2()
        {
            InitializeComponent();
            listaNumeros = new ListaNumeros();
            dgvNumeros.RowCount = 5;
            dgvNumeros.ColumnCount = 5;

        }

        private void Problema2_Load(object sender, EventArgs e)
        {

        }

        private void dgvNumeros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            string input = Interaction.InputBox("Ingresa un número para eliminar sus ocurrencias:", "Eliminar Ocurrencias", "", -1, -1);

            if (int.TryParse(input, out int numero))
            {

                listaNumeros.RemoveOccurrences(numero);
                ActualizarDgv();
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un número válido.");
            }
        }

        private void ActualizarDgv()
        {
            dgvNumeros.DataSource = null;
            dgvNumeros.DataSource = new BindingSource { DataSource = listaNumeros.GetNumbers() };

        }


    }
}

