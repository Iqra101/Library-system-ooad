using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication14
{
    public partial class Userlogin : Form
    {
        public Userlogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            this.Hide();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool isvaliduser;
            bool isvaliduserpassed;
            Myservice.Service1 myserver = new Myservice.Service1();
            myserver.isvaliduser(textBox1.Text, textBox2.Text, out isvaliduser, out isvaliduserpassed);
            if (isvaliduser == true)
            {
                Welcome w = new Welcome();
                this.Hide();
                w.Show();
            }
            else
            {
                MessageBox.Show("invaliduser");
                textBox1.Text = "";
                textBox2.Text = "";
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Sign_Up frm = new Sign_Up();
            this.Hide();
            frm.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Forget_Password frm = new Forget_Password();
            this.Hide();
            frm.Show();
        }
    }
}
