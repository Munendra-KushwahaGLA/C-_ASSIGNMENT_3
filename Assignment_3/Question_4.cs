using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    public class Question_4
    {
        protected int age=19;
        protected string name="Munendra";
        
    }
    class ABCD : Question_4
    {
        public void display()
        {
            Console.WriteLine(age + "\n" + name);
            Console.ReadLine();
        }
    }
    class Maiin
    {
        //public static void Main(string[] args)
        //{
        //    ABCD obj = new ABCD();
        //    obj.display();
        //}
    }
}
