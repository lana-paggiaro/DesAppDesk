
namespace TabContrlMaskedTextBox
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Datas = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lb2 = new System.Windows.Forms.ListBox();
            this.lb1 = new System.Windows.Forms.ListBox();
            this.mtxData = new System.Windows.Forms.MaskedTextBox();
            this.txtEvento = new System.Windows.Forms.TextBox();
            this.lblData = new System.Windows.Forms.Label();
            this.lblEvento = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.gpResultado = new System.Windows.Forms.GroupBox();
            this.txtCandidato3 = new System.Windows.Forms.TextBox();
            this.txtCandidato2 = new System.Windows.Forms.TextBox();
            this.txtCandidato1 = new System.Windows.Forms.TextBox();
            this.lblCand3 = new System.Windows.Forms.Label();
            this.lblCand2 = new System.Windows.Forms.Label();
            this.lblCand1 = new System.Windows.Forms.Label();
            this.gpCandidatos = new System.Windows.Forms.GroupBox();
            this.btnVotar = new System.Windows.Forms.Button();
            this.lbCandidatos = new System.Windows.Forms.ListBox();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.Datas.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.gpResultado.SuspendLayout();
            this.gpCandidatos.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Datas
            // 
            this.Datas.Controls.Add(this.tabPage1);
            this.Datas.Controls.Add(this.tabPage2);
            this.Datas.Location = new System.Drawing.Point(2, -1);
            this.Datas.Multiline = true;
            this.Datas.Name = "Datas";
            this.Datas.SelectedIndex = 0;
            this.Datas.Size = new System.Drawing.Size(386, 430);
            this.Datas.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lb2);
            this.tabPage1.Controls.Add(this.lb1);
            this.tabPage1.Controls.Add(this.mtxData);
            this.tabPage1.Controls.Add(this.txtEvento);
            this.tabPage1.Controls.Add(this.lblData);
            this.tabPage1.Controls.Add(this.lblEvento);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(378, 404);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Datas";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lb2
            // 
            this.lb2.FormattingEnabled = true;
            this.lb2.Location = new System.Drawing.Point(211, 120);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(146, 251);
            this.lb2.TabIndex = 5;
            // 
            // lb1
            // 
            this.lb1.FormattingEnabled = true;
            this.lb1.Location = new System.Drawing.Point(20, 120);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(185, 251);
            this.lb1.TabIndex = 4;
            this.lb1.Click += new System.EventHandler(this.lb1_Click);
            // 
            // mtxData
            // 
            this.mtxData.Location = new System.Drawing.Point(75, 57);
            this.mtxData.Mask = "00/00/0000";
            this.mtxData.Name = "mtxData";
            this.mtxData.Size = new System.Drawing.Size(282, 20);
            this.mtxData.TabIndex = 3;
            this.mtxData.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtxData_MaskInputRejected);
            this.mtxData.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxData_KeyPress);
            // 
            // txtEvento
            // 
            this.txtEvento.Location = new System.Drawing.Point(97, 16);
            this.txtEvento.Name = "txtEvento";
            this.txtEvento.Size = new System.Drawing.Size(260, 20);
            this.txtEvento.TabIndex = 2;
            this.txtEvento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEvento_KeyPress);
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(17, 57);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(54, 22);
            this.lblData.TabIndex = 1;
            this.lblData.Text = "Data:";
            // 
            // lblEvento
            // 
            this.lblEvento.AutoSize = true;
            this.lblEvento.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEvento.Location = new System.Drawing.Point(17, 16);
            this.lblEvento.Name = "lblEvento";
            this.lblEvento.Size = new System.Drawing.Size(74, 22);
            this.lblEvento.TabIndex = 0;
            this.lblEvento.Text = "Evento:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnLimpar);
            this.tabPage2.Controls.Add(this.gpResultado);
            this.tabPage2.Controls.Add(this.gpCandidatos);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(378, 404);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Votação";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(17, 372);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(343, 26);
            this.btnLimpar.TabIndex = 2;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // gpResultado
            // 
            this.gpResultado.Controls.Add(this.txtCandidato3);
            this.gpResultado.Controls.Add(this.txtCandidato2);
            this.gpResultado.Controls.Add(this.txtCandidato1);
            this.gpResultado.Controls.Add(this.lblCand3);
            this.gpResultado.Controls.Add(this.lblCand2);
            this.gpResultado.Controls.Add(this.lblCand1);
            this.gpResultado.Location = new System.Drawing.Point(17, 165);
            this.gpResultado.Name = "gpResultado";
            this.gpResultado.Size = new System.Drawing.Size(343, 201);
            this.gpResultado.TabIndex = 1;
            this.gpResultado.TabStop = false;
            this.gpResultado.Text = "Resultado";
            // 
            // txtCandidato3
            // 
            this.txtCandidato3.Location = new System.Drawing.Point(125, 157);
            this.txtCandidato3.Name = "txtCandidato3";
            this.txtCandidato3.Size = new System.Drawing.Size(202, 20);
            this.txtCandidato3.TabIndex = 5;
            this.txtCandidato3.Text = "0";
            this.txtCandidato3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtCandidato2
            // 
            this.txtCandidato2.Location = new System.Drawing.Point(125, 93);
            this.txtCandidato2.Name = "txtCandidato2";
            this.txtCandidato2.Size = new System.Drawing.Size(202, 20);
            this.txtCandidato2.TabIndex = 4;
            this.txtCandidato2.Text = "0";
            // 
            // txtCandidato1
            // 
            this.txtCandidato1.Location = new System.Drawing.Point(125, 33);
            this.txtCandidato1.Name = "txtCandidato1";
            this.txtCandidato1.Size = new System.Drawing.Size(202, 20);
            this.txtCandidato1.TabIndex = 3;
            this.txtCandidato1.Text = "0";
            // 
            // lblCand3
            // 
            this.lblCand3.AutoSize = true;
            this.lblCand3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCand3.Location = new System.Drawing.Point(12, 157);
            this.lblCand3.Name = "lblCand3";
            this.lblCand3.Size = new System.Drawing.Size(107, 18);
            this.lblCand3.TabIndex = 2;
            this.lblCand3.Text = "Candidato 03:";
            // 
            // lblCand2
            // 
            this.lblCand2.AutoSize = true;
            this.lblCand2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCand2.Location = new System.Drawing.Point(12, 95);
            this.lblCand2.Name = "lblCand2";
            this.lblCand2.Size = new System.Drawing.Size(107, 18);
            this.lblCand2.TabIndex = 1;
            this.lblCand2.Text = "Candidato 02:";
            // 
            // lblCand1
            // 
            this.lblCand1.AutoSize = true;
            this.lblCand1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCand1.Location = new System.Drawing.Point(12, 35);
            this.lblCand1.Name = "lblCand1";
            this.lblCand1.Size = new System.Drawing.Size(107, 18);
            this.lblCand1.TabIndex = 0;
            this.lblCand1.Text = "Candidato 01:";
            // 
            // gpCandidatos
            // 
            this.gpCandidatos.Controls.Add(this.btnVotar);
            this.gpCandidatos.Controls.Add(this.lbCandidatos);
            this.gpCandidatos.Location = new System.Drawing.Point(17, 17);
            this.gpCandidatos.Name = "gpCandidatos";
            this.gpCandidatos.Size = new System.Drawing.Size(344, 142);
            this.gpCandidatos.TabIndex = 0;
            this.gpCandidatos.TabStop = false;
            this.gpCandidatos.Text = "Candidatos";
            // 
            // btnVotar
            // 
            this.btnVotar.Location = new System.Drawing.Point(13, 100);
            this.btnVotar.Name = "btnVotar";
            this.btnVotar.Size = new System.Drawing.Size(316, 26);
            this.btnVotar.TabIndex = 1;
            this.btnVotar.Text = "Votar";
            this.btnVotar.UseVisualStyleBackColor = true;
            this.btnVotar.Click += new System.EventHandler(this.btnVotar_Click);
            // 
            // lbCandidatos
            // 
            this.lbCandidatos.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCandidatos.FormattingEnabled = true;
            this.lbCandidatos.ItemHeight = 22;
            this.lbCandidatos.Items.AddRange(new object[] {
            "Tânia",
            "Simone",
            "Priscila"});
            this.lbCandidatos.Location = new System.Drawing.Point(12, 24);
            this.lbCandidatos.Name = "lbCandidatos";
            this.lbCandidatos.Size = new System.Drawing.Size(317, 70);
            this.lbCandidatos.TabIndex = 0;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Location = new System.Drawing.Point(0, 12);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(8, 8);
            this.tabControl2.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(0, 0);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(0, 0);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 431);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.Datas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Datas.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.gpResultado.ResumeLayout(false);
            this.gpResultado.PerformLayout();
            this.gpCandidatos.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Datas;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ListBox lb2;
        private System.Windows.Forms.ListBox lb1;
        private System.Windows.Forms.MaskedTextBox mtxData;
        private System.Windows.Forms.TextBox txtEvento;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblEvento;
        private System.Windows.Forms.GroupBox gpResultado;
        private System.Windows.Forms.TextBox txtCandidato3;
        private System.Windows.Forms.TextBox txtCandidato2;
        private System.Windows.Forms.TextBox txtCandidato1;
        private System.Windows.Forms.Label lblCand3;
        private System.Windows.Forms.Label lblCand2;
        private System.Windows.Forms.Label lblCand1;
        private System.Windows.Forms.GroupBox gpCandidatos;
        private System.Windows.Forms.Button btnVotar;
        private System.Windows.Forms.ListBox lbCandidatos;
        private System.Windows.Forms.Button btnLimpar;
    }
}

