using System.ServiceModel;

namespace WebAPISoapService.Models
{
    public class CustomerServiceContract
    {
        [ServiceContract]
        public interface ICustomerService
        {
            [OperationContract]
            CustomerDataContract GetCustomer();
        }
    }
    
}
