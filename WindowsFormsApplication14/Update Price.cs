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
    public partial class Update_Price : Form
    {
        public Update_Price()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           Update_Market_Data u = new Update_Market_Data();
            this.Hide();
            u.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool isQ = false;
            bool isT;
            Myservice.Service1 server = new Myservice.Service1();
            server.UpdatePrice(textBox1.Text, textBox2.Text, textBox3.Text, out isQ, out isT);
            if (isQ == true)
            {
                MessageBox.Show("Price Updated");
            }
            else
            {
                MessageBox.Show("No book with this name");
            }
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }
    }
}
