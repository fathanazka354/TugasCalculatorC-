using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hasil_Perhitungan
{
    public partial class FrmProses : Form
    {
        public delegate void ProsesEventHandler(Calculator cal);
        public event ProsesEventHandler OnProses;
        private bool dataBaru = true;
        private Calculator cal;

        public FrmProses()
        {
            InitializeComponent();
        }

        public FrmProses(string title) : this()
        {
            this.Text = title;
        }

        private void btnProses_Click(object sender, EventArgs e)
        {
            if (dataBaru) cal = new Calculator();

            cal.NilaiA = txtNilaiA.Text;
            cal.NilaiB = txtNilaiB.Text;

            var a = int.Parse(cal.NilaiA);
            var b = int.Parse(cal.NilaiB);


            if (Operasi.Text == "Penjumlahan")
            {
                cal.NilaiHasil = string.Format("Hasil Penjumlahan {0} + {1} = {2}", a, b, cal.Penjumlahan(a, b));
            }
            else if (Operasi.Text == "Pengurangan")
            {
                cal.NilaiHasil = string.Format("Hasil Pengurangan: {0} - {1} = {2}", a, b, cal.Pengurangan(a, b));
            }
            else if (Operasi.Text == "Perkalian")
            {
                cal.NilaiHasil = string.Format("Hasil Perkalian: {0} * {1} = {2}", a, b, cal.Perkalian(a, b));
            }
            else
            {
                cal.NilaiHasil = string.Format("Hasil Pembagian: {0} / {1} = {2}", a, b, cal.Pembagian(a, b));
            }

            if (dataBaru)
            {
                OnProses(cal);
            }
            else
            {
                this.Close();
            }
        }

        private void txtNilaiA_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
