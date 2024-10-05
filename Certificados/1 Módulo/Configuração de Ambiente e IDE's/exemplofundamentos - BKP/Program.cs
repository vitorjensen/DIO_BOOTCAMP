// See https://aka.ms/new-console-template for more information
using System.Reflection.Metadata;
using exemplofundamentos.Models;
using ExemploFundamentos.Models;

string opcao;
bool ExibirMenu = true;

while(ExibirMenu)
{
    Console.Clear();
    Console.WriteLine("Digite sua opcao");
    Console.WriteLine("1 - Cadastrar cliente:");
    Console.WriteLine("2 - Buscar cliente:");
    Console.WriteLine("3 - Apagar cliente:");
    Console.WriteLine("4 - Encerrar:");

    opcao = Console.ReadLine();

    switch(opcao)
    {
        case "1":
            Console.WriteLine("Digite o nome do cliente");
        break;
        
        case "2":
            Console.WriteLine("Busque o cliente por ID");
        break;

        case "3":
            Console.WriteLine("Digite o ID do cliente a ser apagado");
        break; 

        case "4":
            Console.WriteLine("Encerrar");
           ExibirMenu = false;
        break; 

        default:
        Console.WriteLine("Opcao invalida");
        break;
    }
}
Console.WriteLine("Voce saiu do seu programa");