using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    public class Question_6
    {
        public int emp_no = 23;
        public string name = "Mahesh Dalle";
    }
    class ABCDE:Question_6
    {
        public void display2()
        {
            Console.WriteLine(name + "\n" + emp_no);
            Console.ReadLine();
        }
    }
    public class Outcome
    {
        //public static void Main(string[] args)
        //{
        //    ABCDE ab = new ABCDE();
        //    ab.display2();
        //}
    }
}
