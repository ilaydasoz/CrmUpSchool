using System;
using System.Collections.Generic;
using CrmUpSchool.BusinessLayer.Abstract;
using CrmUpSchool.DataAccessLayer.Abstract;
using CrmUpSchool.EntityLayer.Concrete;

namespace CrmUpSchool.BusinessLayer.Concrete
{
    public class CustomerManager : ICustomerService
    {
        private readonly ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public void TDelete(Customer t)
        {
            throw new NotImplementedException();
        }

        public Customer TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Customer> TGetList()
        {
            throw new NotImplementedException();
        }

        public void TInsert(Customer t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Customer t)
        {
            throw new NotImplementedException();
        }
    }
}
