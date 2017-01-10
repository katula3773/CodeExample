using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCallForm_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form2 frm = new Form2();
            frm.ShowDialog();

            this.Show();
        }
    }
}
