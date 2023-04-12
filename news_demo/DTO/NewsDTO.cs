using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using news_demo.Models;

namespace news_demo.DTO
{

    // Tại đây gộp nhiều Data dữ liệu cần lấy vào 1 Biến DTO =>
    public class NewsDTO
    {
        public List<video> listVideo;
        public List<film> listFilm;
        public List<news> listNews;
        public List<news> listNews6value;
        public List<news> listNews1value;
        public List<newsTop> listNewsTop;
        

        public NewsDTO(List<video> listVideo, List<film> listFilm
            , List<news> listNews, List<news> listNews6value
            , List<news> listNews1value,
            List<newsTop> listNewsTop)
        {
            this.listVideo = listVideo;
            this.listFilm = listFilm;
            this.listNews = listNews;
            this.listNews6value = listNews6value;
            this.listNews1value = listNews1value;
            //
            this.listNewsTop = listNewsTop;

        }
    }
}