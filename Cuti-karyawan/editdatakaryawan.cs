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
    public partial class editdatakaryawan : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-FL3VMLAT;Initial Catalog=cuti_karyawan;User ID=sa;Password=newWorld");
        public editdatakaryawan()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            gridview data_karyawan = new gridview();
            data_karyawan.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            String query = "UPDATE dbo.Data_Karyawan SET Nama_Karyawan = '" + textBox2.Text + "',Tempat_Lahir = '" + textBox3.Text + "', Tanggal_Lahir = '" + dateTimePicker1.Text + "', Gender = '" + comboBox1.Text + "', Telphon = '" + textBox4.Text + "', Alamat = '" + textBox5.Text + "', Pendidikan = '" + textBox6.Text + "', Status = '" + comboBox2.Text + "', Jabatan = '" + comboBox3.Text + "'WHERE NIP = '" + textBox1.Text + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("anda berhasil Update data baru", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
