using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MvcMovie.Models;

namespace MvcMovie.Controllers
{

    public class OrderController : Controller
    {
      
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
          public IActionResult Index( Order model)
        {
             var result = model.Quantity*model.Price;
             ViewBag.Message = $"Bạn {model.FullName} đã mua {model.Quantity} {model.ProductName} có giá {model.Price}đ và tổng tiền là {result} vào ngày{model.CreatedDate.DayOfYear}";
            return View();
        }

        
    }
}