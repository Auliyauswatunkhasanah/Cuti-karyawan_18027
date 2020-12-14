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
using System.Globalization;
using System.Text.RegularExpressions;
using System.IO;

namespace Cuti_karyawan
{
    public partial class Form3 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-FL3VMLAT;Initial Catalog=cuti_karyawan;User ID=sa;Password=newWorld");

        public Form3()
        {
            InitializeComponent();
        }
        string imglocation = "";
        SqlCommand cmd;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 menu = new Form2();
            menu.Show();
        }
        
        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            String query = "DELETE FROM [Data_Karyawan] where NIP='" + textBox1.Text + "'";
            SqlDataAdapter dataadp = new SqlDataAdapter(query, con);
            dataadp.SelectCommand.ExecuteNonQuery();
            con.Close();
            textBox1.Text = "";
            MessageBox.Show("data delete successfully", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            display_data();

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cuti_karyawanDataSet4.Data_Karyawan' table. You can move, or remove it, as needed.
            this.data_KaryawanTableAdapter.Fill(this.cuti_karyawanDataSet4.Data_Karyawan);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte[] images = null;
            FileStream streem = new FileStream(imglocation, FileMode.Open, FileAccess.Read);
            BinaryReader brs = new BinaryReader(streem);
            images = brs.ReadBytes((int)streem.Length);
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO dbo.Data_Karyawan(NIP,Nama_Karyawan,Tempat_Lahir,Tanggal_Lahir,Gender,Telphon,Alamat,Pendidikan,Status,Jabatan,Foto) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + dateTimePicker1.Text + "','" + comboBox1.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + comboBox2.Text + "','" + comboBox3.Text + "',@images)";
            cmd.Parameters.Add(new SqlParameter("@images", images));
            cmd.ExecuteNonQuery();
            con.Close();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            comboBox1.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            pictureBox2.ImageLocation = null;
            MessageBox.Show("anda berhasil menambahkan data baru", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        public void display_data()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from [Data_Karyawan]";
            cmd.ExecuteNonQuery();
            DataTable dta = new DataTable();
            SqlDataAdapter dataadp = new SqlDataAdapter(cmd);
            dataadp.Fill(dta);
            dataGridView1.DataSource = dta;
            con.Close();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            display_data();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files (*.png) |*.png |jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imglocation = dialog.FileName.ToString();
                pictureBox2.ImageLocation = imglocation;
            }
        }

        private void dataKaryawanBindingSource2_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            byte[] images = null;
            FileStream streem = new FileStream(imglocation, FileMode.Open, FileAccess.Read);
            BinaryReader brs = new BinaryReader(streem);
            images = brs.ReadBytes((int)streem.Length);
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE [Data_Karyawan] set Nama_Karyawan = '" + this.textBox2.Text + "',Tempat_Lahir = '" + this.textBox3.Text + "', Tanggal_Lahir = '" + this.dateTimePicker1.Text + "', Gender = '" + this.comboBox1.Text + "', Telphon = '" + this.textBox4.Text + "', Alamat = '" + this.textBox5.Text + "', Pendidikan = '" + this.textBox6.Text + "', Status = '" + this.comboBox2.Text + "', Jabatan = '" + this.comboBox3.Text + "', Foto = @images WHERE NIP = '" + this.textBox1.Text + "'";
            cmd.Parameters.Add(new SqlParameter("@images", images));
            cmd.ExecuteNonQuery();
            con.Close();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            comboBox1.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            pictureBox2.ImageLocation = null;
            MessageBox.Show("anda berhasil update data", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from [Data_Karyawan] where Nama_Karyawan='" + textBox7.Text + "'";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
            textBox7.Text = "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            comboBox1.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            pictureBox2.ImageLocation = "";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            gridview lihat = new gridview();
            lihat.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
            
    }
}
