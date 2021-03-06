﻿using System;
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
    public partial class Search_From_Market : Form
    {
        public Search_From_Market()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BindingSource source = new BindingSource();
            Myservice.Service1 server = new Myservice.Service1();
            server.SearchBookFromMar(textBox1.Text);
            source.DataSource = server.SearchBookFromMar(textBox1.Text);
            dataGridView1.DataSource = source;
            dataGridView1.Columns[3].Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Welcome w = new Welcome();
            this.Hide();
            w.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Rider r = new Rider();
            this.Hide();
            r.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            adminLogin a = new adminLogin();
            this.Hide();
            a.Show();
        }
    }
}
