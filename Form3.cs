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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form4 F4 = new Form4();
            this.Hide();
            F4.Show();





        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 F5 = new Form5();
            this.Hide();
            F5.Show();



        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Form8 F8 = new Form8();
            this.Hide();
            F8.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form7 F7 = new Form7();
            this.Hide();
            F7.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
