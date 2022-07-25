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
            Function1(-4);
            Console.ReadLine();
        }

        static void Function1(int preco)                  
        {                                     
            int precoAbs = Math.Abs(preco);
            int valorFinal = precoAbs + (-1);
            Console.WriteLine("Valor Final: "+ valorFinal);
        }

    }
}