using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    public class Question_7
    {
        private string name = "monu";
        void changeproperty(string name2)
        {
            Console.WriteLine("Initial name is: " + name);
            name = name2;
            Console.WriteLine("Final name is: " + name);
            Console.ReadLine();
        }
        class Output
        {
            //public static void Main(string[] args)
            //{
            //    Question_7 question_7 = new Question_7();
            //    question_7.changeproperty("Munendra");
            //}
        }
    }
}
