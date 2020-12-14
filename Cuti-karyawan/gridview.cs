using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Cuti_karyawan
{
    public partial class gridview : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-FL3VMLAT;Initial Catalog=cuti_karyawan;User ID=sa;Password=newWorld");
        public gridview()
        {
            InitializeComponent();
        }

        private void gridview_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cuti_karyawanDataSet2.Data_Karyawan' table. You can move, or remove it, as needed.
            this.data_KaryawanTableAdapter1.Fill(this.cuti_karyawanDataSet2.Data_Karyawan);
            // TODO: This line of code loads data into the 'cuti_karyawanDataSet.Data_Karyawan' table. You can move, or remove it, as needed.
            this.data_KaryawanTableAdapter.Fill(this.cuti_karyawanDataSet.Data_Karyawan);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 tambahkaryawan = new Form3();
            tambahkaryawan.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 menu = new Form2();
            menu.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            editdatakaryawan update = new editdatakaryawan();
            update.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            String query = "DELETE FROM dbo.Data_Karyawan where dataGridView1 ='" ;
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show(" berhasil delete data ");
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form3 men = new Form3();
            men.Show();
        }
    }
}
