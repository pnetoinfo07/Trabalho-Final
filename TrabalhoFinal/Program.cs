// See https://aka.ms/new-console-template for more information
using TrabalhoFinal.Dominio;
using TrabalhoFinal.Servicos;
using TrabalhoFinal.Views;
PessoaService.Listar();
Console.WriteLine("Digite o Id do usuario que deseja excluir");
int id = int.Parse(Console.ReadLine());
PessoaService.Remover(id);
PessoaService.Editar(4, "João", "João@gmail.com", Convert.ToDateTime("07/07/1999"));
