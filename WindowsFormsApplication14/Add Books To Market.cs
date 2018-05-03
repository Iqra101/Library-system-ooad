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
    public partial class Add_Books_To_Market : Form
    {
        public Add_Books_To_Market()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Myservice.Service1 server = new Myservice.Service1();
            server.AddBooksToMar(textBox1.Text, textBox2.Text, textBox3.Text);
            MessageBox.Show("Book has been Added");
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Update_Market_Data um = new Update_Market_Data();
            this.Hide();
            um.Show();
        }
    }
}
