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
    public partial class Update_Library_Data : Form
    {
        public Update_Library_Data()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add_Books_To_Library ad = new Add_Books_To_Library();
            this.Hide();
            ad.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Issue_Book i = new Issue_Book();
            this.Hide();
            i.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Update_Quantity uq = new Update_Quantity();
            this.Hide();
            uq.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Delete_Books_From_Library d = new Delete_Books_From_Library();
            this.Hide();
            d.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Admin a = new Admin();
            this.Hide();
            a.Show();
        }
    }
}
