using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
   
    class Interact
    {
        // create a list of customer class that hold the price of each customer
        static ListCustomer listCustomer = new ListCustomer();

        // To calculate and desplay the total price
        float totalPrice = 0;

        // Counts the number of persons
        int count = 0;

        //Check customers age and assign price to the list
        public void setCustomers()
        {
            Console.WriteLine("Enter your age and if their is no more enter " + "0" + ":");

            int age = 1;


            while (age != 0)
            {
             
             
        
             age = int.Parse(Console.ReadLine());
                if (age != 0)
                {

                    if (age > 5 && age < 20)
                    {
                        listCustomer.AddCustomer(80);
                    }else if(age < 5)
                    {
                        listCustomer.AddCustomer(0);
                    }
                    else if (age > 64 && age < 100)
                    {
                        listCustomer.AddCustomer(90);
                    }
                    else if(age > 100)
                    {
                        listCustomer.AddCustomer(0);
                    }
                    else
                    {
                        listCustomer.AddCustomer(120);
                    }

                }

            } 

        }

        // Desplay price list, the number of persons and total price
        public void getCustomerList()
        {
            Console.WriteLine("Hear is the cost per person and the total cost:");

            foreach (var emp in listCustomer.GetCustomers())
            {
                Console.WriteLine(emp.Fee);
                totalPrice += emp.Fee;
                count++;
            }

            Console.WriteLine("Your är " + count + " persons.");
            Console.WriteLine("Total Cost:" + totalPrice);
        }
    }
}
