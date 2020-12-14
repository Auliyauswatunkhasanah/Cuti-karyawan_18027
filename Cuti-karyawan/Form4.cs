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
    public partial class Form4 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-FL3VMLAT;Initial Catalog=cuti_karyawan;User ID=sa;Password=newWorld");

        public Form4()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 menu = new Form2();
            menu.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            String query = "INSERT INTO dbo.Cuti_Karyawan(Cuti_ID,NIP,Nama_Karyawan,Status,Jabatan,Mulai_Cuti,Akhir_Cuti, Keterangan) VALUES ('" + textBox4.Text + "','" + textBox1.Text + "','" + textBox2.Text + "','" + comboBox2.Text + "','" + comboBox3.Text + "','" + dateTimePicker1.Text + "','" + dateTimePicker2.Text + "','" + textBox3.Text + "')";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();

            textBox4.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
            textBox3.Text = "";
            MessageBox.Show("anda berhasil menambahkan data baru", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void display_data()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from [Cuti_Karyawan]";
            cmd.ExecuteNonQuery();
            DataTable dta = new DataTable();
            SqlDataAdapter dataadp = new SqlDataAdapter(cmd);
            dataadp.Fill(dta);
            dataGridView1.DataSource = dta;
            con.Close();
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            String query = "UPDATE dbo.Cuti_Karyawan SET NIP = '" + textBox1.Text + "', Nama_Karyawan= '" + textBox2.Text + "', Status = '" + comboBox2.Text + "', Jabatan = '" + comboBox3.Text + "', Mulai_Cuti = '"+ dateTimePicker1.Text +"',Akhir_Cuti = '"+ dateTimePicker2.Text +"', Keterangan = '" + textBox3.Text + "' WHERE Cuti_ID = '" + textBox4.Text + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            textBox4.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
            textBox3.Text = "";
            MessageBox.Show(" Update Successfull! ");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            display_data();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cuti_karyawanDataSet5.Cuti_Karyawan' table. You can move, or remove it, as needed.
            this.cuti_KaryawanTableAdapter.Fill(this.cuti_karyawanDataSet5.Cuti_Karyawan);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            String query = "DELETE FROM dbo.Cuti_Karyawan where Cuti_ID='" + textBox4.Text + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show(" Record Deleted! ");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from [Cuti_Karyawan] where Nama_Karyawan='" + textBox5.Text + "'";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
            textBox5.Text = "";
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                textBox4.Text = row.Cells[0].Value.ToString();
                textBox1.Text = row.Cells[1].Value.ToString();
                textBox2.Text = row.Cells[2].Value.ToString();
                comboBox2.Text = row.Cells[3].Value.ToString();
                comboBox3.Text = row.Cells[4].Value.ToString();
                dateTimePicker1.Text = row.Cells[5].Value.ToString();
                dateTimePicker2.Text = row.Cells[6].Value.ToString();
                textBox3.Text = row.Cells[7].Value.ToString();
            }
        }
    }
}
