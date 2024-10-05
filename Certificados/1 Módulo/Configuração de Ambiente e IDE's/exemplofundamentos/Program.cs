// See https://aka.ms/new-console-template for more information
using exemplofundamentos.Models;
using ExemploFundamentos.Models;

List<string> listaString = new List<string>();
listaString.Add("SP");
listaString.Add("BA");
listaString.Add("ES");
listaString.Add("RJ");

Console.WriteLine("Lista percorrida utilizando o FOR");
for(int contador = 0; contador < listaString.Count; contador++)
{
Console.WriteLine($"Posição N: {contador} - {listaString[contador]}");

}
int contadorForeach = 0;
foreach (string item in listaString){
  Console.WriteLine($"Posição N: {contadorForeach} - {item}");
  contadorForeach++;
}
/*int[] arrayInteiros = new int[3];

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
*/



