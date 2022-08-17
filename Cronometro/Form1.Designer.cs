
namespace Cronometro
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnLigar = new System.Windows.Forms.Button();
            this.btnDesligar = new System.Windows.Forms.Button();
            this.btnZerar = new System.Windows.Forms.Button();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnLigar
            // 
            this.btnLigar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLigar.BackgroundImage")));
            this.btnLigar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLigar.Location = new System.Drawing.Point(80, 199);
            this.btnLigar.Name = "btnLigar";
            this.btnLigar.Size = new System.Drawing.Size(102, 95);
            this.btnLigar.TabIndex = 1;
            this.btnLigar.Text = "L";
            this.btnLigar.UseVisualStyleBackColor = true;
            this.btnLigar.Click += new System.EventHandler(this.btnLigar_Click);
            // 
            // btnDesligar
            // 
            this.btnDesligar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDesligar.BackgroundImage")));
            this.btnDesligar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDesligar.Location = new System.Drawing.Point(210, 199);
            this.btnDesligar.Name = "btnDesligar";
            this.btnDesligar.Size = new System.Drawing.Size(102, 95);
            this.btnDesligar.TabIndex = 2;
            this.btnDesligar.Text = "D";
            this.btnDesligar.UseVisualStyleBackColor = true;
            this.btnDesligar.Click += new System.EventHandler(this.btnDesligar_Click);
            // 
            // btnZerar
            // 
            this.btnZerar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnZerar.BackgroundImage")));
            this.btnZerar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnZerar.Location = new System.Drawing.Point(340, 199);
            this.btnZerar.Name = "btnZerar";
            this.btnZerar.Size = new System.Drawing.Size(99, 95);
            this.btnZerar.TabIndex = 3;
            this.btnZerar.UseVisualStyleBackColor = true;
            this.btnZerar.Click += new System.EventHandler(this.btnZerar_Click);
            // 
            // txtNum
            // 
            this.txtNum.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtNum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNum.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtNum.Location = new System.Drawing.Point(99, 46);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(360, 74);
            this.txtNum.TabIndex = 4;
            this.txtNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timer1
            // 
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(577, 324);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.btnZerar);
            this.Controls.Add(this.btnDesligar);
            this.Controls.Add(this.btnLigar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLigar;
        private System.Windows.Forms.Button btnDesligar;
        private System.Windows.Forms.Button btnZerar;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Timer timer1;
    }
}

