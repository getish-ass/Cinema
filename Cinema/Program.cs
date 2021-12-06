using System;

namespace Cinema
{
    class Program
    {

        static void Main(string[] args)
        {
           
            
            Interact interact = new Interact();

            //Set the prices to the List
            interact.setCustomers();

            //Desplay prices
            interact.getCustomerList();

        }


    }
}