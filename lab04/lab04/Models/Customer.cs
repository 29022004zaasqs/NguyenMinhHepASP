using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Lab04.Models; 

namespace Lab04.Models
{
    public class Customer
    {
        public string CustomerId { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int Balance { get; set; }
    }
    //định nghĩa giao diện khách hàng
    public interface ICustomerRepository
    {
        //khai báo phương thức lấy danh sách khách hàng
        IList<Customer> GetCustomers();
        //khai báo phương thức lấy khách hàng
        Customer GetCustomer(string customerId);
        //khai báo phương thức thêm khách hàng
        void AddCustomer(Customer cus);
        //khai báo phương thức cập nhật khách hàng
        void UpdateCustomer(Customer cus);
        //khai báo phương thức tìm kiếm khách hàng
        IList<Customer> SearchCustomer(string name);
        //khai báo phương thức xóa khách hàng
        void DeleteCustomer(Customer cus);
    }
}
