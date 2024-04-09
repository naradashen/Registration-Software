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
    public partial class Form8 : Form
    {
        SqlConnection con=new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Narada\documents\visual studio 2013\Projects\WindowsFormsApplication1\WindowsFormsApplication1\Database1.mdf;Integrated Security=True");
        SqlCommand com;

        public Form8()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 F3 = new Form3();
            this.Hide();
            F3.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "insert into salary values('" + textBox1.Text + "','" + dateTimePicker1.Text + "','" + textBox2.Text + "')";
                com=new SqlCommand(query,con);
                com.ExecuteNonQuery();
                MessageBox.Show("salary given");


            }
            catch (Exception ex)
            {
               MessageBox.Show (ex.Message) ;
              

            }  

            finally{con.Close();
            textBox1.Clear();
            textBox2.Clear();

            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "select * from salary where id ='" + textBox1.Text + "'";
                com = new SqlCommand(query, con);
                SqlDataReader dr = com.ExecuteReader();

                while (dr.Read())
                {
                    textBox1.Text = dr[0].ToString();
                    dateTimePicker1.Text = dr[1].ToString();

                    textBox2.Text = dr[2].ToString();

                }




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);


            }
            finally { con.Close();}
          
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form12 F12 = new Form12();
            this.Hide();
            F12.Show();
        }
    }
}
