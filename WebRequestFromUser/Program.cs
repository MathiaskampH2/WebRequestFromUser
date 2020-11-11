using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WebRequestFromUser
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1: Read data from website :");
            Console.WriteLine("2. Read data from file :" );
            int userInput = int.Parse(Console.ReadLine());

            switch (userInput)
            {
                case 1:
                    Console.Clear();
                    Console.Write("Type the websites url: ");
                    string path = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("Receiving data.............");
                    Thread.Sleep(4000);
                    Console.Clear();
                    Console.WriteLine("Preparing to print data...........");
                    Thread.Sleep(3000);
                    Console.Clear();
                    Console.WriteLine("Printing..........");
                    Thread.Sleep(2000);
                    Console.Clear();
                    WebRequester webRequester = new WebRequester();
                    Console.WriteLine(webRequester.RequestData(path));
                    break;
                case 2:
                    Console.Clear();
                    Console.Write("Type the files path: ");
                    string path2 = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("Receiving data.............");
                    Thread.Sleep(4000);
                    Console.Clear();
                    Console.WriteLine("Preparing to print data...........");
                    Thread.Sleep(3000);
                    Console.Clear();
                    Console.WriteLine("Printing..........");
                    Thread.Sleep(2000);
                    Console.Clear();
                    FileRequester fileRequester = new FileRequester();
                    Console.WriteLine(fileRequester.RequestData(path2));
                    break;
            }
        }
    }
}