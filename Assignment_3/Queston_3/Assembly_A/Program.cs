using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assembly_A
{
    public class Program
    {
        internal string name = "Munendra Kushwaha";
        public void display()
        {
            Console.WriteLine(name);
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            program.display();
        }
    }
}
