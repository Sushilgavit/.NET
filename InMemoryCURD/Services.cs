using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InMemoryCURD
{
    public class Services : interface1
    {
        static List<Student> StudentList;

        public Services()
        {
            StudentList = new List<Student>()
            {
                new Student() { Id = 1, Name = "Yash", Gender = 'M', Standard = "10" , MobileNumber = "233456789" },
                new Student() { Id = 2, Name = "Shubham", Gender = 'M', Standard = "10" , MobileNumber = "723423789" },
                new Student() { Id = 3, Name = "Akshay", Gender = 'M', Standard = "10" , MobileNumber = "1232123789" },
                new Student() { Id = 4, Name = "Ajinkya", Gender = 'M', Standard = "10" , MobileNumber = "1232321789" }

            };
        }
        public Student Add(Student student)
        {
                student.Id=StudentList.Max(x=>x.Id)+1;
            StudentList.Add(student);
            return student;
        }

        public Student Delete(int id)
        {
            Student student = StudentList.FirstOrDefault(x=>x.Id==id);
            if (student != null)
            {
                StudentList.Remove(student);
            }
            return student;
        }

        public IEnumerable<Student> GetAll(string MobileNumber)
        {
            return StudentList.FindAll(x=>x.MobileNumber.StartsWith(MobileNumber));
        }

        public IEnumerable<Student> GetStudents()
        {
            return StudentList;
        }

        public Student Update(Student std, int id)
        {
            Student student = StudentList.FirstOrDefault(y => y.Id==id);
            if (std != null)
            {
                student.Id=std.Id;
                student.Name=std.Name;
                student.Gender=std.Gender;
                student.Standard=std.Standard;
            }
            return student;
        }
    }
}
