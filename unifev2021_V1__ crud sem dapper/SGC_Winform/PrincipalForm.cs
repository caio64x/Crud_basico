using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGC_Winform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Sobre_Click(object sender, EventArgs e)
        {
            SobreForm aboutBox1 = new SobreForm();
            aboutBox1.ShowDialog();
        }

        private void Sair2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Sobre2_Click(object sender, EventArgs e)
        {
            SobreForm aboutBox1 = new SobreForm();
            aboutBox1.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = "Carregando..";
            
            timer1.Start();
            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DataStatus.Text = DateTime.Now.ToString("dddd, dd/MM/yyyy HH:mm:ss");
        }

        private void configToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            ConfiguracaoForm configuracaoForm = new ConfiguracaoForm();
            configuracaoForm.MdiParent = this;
            configuracaoForm.Show();
        }

        private void cascataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void iconesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void ladoALadoHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ladoALadoVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClienteListarForm clienteListarForm = new ClienteListarForm();
            clienteListarForm.MdiParent = this;
            clienteListarForm.Show();
           
        }
    }
}
