using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemo.Concrete
{
    public class StarbucksCustomerManager:BaseCustomerManager
    {
       private ICustomerCheckService _customerCheckService;

        public StarbucksCustomerManager(ICustomerCheckService customerCheckService)// dependency injection
        {
            _customerCheckService = customerCheckService;
        }

        public override void Save(Customer customer)
        {
            if (_customerCheckService.CheckIfRealPerson(customer))
            {
                base.Save(customer);
            }
            else
            {
                throw new Exception("Not a valid person");
            }
           
            
        }

        // burada mernis kontrollerini yazabilirdik ama ileride Neroda isteerse böyle bir doğrulama bizi uğraştırır.
        //private void CheckIfRealPerson(Customer customer) 
        //{
        //    throw new NotImplementedException();
        //}
    }
}
