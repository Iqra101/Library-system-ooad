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
    public partial class Update_Market_Data : Form
    {
        public Update_Market_Data()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add_Books_To_Market d = new Add_Books_To_Market();
            this.Hide();
            d.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Update_Price u = new Update_Price();
            this.Hide();
            u.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Delete_Book_From_Market db = new Delete_Book_From_Market();
            this.Hide();
            db.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Admin a = new Admin();
            this.Hide();
            a.Show();
        }
    }
}
