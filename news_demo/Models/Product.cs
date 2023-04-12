using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace news_demo.Models

{
    // Tạo 1 Model chứa cấu trúc dữ liệu sẽ truy xuất từ Database
    public class Product
    {
        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public double Price { get; set; }

    }


}