using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace INF_272_HomeworkAssignment.Models
{
    public class Magazine : Book
    {
        private bool _hasPictures;


        public Magazine(string title, string author, string noOfpages, string language, bool hasPictures, string _path) :base(title,author,noOfpages,language, _path)
        {
            _hasPictures = hasPictures;
        }

        public bool hasPictures
        {
            get { return _hasPictures; }
            set { _hasPictures = value; }
        }
    }
}
