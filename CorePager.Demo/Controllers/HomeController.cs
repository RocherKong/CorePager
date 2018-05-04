using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CorePager.Demo.Models;

namespace CorePager.Demo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(int PageIndex, int PageSize=10)
        {
            IEnumerable<OrderModel> list = new List<OrderModel> {
                new OrderModel { OrderNo="20180503001",OrderTime=DateTime.Now,OrderTotalAmount=10000},
                new OrderModel { OrderNo="20180503001",OrderTime=DateTime.Now,OrderTotalAmount=10000},
                new OrderModel { OrderNo="20180503001",OrderTime=DateTime.Now,OrderTotalAmount=10000},
                new OrderModel { OrderNo="20180503001",OrderTime=DateTime.Now,OrderTotalAmount=10000},
                new OrderModel { OrderNo="20180503001",OrderTime=DateTime.Now,OrderTotalAmount=10000},
                new OrderModel { OrderNo="20180503001",OrderTime=DateTime.Now,OrderTotalAmount=10000},
                new OrderModel { OrderNo="20180503001",OrderTime=DateTime.Now,OrderTotalAmount=10000},
                new OrderModel { OrderNo="20180503001",OrderTime=DateTime.Now,OrderTotalAmount=10000},
                new OrderModel { OrderNo="20180503001",OrderTime=DateTime.Now,OrderTotalAmount=10000},
                new OrderModel { OrderNo="20180503001",OrderTime=DateTime.Now,OrderTotalAmount=10000},
                new OrderModel { OrderNo="20180503001",OrderTime=DateTime.Now,OrderTotalAmount=10000},
                new OrderModel { OrderNo="20180503001",OrderTime=DateTime.Now,OrderTotalAmount=10000},
                new OrderModel { OrderNo="20180503001",OrderTime=DateTime.Now,OrderTotalAmount=10000},
                new OrderModel { OrderNo="20180503001",OrderTime=DateTime.Now,OrderTotalAmount=10000},
            };
            IPagedList<OrderModel> OrderList = new PagedList<OrderModel>(list, PageIndex, PageSize, 100);
            return View(OrderList);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
