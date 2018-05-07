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
    public partial class Delete_Books_From_Library : Form
    {
        public Delete_Books_From_Library()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool isF = false;
            bool isDeleted;
            Myservice.Service1 server = new Myservice.Service1();
            server.DeleteBookFromLib(textBox1.Text, textBox2.Text, out isF, out isDeleted);
            if (isF == true)
            {
                MessageBox.Show("Done");
            }
            else
            {
                MessageBox.Show("No book with this name");
            }
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Update_Library_Data ud = new Update_Library_Data();
            this.Hide();
            ud.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 a = new Form1();
            this.Hide();
            a.Show();
        }
    }
}
