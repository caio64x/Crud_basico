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
    public partial class ClienteInserirAlterarForm : Form
    {
        public ClienteBusiness clienteBusiness = new ClienteBusiness();
        public ClienteInserirAlterarForm()
        {
            InitializeComponent();
            this.Text = "Novo cliente";
            idTextBox.Text = "Automático";

            ListarCidades();
        }
        public ClienteInserirAlterarForm(int id)
        {
            InitializeComponent();
            ListarCidades();

            var cliente = clienteBusiness.Carregar(Convert.ToInt32(id));
            cidadeComboBox.SelectedValue = cliente.Rows[0]["IDCidade"].ToString();
            nomeTextBox.Text = cliente.Rows[0]["Nome"].ToString();
            enderecoTextBox.Text = cliente.Rows[0]["Endereco"].ToString();
            bairroTextBox.Text = cliente.Rows[0]["Bairro"].ToString();
            datanascimentoDateTimePicker.Value = Convert.ToDateTime(cliente.Rows[0]["DataNascimento"].ToString());


            this.Text = "Alterar cliente";
            idTextBox.Text = id.ToString();

        }

        void ListarCidades()
        {
            var list = new CidadeBusiness().Listar();
            cidadeComboBox.ValueMember = "ID";
            cidadeComboBox.DisplayMember = "Nome";
            cidadeComboBox.DataSource = list;
        }


        private void fecharButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ClienteInserirAlterarForm_Load(object sender, EventArgs e)
        {

        }

        private void salvarButton_Click(object sender, EventArgs e)
        {
            try
            {
                int id = 0;
                Cliente obj = new Cliente();
                if (this.Text == "Novo cliente")
                {
                    //inserir


                    obj.IDCidade = Convert.ToInt32(cidadeComboBox.SelectedValue);
                    obj.Nome = nomeTextBox.Text.Trim();
                    obj.Endereco = enderecoTextBox.Text.Trim();
                    obj.Bairro = bairroTextBox.Text.Trim();
                    obj.DataNascimento = datanascimentoDateTimePicker.Value;

                    id = clienteBusiness.Inserir(obj);

                    //   clienteBusiness.Inserir(obj);


                    if (id > 0)
                    {
                        MessageBox.Show("Cliente cadastrado com sucesso!\nCódigo: " + id);
                        Close();
                    }
                }
                else
                {

                    //Alterar


                    obj.ID = Convert.ToInt32(idTextBox.Text);
                    obj.IDCidade = Convert.ToInt32(cidadeComboBox.SelectedValue);
                    obj.Nome = nomeTextBox.Text.Trim();
                    obj.Endereco = enderecoTextBox.Text.Trim();
                    obj.Bairro = bairroTextBox.Text.Trim();
                    obj.DataNascimento = datanascimentoDateTimePicker.Value;

                    Boolean resposta = clienteBusiness.Alterar(obj);


                    if (resposta)
                    {
                        MessageBox.Show("Cliente alterado com sucesso!");
                        Close();
                    }
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("aconteceu o erro " + erro);
                throw;
            }
        }
    }
}
