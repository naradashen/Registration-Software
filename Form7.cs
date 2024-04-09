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

namespace WindowsFormsApplication1
{
    public partial class Form7 : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Narada\Documents\Visual Studio 2013\Projects\WindowsFormsApplication1\WindowsFormsApplication1\Database1.mdf;Integrated Security=True");
        SqlCommand com;
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "insert into Payment values('" + textBox1.Text+ "','" + dateTimePicker1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')";

                com = new SqlCommand(query, con);
                com.ExecuteNonQuery();
                MessageBox.Show("payment successful");
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                

              
                
            }
            finally
            {
                con.Close();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                 con.Open();
                string query = "select * from Payment where id ='" + textBox1.Text + "'";
                com=new SqlCommand (query,con);
                SqlDataReader dr =com.ExecuteReader();
    
                while (dr.Read())
                {
                    textBox1.Text = dr[0].ToString();
                    dateTimePicker1.Text = dr[1].ToString();
                        
                    textBox2.Text = dr[2].ToString();
                    textBox3.Text = dr[3].ToString();
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            } con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                String query = "update Payment set payment= '" + textBox2.Text + "', due_balance= '" + textBox3.Text + "' where id = '" + textBox1.Text + "'";
                com = new SqlCommand(query, con);
                com.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("update ok");

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);


            }
            finally 
            { con.Close(); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 F3 = new Form3();
            this.Hide();
            F3.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form11 F11 = new Form11();
            this.Hide();
            F11.Show();
        }
    }
}