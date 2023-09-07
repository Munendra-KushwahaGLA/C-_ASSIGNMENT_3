using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assembly_A
{
    public class Program
    {
        private int i;
        internal Program(int data)
        {
            this.i = data;
        }
        public void display()
        {
            Console.WriteLine(i);
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            Program program = new Program(23);
            program.display();
            
        }
    }
}
