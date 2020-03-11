using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    public sealed class Singleton
    {
        private readonly static Singleton _instance = new Singleton();
        private Singleton()
        {

        }

        public void Hello()
        {
            Console.WriteLine("Hola");
            Console.ReadKey();
        }

        public static Singleton Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}
