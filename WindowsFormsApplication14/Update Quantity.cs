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
    public partial class Update_Quantity : Form
    {
        public Update_Quantity()
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
            bool isQ = false;
            bool isT;
            Myservice.Service1 server = new Myservice.Service1();
            server.UpdateQuantity(textBox1.Text, textBox2.Text,textBox3.Text, out isQ, out isT);
            if (isQ == true)
            {
                MessageBox.Show("Quantity Updated");
            }
            else
            {
                MessageBox.Show("No book with this name");
            }
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 a = new Form1();
            this.Hide();
            a.Show();
        }
    }
}
