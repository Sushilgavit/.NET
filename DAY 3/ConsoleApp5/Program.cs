using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class student
    {
        string name;
        int math;
        int science;
        int eng;  //int total ;
        int mark;


        public student(string name, int math, int science, int eng)
        {
            this.name = name;
            this.math = math;
            this.science = science;
            this.eng = eng;
            this.mark = mark;
        }

        public int TotalMarks()
        {
            return mark = math + science + eng;
        }

        public void display()
        {
            TotalMarks();
            Console.WriteLine($"name = {name} mark ={mark}");
        }
    }
    public class main
    {
        static void Main(string[] args)
        {
            student s = new student("sushil", 100, 100, 100);
            s.display();
        }


    }
}
