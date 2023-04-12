using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using news_demo.Models; // Goi Model truoc khi dung
using news_demo.Repository;
using news_demo.DTO;

namespace news_demo.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        // Thêm URL => NEWS

        // Edit code from Repository File => NewDTO => Controller =>

        public ActionResult News()
        {
            // Gọi dữ liệu getVideo từ Repository

            VideoRepository videoRepository = new VideoRepository();
             List<video> listVideo = videoRepository.getVideo();

            // Gọi hàm  getFilm from VideoRepository

            FilmRepository filmRepository = new FilmRepository();
            List<film> listFilm = filmRepository.getFilm();

            // Gọi hàm  listNews from VideoRepository

            NewsRepository newsResponsitory = new NewsRepository();
            List<news> listNews = newsResponsitory.getNews();

            // Gọi hàm  listNews6Value from VideoRepository

            List<news> listNews6value = newsResponsitory.getNews6value();

            // Gọi hàm  listNews1Value from VideoRepository

            List<news> listNews1value = newsResponsitory.getNews1value();

            // Gọi hàm  listNewsTop from VideoRepository

            NewsTopRepository newsTopRepository = new NewsTopRepository();
            List<newsTop> listNewsTop = newsTopRepository.getNewsTop();


            // Return ra kết quả =>

            NewsDTO newsDTO = new NewsDTO(listVideo, listFilm, listNews
                , listNews6value, listNews1value,listNewsTop);

            return View(newsDTO);

        }
    }

   
}