namespace HR_in_meomory_curd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MockEmployeeRepos db = new MockEmployeeRepos();
            Console.WriteLine("SHOW EMPLOYEE LIST -->");
            Display(db);
//----------------------------------------------------------------------------------------------------------------------------
            Console.WriteLine("ADD EMPLOYEE-->");
            Employee_Poco a = db.Add(new Employee_Poco { Name = "Shubham", gender = "M", city = "Solapur", salary = 320000 });
            
            Employee_Poco b= db.Add(new Employee_Poco { Name = "Amar", gender = "M", city = " Naded", salary = 400000 });
            Display(db);
//------------------------------------------------------------------------------------------------------------------------
            Console.WriteLine("Get employee with ID--->");
            try
            {
                Employee_Poco c = db.GetEmployee_Poco(1);
                Console.WriteLine("{0} {1} {2} {3} {4}", c.Id, c.Name, c.gender, c.city, c.salary);

            }

            catch (Exception ex)
            {
                Console.WriteLine("Invalid ID");
            }
            Console.WriteLine("-------------------------------------------------------------------------------");
//------------------------------------------------------------------------------------------------------------------------------------
            Console.WriteLine("Delete Employee----->");
            db.Delete(1);
            Display(db);

            
//------------------------------------------------------------------------------------------------------------------------------------

            Console.WriteLine("Update Employee---->");
            Employee_Poco m =new Employee_Poco {Id = 4 ,Name ="Deva" , gender = "F" , city = "Nagpur" , salary=3200000 };
             UpdateData(m, db);
            
            
            static void UpdateData(Employee_Poco e , MockEmployeeRepos db)
            {
                db.Update(e);
                Display(db);
            }

            static void Display(MockEmployeeRepos db)
            {
                foreach (Employee_Poco a in db.GetEmployee_Poco())
                    Console.WriteLine("Id =" + a.Id +" Name ="+ a.Name + " Gender =" + a.gender + " City =" + a.city +" Salary ="+ a.salary);
                Console.WriteLine("-------------------------------------------------------------------------------");
            }
        }
    }
}