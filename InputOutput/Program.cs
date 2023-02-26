using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace InputOutput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To AddressBook");
            AddressBook manager = new AddressBook();
            while (true)
            {
                Console.WriteLine("Enter O to Display");
                char input = Console.ReadLine().ToUpper()[0];
                switch (input)
                {
                    case 'O':
                        manager.Display();
                        break;
                    default:
                        Console.WriteLine("Invalid Entry try again");
                        break;
                }
                Console.Clear();
            }
        }
    }
}
