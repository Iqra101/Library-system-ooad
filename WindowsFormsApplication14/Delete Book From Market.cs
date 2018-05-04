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
    public partial class Delete_Book_From_Market : Form
    {
        public Delete_Book_From_Market()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Update_Market_Data ud = new Update_Market_Data();
            this.Hide();
            ud.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool isf = false;
            bool isd;
            Myservice.Service1 server = new Myservice.Service1();
            server.DeleteBookFromMar(textBox1.Text, textBox2.Text, out isf, out isd);
            if(isf==true)
            {
                MessageBox.Show("Book Deleted");
            }
            else
            {
                MessageBox.Show("No Book Found with this name");
            }
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}
