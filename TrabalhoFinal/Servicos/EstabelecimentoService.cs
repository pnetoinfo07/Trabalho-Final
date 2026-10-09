using TrabalhoFinal.Dominio;

namespace TrabalhoFinal.Servicos
{
    public static class EstabelecimentoService
    {
        public static List<Estabelecimento> Estabelecimentos { get; set; }
            = new List<Estabelecimento>()
            {
                new Estabelecimento(){ Id=1,Nome="Embeleze", Data_Abertura=DateTime.Now, Endereco = "Rua Um", AtendimentoUnissex = true },
                new Estabelecimento(){ Id=2,Nome="Salão da Joana", Data_Abertura=DateTime.Now, Endereco = "Rua Dois", AtendimentoUnissex = true  },
                new Estabelecimento(){ Id=3,Nome="Beleza Profunda", Data_Abertura=DateTime.Now, Endereco = "Rua Três", AtendimentoUnissex = true  }
             };

        public static void Remover(int id)
        {
            Estabelecimento p = Estabelecimentos.Find(Estabelecimento => Estabelecimento.Id == id);
            if (p != null)
            {
                Estabelecimentos.Remove(p);
                Listar();
            }
            else
            {
                Console.WriteLine("Sistema não conseguiu encontrar o usuario");
            }
        }
        public static void Editar(int id, string novoNome, DateTime novaDataAbertura, string novoEndereco, bool novoAtendimentoUnissex)
        {
            Estabelecimento p = Estabelecimentos.Find(Estabelecimento => Estabelecimento.Id == id);
            if (p != null)
            {
                p.Nome = novoNome;
                p.Data_Abertura = novaDataAbertura;
                p.Endereco = novoEndereco;
                p.AtendimentoUnissex = novoAtendimentoUnissex;

                Listar();
            }
            else
            {
                Console.WriteLine("Sistema não conseguiu encontrar o usuario");
            }
        }
        public static void Adicionar(string nome
            ,DateTime dataAbertura
            ,string endereco
            ,bool atendimentoUnissex)
        {
            Estabelecimento Estabelecimento = new Estabelecimento();
            Estabelecimento.Id = Estabelecimentos.Count > 0 ?
                Estabelecimentos.Count + 1 : 1;
            Estabelecimento.Nome = nome;
            Estabelecimento.Data_Abertura = dataAbertura;
            Estabelecimento.Endereco = endereco;
            Estabelecimento.AtendimentoUnissex = atendimentoUnissex;
            Estabelecimentos.Add(Estabelecimento);
        }
        public static void Listar()
        {
            foreach (Estabelecimento item in Estabelecimentos)
            {
                Console.WriteLine(item.Id);
                Console.WriteLine(item.Nome);
                Console.WriteLine(item.Endereco);
                Console.WriteLine("---------------------");
            }
        }
        public static void BuscarPorId(int id)
        {
            // Passo um Id por parametro e o metodo
            // lista as informações detalhadas da Estabelecimento
        }
    }
}
