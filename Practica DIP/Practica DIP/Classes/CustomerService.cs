using Practica_DIP.Interfaces;


namespace Practica_DIP.Classes
{
    public class CustomerService
    {
        private readonly ICustomerRepository customerRepository;

        public CustomerService(ICustomerRepository customerRepository) {
            
            this.customerRepository = customerRepository;
        }
    }
}
