using SGC_Winform.Suporte;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGC_Winform.Business
{
    public class ClienteBusiness : Conexao
    {
        public DataTable Listar(string filtro)
        {
            string sql = @"SELECT c.*, (cd.Nome + ' - ' + cd.UF) as CidadeNome
                           FROM CLIENTES c 
                           INNER JOIN Cidades cd ON cd.ID = c.IDCidade
                           WHERE c.Nome like '%" + filtro + "%'";

            SqlCommand cmd = new SqlCommand(sql, banco);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dados = new DataTable();
            adp.Fill(dados);

            return dados;
        }


        public DataTable Carregar(int id)
        {
            string sql = @"SELECT * 
                           FROM CLIENTES
                           WHERE ID = @pId";
            SqlCommand cmd = new SqlCommand(sql, banco);
            cmd.Parameters.Add(new SqlParameter("@pId", id));
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dados = new DataTable();
            adp.Fill(dados);

            return dados;
        }

        public bool Excluir(int id)
        {
          
            SqlCommand cmd = new SqlCommand(@"DELETE
                           FROM CLIENTES
                           WHERE ID = @pId", banco);
            //   cmd.Parameters.AddWithValue("@pId", id);
            cmd.Parameters.Add(new SqlParameter("@pId", id));


            int qtde;
            //verifica se a conexao esta ok
            if (banco.State == ConnectionState.Closed)
            
                banco.Open();
                 qtde = cmd.ExecuteNonQuery();

            
            if (banco.State == ConnectionState.Open)
            
                banco.Close();
             
            return qtde == 1;

        }

       public int Inserir(int idCidade, string nome, string endereco, string bairro, 
            DateTime dataNascimento)
        {
            SqlCommand cmd = new SqlCommand(@"INSERT INTO CLIENTES 
                                            (IDCidade, Nome, Endereco, Bairro, DataNascimento) 
                                            VALUES 
                                            (@pIDCidade, @pNome, @pEndereco, @pBairro, 
                                             @pDataNascimento) select @@IDENTITY  ", banco);
          
            cmd.Parameters.Add(new SqlParameter("pIDCidade", idCidade));
            cmd.Parameters.Add(new SqlParameter("pNome", nome));
            cmd.Parameters.Add(new SqlParameter("pEndereco", endereco));
            cmd.Parameters.Add(new SqlParameter("pBairro", bairro));
            cmd.Parameters.Add(new SqlParameter("pDataNascimento", dataNascimento));

            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dados = new DataTable();
            adp.Fill(dados);

            if (dados.Rows.Count == 1)
                return Convert.ToInt32(dados.Rows[0][0].ToString());

            return 0;
        }


        public bool Alterar(int id, int idCidade, string nome, string endereco, string bairro, DateTime dataNascimento)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(@"UPDATE
                                            CLIENTES SET 
                                           IDCidade = @pIDCidade,Nome = @pNome,Endereco = @pEndereco, Bairro = @pBairro,DataNascimento = @pDataNascimento
                                            WHERE ID = @pID", banco);

                cmd.Parameters.Add(new SqlParameter("pID", id));
                cmd.Parameters.Add(new SqlParameter("pIDCidade", idCidade));
                cmd.Parameters.Add(new SqlParameter("pNome", nome));
                cmd.Parameters.Add(new SqlParameter("pEndereco", endereco));
                cmd.Parameters.Add(new SqlParameter("pBairro", bairro));
                cmd.Parameters.Add(new SqlParameter("pDataNascimento", dataNascimento));
                int qtde;
                //verifica se a conexao esta ok
                if (banco.State == ConnectionState.Closed)

                    banco.Open();
                qtde = cmd.ExecuteNonQuery();


                if (banco.State == ConnectionState.Open)

                    banco.Close();

                return qtde == 1;
            }
            catch (Exception erro)
            {
                MessageBox.Show("aconteceu o erro " + erro);
                throw;
            }
            

        }

    }

}
