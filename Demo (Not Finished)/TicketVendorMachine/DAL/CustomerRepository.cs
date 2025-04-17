using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class CustomerRepository
    {
        private readonly MainDbContext _context;
        public CustomerRepository()
        {
            _context = new MainDbContext();
        }
        public void AddCustomer(Customer customer)
        {
            _context.Customer.Add(customer);
            _context.SaveChanges();
        }
        public Customer GetCustomerById(int customerId)
        {
            return _context.Customer.Find(customerId);
        }
        public List<Customer> GetAllCustomers()
        {
            return _context.Customer.ToList();
        }
        public void UpdateCustomer(Customer customer)
        {
            _context.Entry(customer).State = EntityState.Modified;
            _context.SaveChanges();
        }
        public void DeleteCustomer(int customerId)
        {
            var customer = GetCustomerById(customerId);
            if (customer != null)
            {
                _context.Customer.Remove(customer);
                _context.SaveChanges();
            }
        }
    }
}
