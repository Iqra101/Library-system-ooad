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
    public partial class Forget_Password : Form
    {
        public Forget_Password()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Userlogin frm = new Userlogin();
            this.Hide();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool isvalid;
            bool isvalidpassed;
            Myservice.Service1 myserver = new Myservice.Service1();
            myserver.forgetpassword(textBox1.Text, comboBox1.Text, textBox2.Text, out isvalid, out isvalidpassed);
            if (isvalid == false)
            {
                MessageBox.Show("invalid answer");
                textBox1.Text = "";
                textBox2.Text = "";
                comboBox1.Text = "";
               
            }
            else
            {
                Reset_Password frm = new Reset_Password();
                this.Hide();
                frm.Show();
            }
       }
    }
}
