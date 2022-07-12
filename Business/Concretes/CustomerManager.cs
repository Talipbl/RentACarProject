using Business.Abstracts;
using Business.Constanst;
using Core.Utilities.Results;
using Core.Utilities.Results.Abstracts;
using DataAccess.Abstracts;
using Entities.Concretes.Models;
using System;
using System.Collections.Generic;

namespace Business.Concretes
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;
        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }
        public IResult BaseOperations(bool success, string message)
        {
            if (success)
            {
                return new SuccessResult(message);
            }
            return new ErrorResult(Messages.ProcessFailed);
        }
        public IResult Add(Customer customer)
        {
            return BaseOperations(_customerDal.Add(customer).Success, Messages.Customer.Added);
        }

        public IResult Delete(int customerId)
        {
            return BaseOperations(_customerDal.Delete(new Customer { CustomerId = customerId }).Success, Messages.Customer.Deleted);
        }

        public IDataResult<Customer> Get(int id)
        {
            return new SuccessDataResult<Customer>(_customerDal.Get(p => p.CustomerId == id), Messages.Customer.Listed);
        }

        public IDataResult<List<Customer>> GetAll()
        {
            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll(), Messages.Customer.Listed);
        }

        public IResult Update(Customer customer)
        {
            return BaseOperations(_customerDal.Update(customer).Success, Messages.Customer.Updated);
        }
    }





}
