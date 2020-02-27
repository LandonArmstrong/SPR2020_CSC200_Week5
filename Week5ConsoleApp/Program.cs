using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            SayHello();
            SayGoodbye();
            SayHelloTo("something");
            SayHelloTo("something");
            int a = 3;
            int b = 5;
            int c = AddTogether(a, b);
            string phrase = "How is your day";

            Console.WriteLine("Output of sum(a,b) = " + c);
        }

        public static void SayHello()
        {
            Console.WriteLine("Hello");
        }

        public static void SayGoodbye()
        {
            Console.WriteLine("Goodbye");
        }
        public static void SayHelloTo(string name)
        {
            Console.WriteLine("Hello" + name);

        }
        public static void SayGoodbyeTo(string name)
        {
            Console.WriteLine("Goodbye" + name);

        }

        public static int AddTogether(int left, int right)
        {
            return left + right;
        }
        public static int SpaceCount(string phrase)
        {
            int count = 0;
            for (int i = 0; i <= phrase.Length; i++)
            {
                if (phrase[i].Equals(""))
                {
                    count++;
                }
            }
            return count;
        }
    }
}
