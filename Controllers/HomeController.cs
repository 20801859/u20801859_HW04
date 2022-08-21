using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Web.Mvc;
using INF_272_HomeworkAssignment.Models;

namespace INF_272_HomeworkAssignment.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Books()
        {
            var result = "";
            Array tempData = null;
            char[] delimiterChar = { '#' };

            var dataFile = Server.MapPath("~/Media/shortStory.txt");

            if (System.IO.File.Exists(dataFile))
            {
                tempData = System.IO.File.ReadAllLines(dataFile);
                if (tempData == null)
                {
                    // Empty file.
                    result = "The file is empty.";
                }
            }
            else
            {
                // File does not exist.
                result = "The file does not exist.";
            }
            List<ShortStory> stories = new List<ShortStory>();
            foreach (string dataLine in tempData)
            {
                List<string> str = new List<string>();
                foreach (string dataItem in dataLine.Split(delimiterChar))
                {
                    str.Add(dataItem);

                }
                ShortStory sam = new ShortStory(str[0], str[1], str[2], str[3], str[4], str[5],str[6]);
                stories.Add(sam);
            }
            return View(stories);
        }

        public ActionResult About()
        {
        

            return View();
        }

        public ActionResult Contact()
        {
            //ViewBag.Message = "Your contact page.";

            return View();
        }
        public FileResult DownloadFile(string fileName)
        {

            string path = Server.MapPath("~/Media/books/") + fileName;

            byte[] bytes = System.IO.File.ReadAllBytes(path);

            return File(bytes, "application/octet-stream", fileName);
        }
    }
}