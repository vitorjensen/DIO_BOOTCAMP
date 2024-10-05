using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploFundamentos.PessoaCopia
{
    public class Pessoa
    {   /* Criação dos atributos */
            public string Nome { get; set; }
            public int Idade { get; set; }
        
        /* Criação do Método */
        public void Apresentar(string @class)
        {
            @class = "teste";
            Console.WriteLine($"Olá, meu nome é {Nome}, e tenho {Idade} anos");
        }
    }
}