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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void FrmProses_OnProses(Calculator cal)
        {
            Hasil.Items.Add(cal.NilaiHasil);
        }
        private void btnHitung_Click(object sender, EventArgs e)
        {
            FrmProses frmProses = new FrmProses("Calculator");
            frmProses.OnProses += FrmProses_OnProses;
            frmProses.ShowDialog();
        }

        private void Hasil_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
