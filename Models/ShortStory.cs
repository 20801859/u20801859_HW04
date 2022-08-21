using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace INF_272_HomeworkAssignment.Models
{
    public class ShortStory : Book
    {
        private string _PublicationDate;
        private string picPath;
        public ShortStory(string title, string author, string noOfpages, string language, string _path,string _PublicationDate,string _picPath ) : base(title, author, noOfpages, language, _path)
        {
            _PublicationDate = PublicationDate;
            picPath = _picPath;
        }

        public string PublicationDate
        {
            get { return _PublicationDate; }
            set { _PublicationDate = value; }
        }
        public string PicPath
        {
            get { return picPath; }
            set { picPath = value; }
        }
    }
}