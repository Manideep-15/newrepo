using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloTools
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Usage: HelloTools [--version] [--name <your name>]");
                return;
            }

            for (int i = 0; i < args.Length; i++)
            {
                switch (args[i])
                {
                    case "--version":
                        Console.WriteLine("HelloTools CLI v1.0.0");
                        break;

                    case "--name":
                        if (i + 1 < args.Length)
                        {
                            string name = args[i + 1];
                            Console.WriteLine($"Hello, {name}!");
                            i++;
                        }
                        else
                        {
                            Console.WriteLine("Error: --name requires a value.");
                        }
                        break;

                    default:
                        Console.WriteLine($"Unknown option: {args[i]}");
                        break;
                }
            }
        }
    }
}
