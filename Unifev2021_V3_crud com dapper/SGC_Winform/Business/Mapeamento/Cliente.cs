using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGC_Winform.Business.Mapeamento
{
    public class Cliente
    {
        public int ID { get; set; }
        public int IDCidade { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Bairro { get; set; }
        public DateTime DataNascimento { get; set; }

    }
}
