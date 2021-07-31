using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

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
            throw new NotImplementedException();
        }

        public IDataResult<List<Customer>> GetByCity(string city)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Customer>> GetByCountry(string country)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<CustomerOrdersDto>> GetCustomerOrders()
        {
            return new SuccessDataResult<List<CustomerOrdersDto>>();
        }
        public IDataResult<Customer> GetById(int customerId)
        {
            throw new NotImplementedException();
        }
    }
}
