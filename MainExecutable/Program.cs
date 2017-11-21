using System;
using Ch1;

namespace MainExecutable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            IMessageWriter writer = new SecureMessageWriter(new ConsoleMessageWriter());
            var salutation = new Salutation(writer);
            salutation.Exclaim();
            Console.ReadLine();
        }
    }
}
