using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TabContrlMaskedTextBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtEvento.Focus();
        }

        private void txtEvento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13) //ou (Keys)e.KeyChar == Keys.Enter
            {
                if (txtEvento.Text != string.Empty)
                    mtxData.Focus();
                    //txtEvento.Clear(;
            }
        }

        private void mtxData_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                try
                {
                    Convert.ToDateTime(mtxData.Text);
                    lb1.Items.Add(txtEvento.Text);
                    lb2.Items.Add(mtxData.Text);
                    txtEvento.Clear();
                    mtxData.Clear();
                    txtEvento.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Data inválida!");
                    //MessageBox.Show(ex.toString());
                    mtxData.Focus();
                }
                lb1.Items.Add(txtEvento.Text);
                lb2.Items.Add(mtxData.Text);
                //mtxData.Clear();
            }
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void btnVotar_Click(object sender, EventArgs e)
        {
                if (lbCandidatos.SelectedIndex == 0)
                    txtCandidato1.Text = (int.Parse(txtCandidato1.Text) + 1).ToString();
                else if (lbCandidatos.SelectedIndex == 1)
                    txtCandidato2.Text = (int.Parse(txtCandidato2.Text) + 1).ToString();
                else if (lbCandidatos.SelectedIndex == 2)
                    txtCandidato3.Text = (int.Parse(txtCandidato3.Text) + 1).ToString();
                else
                    MessageBox.Show("Selecione um candidato");
                lbCandidatos.ClearSelected();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCandidato1.Text = "0";
            txtCandidato2.Text = "0";
            txtCandidato3.Text = "0";
        }

        private void mtxData_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void lb1_Click(object sender, EventArgs e)
        {
            try
            {
                lb2.Items.RemoveAt(lb1.SelectedIndex);
                lb1.Items.RemoveAt(lb1.SelectedIndex);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Selecione um evento");
            }
        }
    }
}
