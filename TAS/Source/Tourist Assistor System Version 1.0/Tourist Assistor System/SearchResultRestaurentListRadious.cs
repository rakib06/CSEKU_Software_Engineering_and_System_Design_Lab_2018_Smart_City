﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tourist_Assistor_System
{
    public partial class SearchResultRestaurentListRadious : Form
    {
        public SearchResultRestaurentListRadious()
        {
            InitializeComponent();
        }

        private void click_btn_back(object sender, EventArgs e)
        {
            this.Hide();
            Tourist t = new Tourist();
            t.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DetailsRestaurent df = new DetailsRestaurent();
            df.ShowDialog();
        }
    }
}
