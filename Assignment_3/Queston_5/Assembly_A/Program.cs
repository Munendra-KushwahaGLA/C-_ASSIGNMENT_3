using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assembly_A
{
    public class Program
    {
        protected internal string greet = "Hello! This is protected internal";
        public void display()
        {
            Console.WriteLine(greet);
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            program.display();
        }

    }
}
