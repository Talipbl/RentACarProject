using Entities.Concretes.Models;
using System.Collections.Generic;

namespace Business.Abstracts
{
    public interface ICustomerService
    {
        List<Customer> GetAll();
        Customer Get(string id);
        void Add(Customer customer);
        void Delete(Customer customer);
        void Update(Customer customer);
    }


}
