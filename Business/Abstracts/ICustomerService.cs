using Core.Utilities.Results.Abstracts;
using Entities.Concretes.Models;
using System.Collections.Generic;

namespace Business.Abstracts
{
    public interface ICustomerService
    {
        IDataResult<List<Customer>> GetAll();
        IDataResult<Customer> Get(int id);
        IResult Add(Customer customer);
        IResult Delete(Customer customer);
        IResult Update(Customer customer);
    }


}
