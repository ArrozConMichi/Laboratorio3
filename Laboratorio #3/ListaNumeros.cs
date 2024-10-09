using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio__3
{
    internal class ListaNumeros
    {
        private DataGridView _dataGridView;

        public ListaNumeros(DataGridView dataGridView)
        {
            _dataGridView = dataGridView;
        }


        public void RemoverNumeros(int numberToRemove)
        {
            int totalRows = _dataGridView.RowCount;
            int totalColumns = _dataGridView.ColumnCount;


            List<string> remainingValues = new List<string>();


            foreach (DataGridViewRow row in _dataGridView.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    string cellValue = cell.Value?.ToString();
                    if (cellValue != null && cellValue != numberToRemove.ToString())
                    {
                        remainingValues.Add(cellValue);
                    }
                }
            }


            int currentIndex = 0;
            for (int i = 0; i < totalRows; i++)
            {
                for (int j = 0; j < totalColumns; j++)
                {
                    _dataGridView[j, i].Value = currentIndex < remainingValues.Count ? remainingValues[currentIndex] : null;
                    currentIndex++;
                }
            }
        }
    }
}
