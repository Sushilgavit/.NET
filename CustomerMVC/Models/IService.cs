namespace CustomerMVC.Models
{
    public class IService : ICustomer
    {
        public static List<Customer> _clist;

        public IService()
        {
            _clist = new List<Customer>()
            {
            new Customer() { Id = 1, Name = "Sushil", MobileNumber = "8421588939", BillAmount = 2000 },
            new Customer() { Id = 2, Name = "Rushi", MobileNumber = "9146222732", BillAmount = 4000 },
            new Customer() { Id = 1, Name = "Sachin", MobileNumber = "9922812588", BillAmount = 6000 },

            };


        }
        public List<Customer> GetAllCustomers() 
        {
            return _clist;
        }
    }
}
