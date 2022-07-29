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
           int contador = 0;
            while (contador < 10)
            {
                Console.WriteLine(contador + 1);
                Console.WriteLine("while está sendo executado");
                contador++;
            }
          Console.WriteLine("fim da linha");






            Console.ReadLine();
        }
    }
}