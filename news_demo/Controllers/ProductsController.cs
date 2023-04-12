using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using news_demo.Models; // Goi Model truoc khi dung

namespace news_demo.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {

            List<Product> products = new List<Product>() // "Product"
                                                         // => là tên Model gọi
                                                         // => sử dụng command List để dùng
            {
                new Product() { ProductId =1, ProductName="Iphone 1", Price =5000},

                new Product() { ProductId =2, ProductName="Iphone 2", Price =8000}
            };
            //ViewBag.Products = products; // "ViewBag + tên biến mới "

            return View(products); // Lưu giá trị vào View, để gọi sử dụng
                                   // khi viết code có gọi ý khi gọi dữ liệu
        }

        // GET: Videos => Lấy Database của Video
        public ActionResult Videos()
        {
            return View();
        }
    }
}