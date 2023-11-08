using CustomerMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace CustomerMVC.Controllers
{
    public class CustomerController : Controller

    {

        ICustomer _ICust;

        public CustomerController(ICustomer iCust)
        {
            _ICust = iCust;
        }

        public IActionResult Index()
        {
           
            return View(_ICust.GetAllCustomers());
        }

       

       
    }
}
