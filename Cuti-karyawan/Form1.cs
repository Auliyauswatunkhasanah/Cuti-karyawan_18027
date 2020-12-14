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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-FL3VMLAT;Initial Catalog=cuti_karyawan;User ID=sa;Password=newWorld");
            SqlDataAdapter da = new SqlDataAdapter("Select Count (*) From login where Username='" + textBox1.Text + "' and Password='" + textBox2.Text + "'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1" && checkBox1.Checked)
            {
                this.Hide();
                Form2 menu = new Form2();
                menu.Show();
            }
            else
            {
                MessageBox.Show("Please check your Username and Password", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
