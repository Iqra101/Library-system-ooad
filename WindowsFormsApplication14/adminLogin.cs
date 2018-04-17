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
    public partial class adminLogin : Form
    {
        public adminLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool isvalidadmin;
            bool isvalidadminpassed;
            Myservice.Service1 myserver = new Myservice.Service1();
            myserver.isvalidAdmin(textBox1.Text, textBox2.Text, out isvalidadmin, out isvalidadminpassed);
            if(isvalidadmin == true)
            {
                MessageBox.Show("valid Admin");
            }
            else
            {
                MessageBox.Show("Not valid");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            this.Hide();
            frm.Show();
        }
    }
}
