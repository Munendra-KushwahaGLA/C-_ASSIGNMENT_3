using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    public class Question_9
    {
        string name = "Munendra";
        protected void display()
        {
            Console.WriteLine(name);
            Console.ReadLine();
        }
    }
    class Derived : Question_9
    {
       public void access()
        {
            display();
        }
    }
    class Output
    { 
        public static void Main(string[] args)
        {
            Derived d = new Derived();
            d.access();
        }
    }
}
