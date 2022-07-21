using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual seu nome?");
            var nome = Console.ReadLine();
            Console.WriteLine("Qual seu time favorito?");
            var time = Console.ReadLine();

            Console.WriteLine($"Seu nome é {nome}, e seu time preferido é o {time}.");

            Classe1 person = new Classe1();
            person.nome = "Hiago";
            person.dataDeNascimento = 2004;
            person.age = 18;

            person.Greeting();


        }
    }
}