using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoApp
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> l1 = new List<string>();
            l1.Add("hello");
            Node test = new Node(12, l1);
            test.Add(10, "hey");
            test.Add(20, "yo");
            test.Add(2, "yea");
            test.Add(19, "ok");
            test.Add(5, "test");


            Console.WriteLine(test.Print());


            Console.WriteLine("Hello World!");
            string user_char;
            char ch;

            // Keep the console window open in debug mode.
            string[] lines = { "First line", "Second line", "Third line" };

            foreach (string line in lines) {

                Console.WriteLine(line);
                Console.WriteLine("Write a line:");

                user_char = Console.ReadLine();
                Console.WriteLine("You pressed '{0}'", user_char);
            }

        }
    }
}
