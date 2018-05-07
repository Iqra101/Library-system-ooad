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
    public partial class Send_Request : Form
    {
        public Send_Request()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Search_From_Library sl = new Search_From_Library();
            this.Hide();
            sl.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool isf = false;
            bool isd;
            Myservice.Service1 server = new Myservice.Service1();
            server.SendReq(textBox1.Text, textBox2.Text, out isf, out isd);
            if(isf==true)
            {
                MessageBox.Show("Request Sent");
            }
            else
            {
                MessageBox.Show("Request cannot be send");
            }
            textBox1.Text = "";
            textBox2.Text = "";
            
        }
    }
}
