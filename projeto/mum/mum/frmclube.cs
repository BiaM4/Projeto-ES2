using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mum
{
    public partial class frmclube : Form
    {
        public frmclube()
        {
            InitializeComponent();
        }

        private void frmclube_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (controle.formquadra == null)
                controle.formquadra = new frmquadra();

            controle.formquadra.Show();
            controle.formquadra.Focus();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
