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
namespace empcrud
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
           SqlConnection con = new SqlConnection(@"Data Source=DELL\SQLEXPRESS;Initial Catalog=empcrud1;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Emptab1 values(@ID,@Name,@Age,@Post)", con);
            cmd.Parameters.AddWithValue("ID", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("Name",(textBox2.Text));
            cmd.Parameters.AddWithValue("Age", double.Parse(textBox3.Text));
            cmd.Parameters.AddWithValue("Post", (textBox4.Text));
           
            cmd.ExecuteNonQuery();
            MessageBox.Show("Successfully Inserted");
            con.Close();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DELL\SQLEXPRESS;Initial Catalog=empcrud1;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Update Emptab set Name=@Name,Age=@Age Post=@Post where ID=@ID",con);
            cmd.Parameters.AddWithValue("ID", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("Name", (textBox2.Text));
            cmd.Parameters.AddWithValue("Age", double.Parse(textBox3.Text));
            cmd.Parameters.AddWithValue("Post", (textBox4.Text));
           
            cmd.ExecuteNonQuery();
            MessageBox.Show("Successfully Updated");
            con.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DELL\SQLEXPRESS;Initial Catalog=empcrud1;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete Emptab1 where ID=@ID", con);
            cmd.Parameters.AddWithValue("ID", int.Parse(textBox1.Text));
            cmd.ExecuteNonQuery();
            MessageBox.Show("Successfully Deleted");
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DELL\SQLEXPRESS;Initial Catalog=empcrud1;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from Emptab1 where ID=@ID", con);
            cmd.Parameters.AddWithValue("ID", int.Parse(textBox1.Text));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
