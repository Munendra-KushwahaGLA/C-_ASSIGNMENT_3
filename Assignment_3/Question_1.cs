using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    internal class Question_1
    {
        private int age;
        private string name;
        public void setvalue(int age,string name)
        {
            this.age = age;
            this.name = name;
        }
        public void getvalue()
        {
            Console.WriteLine(age);
            Console.WriteLine(name);
            Console.ReadLine();
        }
        
    }
    class Program2
    {
        //public static void Main(string[] args)
        //{
        //    Question_1 p = new Question_1();
        //    p.setvalue(23, "monu");
        //    p.getvalue();
        //}
    }
}
