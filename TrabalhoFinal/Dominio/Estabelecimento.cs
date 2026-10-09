using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoFinal.Dominio
{
    public class Estabelecimento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime Data_Abertura { get; set; }
        public string Endereco { get; set; }
        public bool AtendimentoUnissex { get; set; }
    }
}
