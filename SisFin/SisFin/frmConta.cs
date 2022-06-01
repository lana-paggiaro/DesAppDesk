using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SisFin
{
    public partial class frmConta : Form
    {
        private int id;
        private string nome;
        private string descricao;
        private int categoria;
        private int status;
        private List<Conta> _lstConta = new List<Conta>();
        private frmConta conta = new frmConta();
        private Conta conta1 = new Conta();
        private List<Conta> lstConta = new List<Conta>();
        private List<Categoria> lstCategoria = new List<Categoria>();
        private BindingSource bsConta;
        private BindingSource bsCategoria;

        public frmConta()
        {
            InitializeComponent();
            lstConta = new Conta().GeraContas();
            lstCategoria = new Categoria().GeraCategorias();
        }

        private void frmConta_Load(object sender, EventArgs e)
        {
            dgConta.ColumnCount = 5;
            dgConta.AutoGenerateColumns = false;
            dgConta.Columns[0].Width = 50;
            dgConta.Columns[0].HeaderText = "ID";
            dgConta.Columns[0].DataPropertyName = "Id";
            dgConta.Columns[0].Visible = false;
            dgConta.Columns[1].Width = 200;
            dgConta.Columns[1].HeaderText = "NOME";
            dgConta.Columns[1].DataPropertyName = "Nome";
            dgConta.Columns[2].Width = 400;
            dgConta.Columns[2].HeaderText = "DESCRIÇÃO";
            dgConta.Columns[2].DataPropertyName = "Descricao";
            dgConta.Columns[3].Width = 50;
            dgConta.Columns[3].HeaderText = "CATEGORIA";
            dgConta.Columns[3].DataPropertyName = "Categoria";
            dgConta.Columns[4].Width = 50;
            dgConta.Columns[4].HeaderText = "STATUS";
            dgConta.Columns[4].DataPropertyName = "Status";

            dgConta.AllowUserToAddRows = false;
            dgConta.AllowUserToDeleteRows = false;
            dgConta.MultiSelect = false;
            dgConta.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            
            carregaGridConta();
        }

        private void carregaGridConta()
        {
            bsConta = new BindingSource();
            bsConta.DataSource = lstConta;
            //dg.Conta.Rows.Clear();
            dgConta.DataSource = bsConta;
            dgConta.Refresh();
        }

        private void carregaComboCategoria(int id = 0)
        {
            bsCategoria = new BindingSource();
            bsCategoria.DataSource = lstCategoria;
            cbCat.DataSource = bsCategoria;
            cbCat.DisplayMember = "Nome";
            cbCat.SelectedItem = "id";
            if (id > 0)
            {
                foreach(var c in lstCategoria)
                {
                    if(c.Id == id)
                    {
                        int index = cbCat.FindString(c.Nome);
                        cbCat.SelectedIndex = index;
                    }
                }
            }
            cbCat.Refresh();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
