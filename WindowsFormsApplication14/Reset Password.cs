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
    public partial class Reset_Password : Form
    {
        public Reset_Password()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Myservice.Service1 myserver = new Myservice.Service1();
            myserver.resetpassword(textBox1.Text, textBox2.Text);
            MessageBox.Show("Your password has been reset");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Forget_Password frm = new Forget_Password();
            this.Hide();
            frm.Show();
        }
    }
}
