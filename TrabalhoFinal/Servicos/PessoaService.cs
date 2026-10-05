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
                Console.WriteLine(item.Nome);
            }
        }
    }
}
