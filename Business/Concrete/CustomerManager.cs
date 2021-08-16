using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        private ICustomerDal _customerDal;
        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }
        public IDataResult<List<Customer>> GetAll()
        {
            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll());
        }

        public IDataResult<Customer> GetById(string customerId)
        {
            return new SuccessDataResult<Customer>(
                _customerDal.Get(c => c.CustomerId == customerId)
                );
        }

        public IDataResult<List<CustomerOrdersDto>> GetCustomerOrders()
        {
            return new SuccessDataResult<List<CustomerOrdersDto>>(
                _customerDal.GetCustomerOrders()
                );
        }
    }
}
