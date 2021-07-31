using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICustomerService
    {
        public IDataResult<List<Customer>> GetAll();
        public IDataResult<Customer> GetById(int customerId);
        public IDataResult<List<Customer>> GetByCountry(string country);
        public IDataResult<List<Customer>> GetByCity(string city);

    }
}
