using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cuti_karyawan
{
    public partial class lihatcuti : Form
    {
        public lihatcuti()
        {
            InitializeComponent();
        }

        private void lihatcuti_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cuti_karyawanDataSet1.Cuti_Karyawan' table. You can move, or remove it, as needed.
            this.cuti_KaryawanTableAdapter.Fill(this.cuti_karyawanDataSet1.Cuti_Karyawan);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 cuti = new Form4();
            cuti.Show();
        }
    }
}
