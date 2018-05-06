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
    public partial class Search_From_Library : Form
    {
        public Search_From_Library()
        {
            InitializeComponent();
        }

        private void Search_From_Library_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BindingSource source = new BindingSource();
            Myservice.Service1 server = new Myservice.Service1();
            server.SearchBookFromLib(textBox1.Text);
            source.DataSource = server.SearchBookFromLib(textBox1.Text);
            dataGridView1.DataSource = source;
            dataGridView1.Columns[2].Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Welcome w = new Welcome();
            this.Hide();
            w.Show();
        }
    }
}
