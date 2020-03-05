using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 3;
            int answer = Exponential(a, b);
            Console.WriteLine(answer);
            answer = ExpRecursive(a, b);
            Console.WriteLine(answer);
            ExpRecursive(a, b);

            Console.WriteLine(a);
            MyValue myValue = new MyValue();
            myValue.A = 25;
            Foo(myValue);
            Console.WriteLine(myValue.A);
            int x = 15;
            int y = 20;
            swap(ref x, ref y);
            Console.WriteLine(x + " " + y);
            Zero(out a);
            Console.WriteLine(a);
            DateTime date = System.DateTime.Today;
            int year;
            int month;
            int day;
            Extract(DateTime.Today, out day, out month, out year);
            Console.WriteLine(day + " " + month + " " + year);

        }
        private static int Exponential(int a, int b)
        {
            if(b==0)
            {
                return 1;
            }
            int total = a;
            
            for(int i = 1; i<b; i++)
            {
                total = (total * a);
                
            }
            return total;
        }

        private static int ExpRecursive(int a, int b)
        {
            if(b==0)
            {
                return 1;
            }
            else
            {
                return a * ExpRecursive(a, b - 1);
            }
   
        }


        private static void Extract(DateTime date, out int day, out int month, out int year)
        {
            year = date.Year;
            month = date.Month;
            day = date.Day;
        }

        private static void Zero(out int a)
        {
            a = 0;
        }

        static void swap(ref int x, ref int y)
        {
            int extra = x;
            x = y;
            y = extra;

        }

        static void Foo(MyValue myValue)
        {
            myValue.A = myValue.A * 25;
        }

        static void Foo(ref int a)
        {
            a = a * 25;
        }

        internal class MyValue
        {
            public int A { get; set; }
        }
    }
}
