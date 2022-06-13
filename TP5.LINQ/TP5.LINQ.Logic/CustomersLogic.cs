using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP5.LINQ.Entities;

namespace TP5.LINQ.Logic
{
    public class CustomersLogic : BaseLogic
    {
        public string CustomersWithOrders()
        {
            Console.WriteLine($"\tTotal Orders: {_context.Orders.Count()}\n");
            
            var query = from customer in _context.Customers
                        join order in _context.Orders 
                        on customer.CustomerID equals order.CustomerID
                        group customer by customer.CompanyName into customerOrder                        
                        select new
                        { Name = customerOrder.Key ,Orders = customerOrder.Count()};


            string customersData = "";
            foreach (var customer in query)
            {
                customersData += $"{customer}\n";
            }

            return customersData;

        }
        public string FirstThreeWaCustomers()
        {
            var query = _context.Customers.Where(c => c.Region.Equals("WA")).Take(3)
                                          .OrderByDescending(c => c.CustomerID);

            string customersData = "";
            foreach (var customer in query)
            {
                customersData += $" ID){customer.CustomerID} - Name: {customer.ContactName} - " +
                    $"Region: {customer.Region} - City: {customer.City}\n";
            }
            return customersData;
        }
        public string CustomersAndOrder()
        {
            var query = _context.Customers.Where(c => c.Region.Equals("WA"))
                                          .Join(_context.Orders,
                                          c => c.CustomerID,
                                          o => o.CustomerID,
                                          (c, o) => new
                                          {
                                              c.ContactName,
                                              c.Region,
                                              o.OrderID,
                                              o.OrderDate,
                                          })
                                          .Where(o => o.OrderDate > new DateTime(1997, 1, 1));



            string customersData = "";
            foreach (var customer in query)
            {
                customersData += $" Name: {customer.ContactName} Item Region: {customer.Region} " +
                    $"- Order Date: {customer.OrderDate}\n\n";
            }
            return customersData;


        }
        public string customerName()
        {
            var query = from customer in _context.Customers
                        select new
                        {
                            upperName = customer.ContactName.ToUpper(),
                            lowerName = customer.ContactName.ToLower()
                        };

            string customersData = "";
            foreach (var customer in query)
            {
                customersData += $" Nombre Mayuscula: '{customer.upperName}' - " +
                    $"Nombre Minúscula: '{customer.lowerName}'\n";
            }
            return customersData;
        }
        public Customers CustomerById(string id)
        {
            return _context.Customers.Where(c => c.CustomerID.Equals(id)).First();

            //var query = from customer in _context.Customers
            //            where customer.CustomerID == id
            //            select customer;

            //return query.FirstOrDefault();

        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Customers> GetAll()
        {
            return _context.Customers.ToList();
        }

        public void Update(Customers newObject)
        {
            throw new NotImplementedException();
        }

        public string WaCustomers()
        {
            var query = from customer in _context.Customers
                        where customer.Region.Equals("WA")
                        select customer;

            //var query = _context.Customers.Where(c => c.Region.Equals("WA"));

            string datosCustomers = "";

            foreach (var customer in query)
            {
                datosCustomers += $"ID){customer.CustomerID} - Name: {customer.ContactName}" +
                                  $"- City: {customer.City} - Phone: {customer.Phone}\n";
            }
            return datosCustomers;
        }

    }
}
