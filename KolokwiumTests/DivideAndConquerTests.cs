using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kolokwium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium.Tests
{
    [TestClass()]
    public class DivideAndConquerTests
    {
        [TestMethod()]
        public void DivideTest()
        {
            //tworzy obiekt klasy
            DivideAndConquer target = new DivideAndConquer();
            //inicjalizacja wartości
            int p = 0;
            int r = 7;
            //wartość oczekiwana
            int expected = 3;
            //wykonanie funkcji
            int actual = target.Divide(p, r);
            //sprawdzenie wartości
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ConquerTest()
        {
            //tworzy obiekt klasy
            DivideAndConquer target = new DivideAndConquer();

            //inicjalizacja tablicy wg przypadku testowego
            int[] testTable = { 14, 7, 3, 12, 9, 11, 6, 2 };

            //oczekiwana wartość metody
            int[,] expectedTable = new int[,] { { 14, 9 }, { 7, 11 }, { 3, 6 }, { 12, 2 } };

            //wartość zwrócona przez funkcję
            int[,] returnedTable = target.Conquer(testTable);
            //porównanie tablic
            Assert.AreEqual(returnedTable, expectedTable);
        }

        [TestMethod()]
        public void CombineTest()
        {
            //tworzy obiekt klasy
            DivideAndConquer target = new DivideAndConquer();
            //inicjalizacja wartości
            int[] tablica1 = {14, 7, 3, 12};
            int[] tablica2 = {9, 11, 6, 2};
            //łączy tablica
            int[] tablica = new int[8];
            //porównanie tablic
            Assert.AreEqual(returnedTable, tablica);
        }
    }
}