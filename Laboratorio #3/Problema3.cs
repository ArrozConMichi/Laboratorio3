using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio__3
{
    public partial class Problema3 : Form
    {
        private List<decimal> listaVentas = new List<decimal>();
        public Problema3()
        {
            InitializeComponent();
            dataGridView1.Columns.Add("Importe", "Importe");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(textBox1.Text, out decimal importe))
            {

                listBox1.Items.Add(importe);
                listaVentas.Add(importe);
                textBox1.Clear();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un importe válido.");
            }
        }

        private void buttonMostrarVentas_Click(object sender, EventArgs e)
        {
            Ventas.agregarVenta(listaVentas);


            var ventasFiltradas = Ventas.filtrarOrdenar();


            dataGridView1.Rows.Clear();

            foreach (var venta in ventasFiltradas)
            {
                dataGridView1.Rows.Add(venta);
            }

            if (ventasFiltradas.Count == 0)
            {
                MessageBox.Show("No hay ventas en el rango especificado.");
            }
        }
    }
}
