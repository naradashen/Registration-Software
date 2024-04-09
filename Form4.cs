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
    public partial class Form4 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Narada\Documents\Visual Studio 2013\Projects\WindowsFormsApplication1\WindowsFormsApplication1\Database1.mdf;Integrated Security=True");
        SqlCommand com;

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form3 F3 = new Form3();
            this.Hide();
            F3.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "insert into rebels values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + dateTimePicker1.Text + "')";
                com = new SqlCommand(query, con);
                com.ExecuteNonQuery();



                MessageBox.Show("Record inserted successfully");
                TextBox1.Text = "";
                TextBox2.Clear();
                TextBox3.Clear();
                TextBox4.Clear();



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally { con.Close(); }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "delete from rebels where id ='" + TextBox1.Text + "'";
                com = new SqlCommand(query, con);
                com.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Delete success");

                TextBox1.Clear();
                TextBox2.Clear();
                TextBox3.Clear();
                TextBox4.Clear();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally { con.Close(); }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "update rebels set name='" + TextBox2.Text + "',address='" + TextBox3.Text + "',tel_no='" + TextBox4.Text + "',dob = '" + dateTimePicker1.Text + "'where id = '"+TextBox1.Text+"'";

                com = new SqlCommand(query, con);
                com.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("update ok");

                TextBox1.Clear();
                TextBox2.Clear();
                TextBox3.Clear();
                TextBox4.Clear();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally { con.Close(); }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "select * from rebels where id ='" + TextBox1.Text + "'";
                com=new SqlCommand (query,con);
                SqlDataReader dr =com.ExecuteReader();
    
                while (dr.Read())
                       
            
            {
                TextBox1.Text= dr [0].ToString();
                TextBox2.Text = dr [1].ToString();
                TextBox3.Text = dr [2].ToString();
                TextBox4.Text = dr[3].ToString();
                dateTimePicker1.Text = dr[4].ToString();

                
                
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } con.Close();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form9 F9 = new Form9();
            this.Hide();
            F9.Show();
        }
    }
}

    

                
                
                
                
                
                
                
                
                
                
         


        