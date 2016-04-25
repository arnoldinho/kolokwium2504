using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium
{
    public class DivideAndConquer
    {
        int[] tablica = new int [8];
        public int p;
        public int r;
        public int q;

        //zwraca "środek" tablicy
        public int Divide(int p, int r)
        {
            int q = p/r;
            return q;
        }

        //zwraca dwie tablice
        public int[,] Conquer(int[] table)
        {
            int[,] tablicaTablic = new int[2, 4];
            return tablicaTablic;
        }

        //zwraca połaczona tablice
        public int[] Combine(int[] table1, int[] table2)
        {
            int[] table3 = new int[table1.Length+table2.Length];
            for(int i = 0; i <= table3.Length; i++)
            {
            }
            return null;
        }
    }
}
