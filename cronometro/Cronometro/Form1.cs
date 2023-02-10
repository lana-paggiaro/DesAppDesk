using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cronometro
{
    public partial class Form1 : Form
    {
        DateTime inicio, fim;
        
        public Form1()
        {
            InitializeComponent();
        }
    
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            GraphicsPath redondo = new GraphicsPath();
            redondo.AddEllipse(0, 0, 50, 50);
            btnLigar.Region = new Region(redondo);
            btnDesligar.Region = new Region(redondo);
            btnZerar.Region = new Region(redondo);
        }

        private void ligar()
        {
            inicio = DateTime.Now;
            timer1.Start();
        }

        private void desligar()
        {
            timer1.Stop();
        }

        private void zerar()
        {
            txtNum.Text = "00:00:00";
        }

        private void btnLigar_Click(object sender, EventArgs e)
        {
            ligar();
        }

        private void btnDesligar_Click(object sender, EventArgs e)
        {
            desligar();
        }

        private void btnZerar_Click(object sender, EventArgs e)
        {
            zerar();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            fim = DateTime.Now;
            TimeSpan dif = fim.Subtract(inicio);
            txtNum.Text = dif.ToString("hh\\:mm\\:ss");
        }
    }
}
