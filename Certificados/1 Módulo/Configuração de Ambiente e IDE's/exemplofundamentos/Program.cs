// See https://aka.ms/new-console-template for more information
using exemplofundamentos.Models;
using ExemploFundamentos.Models;

int[] arrayInteiros = new int[3];

arrayInteiros[0] = 10;
arrayInteiros[1] = 20;
arrayInteiros[2] = 30;
//arrayInteiros[3] = 40;

//Percorrendo o Array com o FOR 
for(int contador = 0; contador < arrayInteiros.Length; contador++) 
{
    Console.WriteLine($"Posicao numero: {contador} - {arrayInteiros[contador]}");
}
//Percorrendo o Array com o FOREACH
foreach(int valor in arrayInteiros)
{
    Console.WriteLine($"VALORES PERCORRIDOS PELO FOREACH:{valor}");
}




