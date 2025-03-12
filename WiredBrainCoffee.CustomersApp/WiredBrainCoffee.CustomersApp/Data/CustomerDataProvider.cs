using System.Collections.Generic;
using System.Threading.Tasks;
using WiredBrainCoffee.CustomersApp.Model;

namespace WiredBrainCoffee.CustomersApp.Data
{
    public interface ICustomerDataProvider
    {
        Task<IEnumerable<Customer>?> GetAllAsync();
    }

    public class CustomerDataProvider : ICustomerDataProvider
    {
        public async Task<IEnumerable<Customer>> GetAllAsync()
        {
            await Task.Delay(100);

            return new List<Customer>
            {
                new Customer{Id = 1, FirstName="Julia", LastName="Cristina", IsDeveloper=true},
                new Customer{Id = 2, FirstName="Alex", LastName="Rider"},
                new Customer{Id = 3, FirstName="Thomas Claudius", LastName="Huber",IsDeveloper=true},
                new Customer{Id = 4, FirstName="Anna", LastName="Rock"},
                new Customer{Id = 5, FirstName="Victor", LastName="Top"},
                new Customer{Id = 6, FirstName="Ben", LastName="Ronaldo"},
            };
        }
    }
}