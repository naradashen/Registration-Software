using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           string user_name= "rebels";
           string password = "nak3.142857142857142857143";

               if (user_name==textBox1.Text&& password==textBox2.Text){

                   Form3 F3 = new Form3();
                   this.Hide();
                   F3.Show();


               }

                   else{MessageBox.Show("user name or password error");
               }

            




        }

        private void button2_Click(object sender, EventArgs e)
        {
            
                   Form1 F1 = new Form1();
                   this.Hide();
                   F1.Show();
        }
    }
}
