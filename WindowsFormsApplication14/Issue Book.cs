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
    public partial class Issue_Book : Form
    {
        public Issue_Book()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           Update_Library_Data dl = new Update_Library_Data();
            this.Hide();
            dl.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool iTrue;
            bool iIssue;
            Myservice.Service1 server = new Myservice.Service1();
            server.IssueBook(textBox1.Text, textBox2.Text, textBox3.Text, out iTrue, out iIssue);
            if (iTrue == true)
            {
                MessageBox.Show("Book Has Been Issued");
            }
            else
            {
                MessageBox.Show("No book with this name");
            }
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void Issue_Book_Load(object sender, EventArgs e)
        {

        }
    }
}
