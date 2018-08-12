using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoApp
{
    class CLI
    {

        public CLI() { }

        public Node RouteCommand(string cmd, Node node) {

            switch (cmd) {
                case "create":
                    node = this.Create();
                    break;
                case "add":
                    node = this.Add(node);
                    break;
                case "print":
                    Console.WriteLine(node.Print());
                    break;
                default:
                    Console.WriteLine("invalid command");
                    break;
            }

            return node;
        }

        public Node Create() {

            Console.WriteLine("Input a key");
            string key = Console.ReadLine();

            int x = 0;
            Boolean inttest = Int32.TryParse(key, out x);

            while (!inttest) {
                Console.WriteLine("Not a valid integer, try again");

                key = Console.ReadLine();
                inttest = Int32.TryParse(key, out x);

            }

            Console.WriteLine("Provide a value to store under the key");
            string val = Console.ReadLine();

            //create node from data
            List<string> l1 = new List<string>();
            l1.Add(val);
            Node res = new Node(x, l1);

            return res;

        }

        public Node Add(Node node) {

            Console.WriteLine("Input a key");
            string key = Console.ReadLine();

            int x = 0;
            Boolean inttest = Int32.TryParse(key, out x);

            while (!inttest)
            {
                Console.WriteLine("Not a valid integer, try again");

                key = Console.ReadLine();
                inttest = Int32.TryParse(key, out x);

            }

            Console.WriteLine("Provide a value to store under the key");
            string val = Console.ReadLine();

            node.Add(x, val);
            return node;
        }


    }
}
