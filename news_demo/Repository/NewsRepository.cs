using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using news_demo.Models; // Gọi Model trước khi dùng =>

namespace news_demo.Repository
{
    public class NewsRepository
    {

        // Khai báo biến trong class trước =>

        EFdataEntities db = new EFdataEntities();

        public List<news> getNews()// Thực hiện Code LinQ truy xuất dữ liệu tại đây
        {

            List<news> listNews = (from item in db.news select item).ToList();
            return listNews;

        }

        // Chi Lay 6 tin tuc =>

        public List<news> getNews6value()// Thực hiện Code LinQ truy xuất dữ liệu tại đây
        {

            List<news> listNews6value = (from item in db.news 
                                         where item.id > 1 select item).ToList();
            return listNews6value;

        }

        // Chi Lay 1 tin tuc Chinh =>

        public List<news> getNews1value()// Thực hiện Code LinQ truy xuất dữ liệu tại đây
        {

            List<news> listNews1value = (from item in db.news
                                         where item.id == 1
                                         select item).ToList();
            return listNews1value;

        }



    }
}