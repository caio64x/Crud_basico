using Dapper;
using SGC_Winform.Business.Mapeamento;
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
        SqlConnection banco;

        public ClienteBusiness()
        {
            this.banco = Conexao.getConnection();
        }


        //public DataTable Listar(string filtro)
        //{
        //    string sql = @"SELECT c.*, (cd.Nome + ' - ' + cd.UF) as CidadeNome
        //                   FROM CLIENTES c 
        //                   INNER JOIN Cidades cd ON cd.ID = c.IDCidade
        //                   WHERE c.Nome like '%" + filtro + "%'";

        //    SqlCommand cmd = new SqlCommand(sql, banco);
        //    SqlDataAdapter adp = new SqlDataAdapter(cmd);
        //    DataTable dados = new DataTable();
        //    adp.Fill(dados);

        //    return dados;

        
        //}

        public List<Cliente> Listar(string filtro)
        {
            return banco.Query<Cliente>("SELECT c.ID, c.Nome, c.Endereco,c.Bairro, c.DataNascimento, cd.Nome as Cidade FROM CLIENTES c JOIN Cidades cd ON cd.ID = c.IDCidade WHERE c.Nome like '%" + filtro + "%'").ToList();


        }

        //public int Inserir(Cliente obj)
        //{
        //    SqlCommand cmd = new SqlCommand(@"INSERT INTO CLIENTES 
        //                                    (IDCidade, Nome, Endereco, Bairro, DataNascimento) 
        //                                    VALUES 
        //                                    (@pIDCidade, @pNome, @pEndereco, @pBairro, 
        //                                     @pDataNascimento) select @@IDENTITY  ", banco);

        //    cmd.Parameters.Add(new SqlParameter("pIDCidade", obj.IDCidade));
        //    cmd.Parameters.Add(new SqlParameter("pNome", obj.Nome));
        //    cmd.Parameters.Add(new SqlParameter("pEndereco", obj.Endereco));
        //    cmd.Parameters.Add(new SqlParameter("pBairro", obj.Bairro));
        //    cmd.Parameters.Add(new SqlParameter("pDataNascimento", obj.DataNascimento));

        //    SqlDataAdapter adp = new SqlDataAdapter(cmd);
        //    DataTable dados = new DataTable();
        //    adp.Fill(dados);

        //    if (dados.Rows.Count == 1)
        //        return Convert.ToInt32(dados.Rows[0][0].ToString());

        //    return 0;

        //}

        public int Inserir(Cliente obj)
        {
            if (banco.State == ConnectionState.Closed)

                banco.Open();
            return  banco.Query<int>(@"INSERT INTO CLIENTES (IDCidade, Nome, Endereco, Bairro, DataNascimento) VALUES
            (IDCidade, Nome, @pEndereco, @pBairro,  @pDataNascimento) select @@IDENTITY  ", obj).SingleOrDefault();

        }



        //public DataTable Carregar(int id)
        //{
        //    string sql = @"SELECT * 
        //                   FROM CLIENTES
        //                   WHERE ID = @pId";
        //    SqlCommand cmd = new SqlCommand(sql, banco);
        //    cmd.Parameters.Add(new SqlParameter("@pId", id));
        //    SqlDataAdapter adp = new SqlDataAdapter(cmd);
        //    DataTable dados = new DataTable();
        //    adp.Fill(dados);

        //    return dados;
        //}

        public Cliente Carregar(int id)
        {
       
            return banco.Query<Cliente>("SELECT *  FROM CLIENTES WHERE ID = @ID", new {ID = id }).SingleOrDefault();

        }

        //public bool Excluir(int id)
        //{

        //    SqlCommand cmd = new SqlCommand(@"DELETE
        //                   FROM CLIENTES
        //                   WHERE ID = @pId", banco);
        //    //   cmd.Parameters.AddWithValue("@pId", id);
        //    cmd.Parameters.Add(new SqlParameter("@pId", id));


        //    int qtde;
        //    //verifica se a conexao esta ok
        //    if (banco.State == ConnectionState.Closed)

        //        banco.Open();
        //    qtde = cmd.ExecuteNonQuery();


        //    if (banco.State == ConnectionState.Open)

        //        banco.Close();

        //    return qtde == 1;

        //}

        public bool Excluir(Cliente obj)
        {

            if (banco.State == ConnectionState.Closed)

                banco.Open();
            banco.ExecuteAsync(@"DELETE
                           FROM CLIENTES
                          WHERE ID = " + obj.ID);

            return true;

        }

        //public bool Alterar(Cliente obj)
        //{
        //    try
        //    {
        //        SqlCommand cmd = new SqlCommand(@"UPDATE
        //                                    CLIENTES SET 
        //                                   IDCidade = @pIDCidade,Nome = @pNome,Endereco = @pEndereco, Bairro = @pBairro,DataNascimento = @pDataNascimento
        //                                    WHERE ID = @pID", banco);

        //        cmd.Parameters.Add(new SqlParameter("pID", obj.ID));
        //        cmd.Parameters.Add(new SqlParameter("pIDCidade", obj.IDCidade));
        //        cmd.Parameters.Add(new SqlParameter("pNome", obj.Nome));
        //        cmd.Parameters.Add(new SqlParameter("pEndereco", obj.Endereco));
        //        cmd.Parameters.Add(new SqlParameter("pBairro", obj.Bairro));
        //        cmd.Parameters.Add(new SqlParameter("pDataNascimento", obj.DataNascimento));
        //        int qtde;
        //        //verifica se a conexao esta ok
        //        if (banco.State == ConnectionState.Closed)

        //            banco.Open();
        //        qtde = cmd.ExecuteNonQuery();


        //        if (banco.State == ConnectionState.Open)

        //            banco.Close();

        //        return qtde == 1;
        //    }
        //    catch (Exception erro)
        //    {
        //        MessageBox.Show("aconteceu o erro " + erro);
        //        throw;
        //    }


        //}

        public bool Alterar(Cliente obj)
        {
            if (banco.State == ConnectionState.Closed)

                banco.Open();
            banco.ExecuteAsync(@"UPDATE CLIENTES SET 
            IDCidade = @IDCidade,Nome = @Nome,Endereco = @Endereco, Bairro = @Bairro,DataNascimento = @DataNascimento   WHERE ID =@ID ", obj);
          

            return true;
        }
    }
}
