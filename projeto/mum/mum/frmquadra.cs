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
    public partial class frmquadra : Form
    {
        public frmquadra()
        {
            InitializeComponent();
        }

        private void cadastroQBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cadastroQBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cadastroDataSet);

        }

        private void frmquadra_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'cadastroDataSet.CadastroQ'. Você pode movê-la ou removê-la conforme necessário.
            this.cadastroQTableAdapter.Fill(this.cadastroDataSet.CadastroQ);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.cadastroQBindingSource.AddNew();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cadastroQBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cadastroDataSet);
            MessageBox.Show("cadrastro realizado com sucesso!" , "Cadastro quadra" , MessageBoxButtons.OK , MessageBoxIcon.Information);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja exluir esse item?" , "Confirmação" , MessageBoxButtons.YesNo , MessageBoxIcon.Question) == DialogResult.Yes)
            this.cadastroQBindingSource.RemoveCurrent();
            this.tableAdapterManager.UpdateAll(this.cadastroDataSet);
            MessageBox.Show("cadastro excluido com sucesso!", "Cadastro quadra" , MessageBoxButtons.OK , MessageBoxIcon.Information);
        }

        private void btcancelar_Click(object sender, EventArgs e)
        {
            this.cadastroQBindingSource.CancelEdit();
            this.tableAdapterManager.UpdateAll(this.cadastroDataSet);
            MessageBox.Show("Cadastro cancelado com sucesso!", "Cadastro quadra" , MessageBoxButtons.OK , MessageBoxIcon.Information);
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
