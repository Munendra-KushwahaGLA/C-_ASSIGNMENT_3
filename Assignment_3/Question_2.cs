using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    internal class Question_2
    {
        private int age=29;
        public int getvalue()
        {
            return age;
        }
    }
    
    class Different
    {
        public void showmembers()
        {
            Question_2 question = new Question_2();
            Console.WriteLine(question.getvalue());
            Console.ReadLine();
        }  
    }
    class ABC
    {
        //public static void Main(string[] args)
        //{
        //    Different different = new Different();
        //    different.showmembers();
        //}
    }
}
