using System;
using Primeiro;
using CSharp;
using Interface;
using Enum;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Modos de chamar o Enum (chamando uma variável através de um Index)
            var pessoa1 = (Pessoas)0;
            Pessoas pessoa2 = Pessoas.João;
            Pessoas pessoa3 = (Pessoas)4;
            
            Animal animal = new Animal();

            animal.Nome = "Rex";
            animal.NomeDono = "Pedro";
            animal.Especie = "Cachorro";
            
            Pessoa person = new Pessoa();
            person.Nome = "Jhonatas";
            person.Idade = 35;
            person.Estado = "SP";

            var person2 = new Pessoa();
            person2.Nome = "João";
            person2.Idade = 48;
            person2.Estado = "SC";

            var classe = new Classe();
            var classe2 = new Segundo.Classe();

            Console.WriteLine("Hello, World!" + pessoa3);
        }
    }
}