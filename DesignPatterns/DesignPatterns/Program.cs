using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            Console.WriteLine("Введите название шаблона.");
            input = Console.ReadLine();
            switch (input) {
                case "1":
                    Singleton.getSingletone("Одиночка работает");
                    Console.WriteLine(Singleton.text);
                    break;
            }
            Console.ReadLine();
            
        }
    }
}
