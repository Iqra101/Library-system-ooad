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
    public partial class See_Requests : Form
    {
        public See_Requests()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Update_Library_Data u = new Update_Library_Data();
            this.Hide();
            u.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            BindingSource source = new BindingSource();
            Myservice.Service1 server = new Myservice.Service1();
            server.ShowAllReq();
            source.DataSource = server.ShowAllReq();
            dataGridView1.DataSource = source;
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("Book has been issued");
        }
    }
}
