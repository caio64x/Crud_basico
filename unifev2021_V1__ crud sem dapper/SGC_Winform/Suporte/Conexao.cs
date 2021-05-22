using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace SGC_Winform.Suporte
{
    public class Conexao
    {
        public SqlConnection banco = null;

        public Conexao()
        {
            banco = new SqlConnection(@"Server=.\SQLEXPRESS;Database=BancoEC7;User Id=SA;Password=123123;");

        }
    }
}
