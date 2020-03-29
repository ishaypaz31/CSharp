using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL29HW
{
    class CustomerDAO : ICustomerDAO
    {
        static SQLiteConnection connection;
        public static string dbName = @"C:\sqllite\db3.db";

        static CustomerDAO()
        {
            connection = new SQLiteConnection($"Data Source = {dbName}; Version=3;");
            connection.Open();
        }

        public static void Close()
        {
            connection.Close();
        }


        public void AddCustomer(Customer c)
        {

            using (SQLiteCommand cmd = new SQLiteCommand($"INSERT INTO CUSTOMER(FIRST_NAME, LAST_NAME, AGE, ADDRESS_CITY," +
                $"ADDRESS_STREET, PH_NUMBER) VALUES ('{c.FirstName}', " +
                $"'{c.LastName}', {c.Age}, '{c.AddressCity}', '{c.AddressStreet}', '{c.PhNumber}')", connection))
            {
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteCustomer(int id)
        {
            using (SQLiteCommand cmd = new SQLiteCommand($"DELETE FROM CUSTOMER WHERE ID = {id}", connection))
            {
                cmd.ExecuteNonQuery();
            }
        }

        public List<Customer> GetAllCustomers()
        {
            List<Customer> customers = new List<Customer>();

            using (SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM CUSTOMER", connection))
            {

                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {

                    while (reader.Read() == true)
                    {

                        Customer c = new Customer
                        {
                            Id = (int)reader["ID"],
                            FirstName = (string)reader["FIRST_NAME"],
                            LastName = (string)reader["LAST_NAME"],
                            Age = (int)reader["AGE"],
                            AddressCity = (string)reader["ADDRESS_CITY"],
                            AddressStreet = (string)reader["ADDRESS_STREET"],
                            PhNumber = (string)reader["PH_NUMBER"]
                        };

                        customers.Add(c);
                    }

                }
            }

            return customers;
        }

        public Customer GetCustomerById(int id)
        {
            using (SQLiteCommand cmd = new SQLiteCommand($"SELECT * FROM CUSTOMER WHERE ID = {id}", connection))
            {

                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {

                    if (reader.Read() == true)
                    {

                        Customer c = new Customer
                        {
                            Id = (int)reader["ID"],
                            FirstName = (string)reader["FIRST_NAME"],
                            LastName = (string)reader["LAST_NAME"],
                            Age = (int)reader["AGE"],
                            AddressCity = (string)reader["ADDRESS_CITY"],
                            AddressStreet = (string)reader["ADDRESS_STREET"],
                            PhNumber = (string)reader["PH_NUMBER"]
                        };

                        return c;
                    }

                }
            }

            return null;
        }

        public Customer GetCustomerByPhoneNumber(string ph)
        {
            using (SQLiteCommand cmd = new SQLiteCommand($"SELECT * FROM CUSTOMER WHERE PH_NUMBER = '{ph}'", connection))
            {

                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {

                    if (reader.Read() == true)
                    {

                        Customer c = new Customer
                        {
                            Id = (int)reader["ID"],
                            FirstName = (string)reader["FIRST_NAME"],
                            LastName = (string)reader["LAST_NAME"],
                            Age = (int)reader["AGE"],
                            AddressCity = (string)reader["ADDRESS_CITY"],
                            AddressStreet = (string)reader["ADDRESS_STREET"],
                            PhNumber = (string)reader["PH_NUMBER"]
                        };

                        return c;
                    }

                }
            }

            return null;
        }



        public List<Customer> GetCustomersBetweenAges(int minAge, int maxAge)
        {
            List<Customer> customers = new List<Customer>();

            using (SQLiteCommand cmd = new SQLiteCommand($"SELECT * FROM CUSTOMER WHERE AGE BETWEEN {minAge} AND {maxAge}", connection))
            {

                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {

                    while (reader.Read() == true)
                    {

                        Customer c = new Customer
                        {
                            Id = (int)reader["ID"],
                            FirstName = (string)reader["FIRST_NAME"],
                            LastName = (string)reader["LAST_NAME"],
                            Age = (int)reader["AGE"],
                            AddressCity = (string)reader["ADDRESS_CITY"],
                            AddressStreet = (string)reader["ADDRESS_STREET"],
                            PhNumber = (string)reader["PH_NUMBER"]
                        };

                        customers.Add(c);
                    }

                }
            }

            return customers;
        }

        public List<Customer> GetCustomersLivingInCity(string city)
        {
            List<Customer> customers = new List<Customer>();

            using (SQLiteCommand cmd = new SQLiteCommand($"SELECT * FROM CUSTOMER WHERE ADDRESS_CITY = '{city}'", connection))
            {

                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {

                    while (reader.Read() == true)
                    {

                        Customer c = new Customer
                        {
                            Id = (int)reader["ID"],
                            FirstName = (string)reader["FIRST_NAME"],
                            LastName = (string)reader["LAST_NAME"],
                            Age = (int)reader["AGE"],
                            AddressCity = (string)reader["ADDRESS_CITY"],
                            AddressStreet = (string)reader["ADDRESS_STREET"],
                            PhNumber = (string)reader["PH_NUMBER"]
                        };

                        customers.Add(c);
                    }

                }
            }

            return customers;
        }

        public void RemoveAllCustomers()
        {
            using (SQLiteCommand cmd = new SQLiteCommand($"DELETE FROM CUSTOMER", connection))
            {
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateCustomer(int id, Customer c)
        {
            using (SQLiteCommand cmd = new SQLiteCommand($"UPDATE CUSTOMER SET ID={c.Id}, FIRST_NAME='{c.FirstName}'," +
                $"LAST_NAME='{c.LastName}', AGE={c.Age}, ADDRESS_CITY='{c.AddressCity}', ADDRESS_STREET='{c.AddressStreet}'" +
                $"PH_NUMBER='{c.PhNumber}' WHERE ID ={id}", connection))
            {
                cmd.ExecuteNonQuery();
            }
        }
    }
}
