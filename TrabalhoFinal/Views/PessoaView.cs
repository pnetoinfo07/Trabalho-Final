using TrabalhoFinal.Dominio;
using TrabalhoFinal.Servicos;

namespace TrabalhoFinal.Views
{
    public static class PessoaView
    {
        public static void Adicionar() 
        {
            Console.WriteLine("----- Bem vindo ao cadastro de Pessoas -----");
            Console.WriteLine("Precisamos de algumas informações para realizar o cadastro, segue abaixo.");
            Console.WriteLine("Digite seu nome?");
            string nome = Console.ReadLine();
        }
        public static void Listar()
        {
            int count = 1;
            foreach (Pessoa item in PessoaService.Pessoas)
            {
                bool primeiraLinha = count == 1;
                ImprimirPessoa(item.Id, item.Nome, primeiraLinha);
                count++;
            }
            
        }
        public static void ImprimirPessoa(int id, string nome, bool ehPrimeiraLinha)
        {
            int largura = 30;

            Console.WriteLine(new string('-', largura + 2));
            if (ehPrimeiraLinha)
            {
                Console.WriteLine("|" +
                    "Listagem de Pessoas".PadLeft(26).PadRight(largura) + "|");

                Console.WriteLine(new string('-', largura + 2));
            }

            Console.WriteLine("|" + $" ID   : {id}".PadRight(largura) + "|");

            Console.WriteLine("|" + $" Nome : {nome}".PadRight(largura) + "|");

            Console.WriteLine(new string('-', largura + 2));
        }

    }


}
