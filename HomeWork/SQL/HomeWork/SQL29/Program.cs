using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL29HW
{
    class Program
    {

        static void Main(string[] args)
        {

            CustomerDAO dao = new CustomerDAO();

            Customer c = new Customer
            {
                Id = 6,
                FirstName = "Ronen",
                LastName = "Haim",
                Age = 33,
                AddressCity = "Rishon le zion",
                AddressStreet = "Hertzel",
                PhNumber = "03-9644196"
            };
            dao.GetAllCustomers();
            List<Customer> customers = dao.GetAllCustomers();
            dao.GetAllCustomers();

            Customer c3 = dao.GetCustomerByPhoneNumber("03-9644196");

            List<Customer> customersAges = dao.GetCustomersBetweenAges(20, 30);

            List<Customer> customersCity = dao.GetCustomersLivingInCity("Tel Aviv");

            //dao.RemoveAllCustomers();

            List<Customer> customers2 = dao.GetAllCustomers();
            CustomerDAO.Close();
        }

    }

}
