using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InMemoryCURD
{
    public interface interface1
    {

        public IEnumerable<Student> GetStudents();

        public Student Add(Student student);

        public Student Update(Student student , int id );

        public Student Delete(int id);

        public IEnumerable<Student> GetAll(string MobileNumber);
    }
}
