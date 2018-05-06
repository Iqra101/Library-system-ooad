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
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Search_From_Library s = new Search_From_Library();
            this.Hide();
            s.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Userlogin u = new Userlogin();
            this.Hide();
            u.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Search_From_Market s = new Search_From_Market();
            this.Hide();
            s.Show();
        }
    }
}
