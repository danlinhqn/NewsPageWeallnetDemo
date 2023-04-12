using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using news_demo.Models; // Gọi Model trước khi dùng =>

namespace news_demo.Repository
{
    public class VideoRepository
    {

        // Khai báo biến trong class trước =>

        EFdataEntities db = new EFdataEntities();
        
        public List<video> getVideo() // Thực hiện Code LinQ truy xuất dữ liệu tại đây
        {
            List<video> listVideo = (from item in db.videos select item).ToList();
            return listVideo;

        }

    }
}