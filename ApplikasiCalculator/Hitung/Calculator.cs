using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hasil_Perhitungan
{
    public class Calculator
    {
        public string NilaiA { get; set; }
        public string NilaiB { get; set; }
        public string NilaiHasil { get; set; }

        public int Penjumlahan(int a, int b)
        {
            return a + b;
        }

        public int Pengurangan(int a, int b)
        {
            return a - b;
        }

        public int Perkalian(int a, int b)
        {
            return a * b;
        }

        public int Pembagian(int a, int b)
        {
            return a / b;
        }
    }
}
