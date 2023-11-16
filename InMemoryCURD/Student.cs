using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InMemoryCURD
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Standard {  get; set; }
        public Char Gender { get; set; }
        public string MobileNumber { get; set; }

        public override string ToString()
        {
            return $"ID ={Id} ,Name {Name} , Standard {Standard} , Gender {Gender} , MobileNumber {MobileNumber} ";
        }
    }
}
