using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class ListaNumeros

    {

        private List<int> numeros;

        public ListaNumeros()
        {
            numeros = new List<int>();
        }



        public void AddNumber(int numero) => numeros.Add(numero);


        public void RemoveOccurrences(int numero)
        {
            numeros.RemoveAll(n => n == numero);
        }


        public List<int> GetNumbers()
        {
            return numeros;
        }


    }
