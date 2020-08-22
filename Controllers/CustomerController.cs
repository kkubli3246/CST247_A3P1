using Activity3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;

namespace Activity3.Controllers
{


    public class CustomerController : Controller
    {
        CustomerModel c1 = new CustomerModel("Jeff", 14);
        CustomerModel c2 = new CustomerModel("Jen", 40);
        CustomerModel c3 = new CustomerModel("Sum", 125);

        public List<CustomerModel> customer = new List<CustomerModel>();

       

        // GET: Customer
        public ActionResult Index()
        {

            customer.Add(c1);
            customer.Add(c2);
            customer.Add(c3);

            foreach (var c in customer) 
            {
                c.ID = customer.IndexOf(c);
            }

            Tuple<List<CustomerModel>, CustomerModel> tuple  = new Tuple<List<CustomerModel>, CustomerModel>(customer, customer[0]);

            
            return View("Customer", tuple);
        }

        
        public ActionResult OnSelectCustomer(string cus)
        {
            customer.Add(c1);
            customer.Add(c2);
            customer.Add(c3);
            foreach (var c in customer)
            {
                c.ID = customer.IndexOf(c);
            }


            //Tuple<List<CustomerModel>, CustomerModel> tuple = new Tuple<List<CustomerModel>, CustomerModel>(customer, customer[Int32.Parse(cus)]);

            //return View("Customer", tuple);
            return PartialView("_CustomerDetails", customer[Int32.Parse(cus)]);
      
        }
    }

    
}