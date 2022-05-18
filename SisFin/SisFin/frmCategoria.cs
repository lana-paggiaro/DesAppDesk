using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SisFin
{
    public partial class frmCategoria : Form
    {
        private bool Insercao = false;
        private bool Edicao = false;
        
        public frmCategoria()
        {
            InitializeComponent();
        }

        private void limparCampos()
        {
            txtNome.Clear();
            txtDescricao.Clear();
            rdDespesa.Checked = false;
            rdReceita.Checked = false;
            chkStatus.Checked = false;
        }
        
        private void resetCampos()
        {
            limparCampos();
            grpCategoria.Enabled = false;
            btnAlterar.Enabled = true;
            btnNovo.Enabled = true;
            btnCancelar.Visible = false;
            btnSalvar.Visible = false;
            btnExcluir.Visible = false;
            Insercao = false;
            Edicao = false;
        }

        private void fecharForm(object sender, FormClosingEventArgs e)
        {
            if(Edicao || Insercao)
            {
                e.Cancel = true;
                MessageBox.Show("Salve ou cancele antes de fechar!", "Aviso do sistema!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void frmCategoria_Load(object sender, EventArgs e)
        {
            txtNome.Text = "Combustível";
            txtDescricao.Text = "Consumo de combustível";
            rdDespesa.Checked = true;
            chkStatus.Checked = true;
            btnSalvar.Visible = false;
            btnCancelar.Visible = false;
            txtNome.Enabled = false;
            txtDescricao.Enabled = false;
            rdReceita.Enabled = false;
            rdDespesa.Enabled = false;
            chkStatus.Enabled = false;
        }

        private void grpCategoria_Enter(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDescricao_TextChanged(object sender, EventArgs e)
        {

        }

        private void rdReceita_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdDespesa_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkStatus_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            grpCategoria.Enabled = true;
            limparCampos();
            txtNome.Focus();
            btnAlterar.Enabled = false;
            btnCancelar.Visible = true;
            btnSalvar.Visible = true;
            btnExcluir.Visible = false;
            btnNovo.Enabled = false;
            Insercao = true;
            Edicao = false;
            txtNome.Enabled = true;
            txtDescricao.Enabled = true;
            rdReceita.Enabled = true;
            rdDespesa.Enabled = true;
            chkStatus.Enabled = true;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            grpCategoria.Enabled = true;
            limparCampos();
            txtNome.Focus();
            btnAlterar.Enabled = false;
            btnCancelar.Visible = true;
            btnSalvar.Visible = true;
            btnExcluir.Visible = false;
            btnNovo.Enabled = false;
            Insercao = false;
            Edicao = true;
            txtNome.Enabled = true;
            txtDescricao.Enabled = true;
            rdReceita.Enabled = true;
            rdDespesa.Enabled = true;
            chkStatus.Enabled = true;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Deseja mesmo excluir?","Aviso do sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                limparCampos();
                MessageBox.Show("Registro excluído com sucesso", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnNovo.Focus();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Registro gravado com sucesso!", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

            limparCampos();
            btnNovo.Enabled = true;
            btnNovo.Focus();
            grpCategoria.Enabled = false;
            btnAlterar.Enabled = true;
            btnCancelar.Visible = false;
            btnSalvar.Visible = false;
            btnExcluir.Visible = true;
            Insercao = false;
            Edicao = false;
            txtNome.Enabled = false;
            txtDescricao.Enabled = false;
            rdReceita.Enabled = false;
            rdDespesa.Enabled = false;
            chkStatus.Enabled = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnNovo.Focus();
            btnNovo.Enabled = true;
            btnAlterar.Enabled = true;
            btnExcluir.Visible = true;
            btnSalvar.Visible = false;
            btnCancelar.Visible = false;
            txtNome.Enabled = false;
            txtDescricao.Enabled = false;
            rdReceita.Enabled = false;
            rdDespesa.Enabled = false;
            chkStatus.Enabled = false;
            Insercao = false;
            Edicao = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}
