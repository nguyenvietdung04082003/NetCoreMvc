using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Models
{
    public class Order
    {
    public string?  FullName{get;set;}
    public string  ProductName{get;set;}
    public int  Price{get;set;}
    public int  Quantity{get;set;}
    public DateTime  CreatedDate{get;set;} = DateTime.Now;
    }
}