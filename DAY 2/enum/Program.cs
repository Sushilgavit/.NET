/*
Create enum dep having value[MKT = 1, ADV = 2, ADMN = 3]
Create a class Employee with instance member id, name, salary and enum dept d.
Create 5 object of class Employee and put them into different department.
Write a  sataic method which will display department wise total salary paid

E.g.
1, "Raj", 3000, dep.ADMN
2, "Reena", 2000, dep.ADMN
 3, "Geeta", 1000, dep.MKT

O/p ADMN department spend 5000 on salary
MKT department spend 1000 on salary

*/
using @enum;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace @enum
{
   public enum dep
    {
        MKT= 1,
        ADV= 2,
        ADMIN = 3,
    }
   
}

public class Employe
{
    int ID;
    String Name;
    Double salary;
    dep d;

    public Employe(int iD, string name, double salary, dep d)
    {
        ID = iD;
        Name = name;
        this.salary = salary;
        this.d = d;
    }
    public dep GetDep()
        {
        return d;
        }
    public double getSalary()
    {
        return salary;
    }

    public override string ToString()
    {
        return ($"name = {Name} ID = {ID} depart = {d}");
    }



}

public class main
{
    public static void Display(Employe[] arr)
    {
        double sum_1 = 0; double sum_2 = 0;double sum_3 = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i].GetDep() == dep.MKT)
            {
                sum_1 += arr[i].getSalary();
            }
            if (arr[i].GetDep() == dep.ADV)
            {
                sum_2 += arr[i].getSalary();
            }
            if (arr[i].GetDep() == dep.ADMIN)
            {
                sum_3 += arr[i].getSalary();
            }

            Console.WriteLine(arr[i]);

        }
        Console.WriteLine(sum_1);
        Console.WriteLine(sum_2);
        Console.WriteLine(sum_3);
    }

    public static void Main(string[] args)
    {
        Employe[] arr = new Employe[3];
        arr[0] = new Employe( 01 ,"Raj" , 3000 , dep.ADMIN);
        arr[1] =new Employe(02 , "Reena" , 2000 , dep.ADMIN);
        arr[2] =new Employe (03  ,"Geeta" , 1000 , dep .MKT);
      
       
        
        Display(arr);
        
    }
}
