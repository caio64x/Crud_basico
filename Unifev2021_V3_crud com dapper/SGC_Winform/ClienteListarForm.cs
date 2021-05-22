using SGC_Winform.Business;
using SGC_Winform.Business.Mapeamento;
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
    public partial class ClienteListarForm : Form
    {
        int id_lista;

        public ClienteListarForm()
        {
            InitializeComponent();
        }

        private void fecharButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void excluirButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente excluir o registro?", "Confirme",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                return;
            }

            //segue a exclusão
            //seleciona o registro do grid
            Cliente obj = new Cliente();
            try {

                obj.ID = Convert.ToInt32(listaDataGridView.SelectedRows[0].Cells["idColumn"].Value); 
            }
            catch
            {
                MessageBox.Show("Selecione um registro válido no grid.");
                return;
            }

            //executa a exclusão

            try
            {
                var excluiu = new ClienteBusiness().Excluir(obj);
                if (excluiu)
                    buscarButton.PerformClick();
            }
            catch
            {
                MessageBox.Show("Erro ao excluir o registro!");
            }
        }

        private void buscarButton_Click(object sender, EventArgs e)
        {
            ClienteBusiness clienteBusiness = new ClienteBusiness();
            var dados = clienteBusiness.Listar(filtroTextBox.Text.Trim());
            if (dados.Count == 0)
            {
                quantidadeLabel.Text = "Nenhum registro foi encontrado!";
            }
            else if (dados.Count == 1)
            {
                quantidadeLabel.Text = "1 registro foi encontrado!";
            }
            else if (dados.Count > 1)
            {
                quantidadeLabel.Text = dados.Count.ToString()
                                       + " registros foram encontrados!";
            }

                listaDataGridView.DataSource = dados;
        }

        public void listaDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id_lista = Convert.ToInt32(listaDataGridView.CurrentRow.Cells["idColumn"].Value.ToString());

        }

        private void incluirButton_Click(object sender, EventArgs e)
        {
            new ClienteInserirAlterarForm().ShowDialog();
            buscarButton.PerformClick();
        }

        private void alterarButton_Click(object sender, EventArgs e)
        {
            //segue a exclusão
            //seleciona o registro do grid
            Cliente obj = new Cliente();
            try { obj.ID = Convert.ToInt32(listaDataGridView.SelectedRows[0].Cells["idColumn"].Value); }
            catch
            {
                MessageBox.Show("Selecione um registro válido no grid.");
                return;
            }

            new ClienteInserirAlterarForm(obj).ShowDialog();

            buscarButton.PerformClick();
        }

        private void ClienteListarForm_Load(object sender, EventArgs e)
        {
            buscarButton.PerformClick();
        }
    }
}
