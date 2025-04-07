using WebAPISoapService.Models;
using static WebAPISoapService.Models.CustomerServiceContract;

namespace WebAPISoapService.Services
{
    public class CustomerService : ICustomerService
    {
        public CustomerDataContract GetCustomer()
        {
            var customer = new CustomerDataContract();
            
            return new CustomerDataContract()
            {
                Id = 1,
                FirstName = "Test",
                LastName = "Test",
                EmailAddress = "aaa@bbb.ccc"
            };
        }
    }
}
