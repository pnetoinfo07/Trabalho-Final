using TrabalhoFinal.Dominio;

namespace TrabalhoFinal.Servicos
{
    public static class PessoaService
    {
        public static List<Pessoa> Pessoas { get; set; }
            = new List<Pessoa>()
            {
                new Pessoa(){ Id=1,Nome="Paulo",Email="paulo@gmail.com", Data_Nascimento=DateTime.Now },
                new Pessoa(){ Id=2,Nome="Ana",Email="paulo@gmail.com", Data_Nascimento=DateTime.Now },
                new Pessoa(){ Id=3,Nome="Raimundo",Email="paulo@gmail.com", Data_Nascimento=DateTime.Now },
                new Pessoa(){ Id=4,Nome="Fulano2",Email="paulo@gmail.com", Data_Nascimento=DateTime.Now },
                new Pessoa(){ Id=5,Nome="Fulano3",Email="paulo@gmail.com", Data_Nascimento=DateTime.Now },
             };

        public static void Remover(int id)
        {
            Pessoa p = Pessoas.Find(pessoa => pessoa.Id == id);
            if(p != null)
            {
                Pessoas.Remove(p);
                Listar();
            }
            else
            {
                Console.WriteLine("Sistema não conseguiu encontrar o usuario");
            }
        }
        public static void Editar(int id, string novoNome, string novoEmail, DateTime novaDataNascimento)
        {
            Pessoa p = Pessoas.Find(pessoa => pessoa.Id == id);
            if (p != null)
            {
                p.Nome = novoNome;
                p.Email = novoEmail;
                p.Data_Nascimento = novaDataNascimento;
                Listar();
            }
            else
            {
                Console.WriteLine("Sistema não conseguiu encontrar o usuario");
            }
        }
        public static void Adicionar(string nome
            , string email
            , DateTime data_nascimento)
        {
            Pessoa pessoa = new Pessoa();
            pessoa.Id = Pessoas.Count > 0 ?
                Pessoas.Count + 1 : 1;
            pessoa.Nome = nome;
            pessoa.Email = email;
            pessoa.Data_Nascimento = data_nascimento;
            Pessoas.Add(pessoa);
        }
        public static void Listar()
        {
            foreach (Pessoa item in Pessoas)
            {
                Console.WriteLine(item.Id);
                Console.WriteLine(item.Nome);
                Console.WriteLine("---------------------");
            }
        }
        public static void BuscarPorId(int id)
        {
            // Passo um Id por parametro e o metodo
            // lista as informações detalhadas da pessoa
        }
    }
}
