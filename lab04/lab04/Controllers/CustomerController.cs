using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Lab04.Models;

namespace lab04.Controllers
{
    public class CustomerController : Controller
    {
        // GET: /Customer/CustomerDetail (action trả về thông tin chi tiết 1 khách hàng cho view CustomerDetail)
        public ActionResult CustomerDetail()
        {
            // Tạo một đối tượng Customer
            Customer cus = new Customer()
            {
                CustomerId = "KH001",
                FullName = "Nguyễn Minh Hiệp",
                Address = "Hà Nội",
                Email = "devmaster.founder@gmail.com",
                Phone = "0978.611.889",
                Balance = 15200000
            };

            // Truyền dữ liệu đến View
            return View(cus);
        }

        // GET /Product/CustomerList (action trả về danh sách khách hàng cho view CustomerList)
        public ActionResult CustomerList()
        {
            // Tạo một danh sách khách hàng
            List<Customer> listcustomer = new List<Customer>()
            {
                new Customer()
                {
                    CustomerId = "KH001",
                    FullName = "Nguyễn Minh Hiệp",
                    Address = "Hà Nội",
                    Email = "devmaster.founder@gmail.com",
                    Phone = "0978.611.889",
                    Balance = 15200000
                },
                new Customer()
                {
                    CustomerId = "KH002",
                    FullName = "Đỗ Thị Cúc",
                    Address = "Hà Nội",
                    Email = "cucdt@gmail.com",
                    Phone = "0986.767.444",
                    Balance = 2200000
                },
                new Customer()
                {
                    CustomerId = "KH003",
                    FullName = "Nguyễn Tuấn Thắng",
                    Address = "Nam Định",
                    Email = "thangnt@gmail.com",
                    Phone = "0924.656.542",
                    Balance = 1200000
                },
                new Customer()
                {
                    CustomerId = "KH004",
                    FullName = "Lê Ngọc Hải",
                    Address = "Hà Nội",
                    Email = "hailn@gmail.com",
                    Phone = "0996.555.267",
                    Balance = 6200000
                }
            };

            // Gán dữ liệu vào ViewBag để chuyển qua View
            ViewBag.listcustomer = listcustomer;

            return View();
        }
    }
}
