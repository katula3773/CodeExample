﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShowHideForm
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnCallForm_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form3 frm = new Form3();
            frm.ShowDialog();

            this.Show();
        }
    }
}
