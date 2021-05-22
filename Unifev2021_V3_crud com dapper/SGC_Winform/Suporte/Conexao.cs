using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using SGC_Winform.Business.Mapeamento;

namespace SGC_Winform.Suporte
{
    public class Conexao
    {
        //metodo para conectar o banco de dados
        public static SqlConnection getConnection()
        {
            //acessando a string de conexão
            string banco = ConfigurationManager.ConnectionStrings["banco"].ConnectionString;

            return new SqlConnection(banco);
        }

   


    }
}
