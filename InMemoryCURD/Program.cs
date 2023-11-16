namespace InMemoryCURD
{
    internal class Program
    {
        static Services services = new Services();
        static void Main(string[] args)
        {
           GetStudents();
            Console.WriteLine("---------------");
            add(new Student() { Id = 5 , Name = "sachin " , Gender = 'M' , Standard = "10" , MobileNumber ="1231343423" });
            GetStudents();
            Console.WriteLine("---------------");
            remove(2);
            GetStudents();
            Console.WriteLine("-------------------------------------------------");
            FindeByNo("123");
           
            Console.WriteLine("------------------------------------------");
            update(new Student() { Name = "Amar", Gender = 'M', Standard = "10", MobileNumber = "14234425254" } , 1);
            GetStudents() ;
        }

        static void add(Student student)
        {
            services.Add(student);
        }

        static void remove(int id)
        {
            services.Delete(id);

        }

        static void update(Student student ,int id)
        {
            services.Update(student ,id);
        }

        static void FindeByNo(string MobileNumbe)
        {
           var list= services.GetAll(MobileNumbe);
            foreach (var student in list)
            {
                Console.WriteLine(student);
            }
        }

        static void GetStudents()
        {
            var list = services.GetStudents();
            foreach (var student in list)
            {
                Console.WriteLine(student);
            }
        }
    }
}
