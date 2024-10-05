using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploFundamentos.Models
{
    public class Pessoa
    {   /* Criação dos atributos */
            public string Nome { get; set; }
            public int Idade { get; set; }
        
        
        /* Criação do Método */
        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, e tenho {Idade} anos");
        }
    }
}