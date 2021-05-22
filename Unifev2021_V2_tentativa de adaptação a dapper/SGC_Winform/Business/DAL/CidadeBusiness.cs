using Dapper;
using SGC_Winform.Business.Mapeamento;
using SGC_Winform.Suporte;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
namespace SGC_Winform.Business
{
    public class CidadeBusiness : Conexao
    {
        SqlConnection banco;

        public CidadeBusiness()
        {
            this.banco = Conexao.getConnection();
        }


        public DataTable Listar()
        {
            string sql = @"SELECT * from Cidades ORDER BY Nome";

            SqlCommand cmd = new SqlCommand(sql, banco);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dados = new DataTable();
            adp.Fill(dados);

            return dados;

        }





    }

}
