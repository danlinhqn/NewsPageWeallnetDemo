using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using news_demo.Models; // Gọi Model trước khi dùng =>

namespace news_demo.Repository
{
    public class NewsTopRepository
    {

        // Khai báo biến trong class trước =>

        EFdataEntities db = new EFdataEntities();

        public List<newsTop> getNewsTop() // Thực hiện Code LinQ truy xuất dữ liệu tại đây
        {
            List<newsTop> listNewsTop = (from item in db.newsTops select item).ToList();
            return listNewsTop;

        }

    }
}