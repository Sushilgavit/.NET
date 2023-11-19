using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Create class Student with private member variable prn_no,java,c#,Html,Total,Percentage
Write method public void get_total()
Write method public void get_Percentage()
Write method public string display()-> which will display prn_o , total, percentage
create two objects of class and display record*/
namespace Day_2
{
    internal class Program
    {
        class student
        {
            private int prn_no;
            private int java;
            private int csharp;
            private int Html;
            private int Percentage;
            private int total;

             public student(int prn_no, int java, int csharp, int Html)
            {
                this.prn_no = prn_no;
                this.java = java;
                this.csharp = csharp;
                this.Html = Html;

               
            }
             public  void get_total()
            {
                 this.total=java+csharp+Html;
            }

            public void get_Percentage()
            {
              
                this.Percentage = (this.total*100) / 300;
                Console.WriteLine(this.Percentage);

            }

            public string display()
            {
                
                get_total();
                get_Percentage();
                return string.Format("prn_no ={0} , total = {1} ,Percentage = {2}", prn_no ,total ,Percentage);
            }

        }

        static void Main(string[] args)
        {
            student s1=new student(001, 75, 87, 98);
            student s2=new student(002, 90, 90, 90);
            Console.WriteLine(s1.display());
            Console.WriteLine(s2.display());
            Console.ReadLine()
;        }
    }
}
