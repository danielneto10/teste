﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Escrever()
        {
            MessageBox.Show("Usando o GitHub com o VS 2017 no dia 04/03");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Escrever();
        }
    }
}
