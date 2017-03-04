using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    /// <summary>
    /// Паттерн проектирования Одиночка (singleton). 
    /// Гарантирует, что у класса есть только один экземпляр и предоставляет к нему точку доступа.
    /// Предоставляет глобальную точку доступа к объекту. 
    /// Можно создать только один объект. 
    /// </summary>
    class Singleton
    {
        private static Singleton instance;
        public static string text;
        

        private Singleton(string a) //конструктор класса приватный
        {
            text = a;
        }
        public static Singleton getSingletone(string a) //публичный метод, который создает объект, только если он уже не создан
        {
            if (instance == null)
            {
                instance = new DesignPatterns.Singleton(a);
            }
            return instance;
        }
    }
}
