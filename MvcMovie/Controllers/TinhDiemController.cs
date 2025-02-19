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
    public class TinhDiemController : Controller
    {
       
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
         public IActionResult Index(TinhDiem model)
        {
            var result = model.DiemA*0.6 + model.DiemB * 0.3 + model.DiemC *0.1;
            if(result<5){
                ViewBag.Message = $"Bạn {model.FullName} có két quả là {result} với điểm thành phần A:{model.DiemA},B:{model.DiemB},C:{model.DiemC} và trượt môn";
            }
            else
            if(result>=5&& result<6.5){
                ViewBag.Message = $"Bạn {model.FullName} có két quả là {result} với điểm thành phần A:{model.DiemA},B:{model.DiemB},C:{model.DiemC} và TRUNG BÌNH";
            }
            else
            if(result>=6.5 && result<8){
                ViewBag.Message = $"Bạn {model.FullName} có két quả là {result} với điểm thành phần A:{model.DiemA},B:{model.DiemB},C:{model.DiemC} và kHÁ";
            }
            else {
                ViewBag.Message = $"Bạn {model.FullName} có két quả là: {result} với điểm thành phần A:{model.DiemA},B:{model.DiemB},C:{model.DiemC} và giỏi";

            }
            return View();
        }

    }
}