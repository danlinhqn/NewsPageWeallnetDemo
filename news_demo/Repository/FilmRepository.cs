using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using news_demo.Models; // Gọi Model trước khi dùng =>

namespace news_demo.Repository
{
    public class FilmRepository
    {

        EFdataEntities db = new EFdataEntities();

        public List<film> getFilm() // Thực hiện Code LinQ truy xuất dữ liệu tại đây
        {
            List<film> listFilm = (from item in db.films select item).ToList();
            return listFilm;

        }

    }
}