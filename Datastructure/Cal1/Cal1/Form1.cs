﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cal1
{
    public partial class Form1 : Form
    {
        public Graphics g;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void Draw()
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        public void label1_Click(object sender, EventArgs e)
        {
            Form2 dlg = new Form2(this); 
            dlg.ShowDialog();
        
        public void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
