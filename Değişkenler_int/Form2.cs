﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Değişkenler_int
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int sayi;
            //sayi = Convert.ToInt16(textBox1.Text);
            //label2.Text = sayi.ToString();

            int sayi,küp;
            sayi = Convert.ToInt16(textBox1.Text);
            küp = sayi * sayi * sayi;
            label2.Text = küp.ToString();



        }
    }
}
