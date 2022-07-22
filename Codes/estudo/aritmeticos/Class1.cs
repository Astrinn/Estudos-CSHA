using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudo.aritmeticos
{
    internal class Class1
    {
        public int teste = 20 + 20;
        public int teste2 = 20 - 10;
        public float teste3 = 2.5f + 2.5f;
        public int teste4 = (int)(2 + 2.5f);
        public int teste5 = 20 * 20;
        public int teste6 = 20 / 10;
        public int valor1;
        public int valor2;  
        public void Greeting()
        {
            Console.WriteLine($"{teste}");
            Console.WriteLine($"{teste2}");
            Console.WriteLine($"{teste3}");
            Console.WriteLine($"{teste4}");
            Console.WriteLine($"{teste5}");
            Console.WriteLine($"{teste6}");
            Console.WriteLine(valor1 + valor2);
        }
    }
}
