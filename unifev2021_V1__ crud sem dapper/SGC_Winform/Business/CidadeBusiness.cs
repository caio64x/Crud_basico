using SGC_Winform.Suporte;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGC_Winform.Business
{
    public class CidadeBusiness : Conexao
    {
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
