using System.Collections.Generic;

namespace Cinema
{
    class ListCustomer
    {
        private List<Customer> listCustomer;

        public ListCustomer()
        {
            listCustomer = new List<Customer>();
        }
        //  Add customer members to the List
        public void AddCustomer(float fee)
        {

            Customer customer = new Customer(fee);
            listCustomer.Add(customer);
        }
        // Returns List
        public List<Customer> GetCustomers()
        {
            return listCustomer;
        }
    }
} 