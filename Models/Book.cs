using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace INF_272_HomeworkAssignment.Models
{
    public class Book
    {
        private string mTitle;
        private string mAuthor;
        private string mNoOfPages;
        private string mLanguage;
        private string path;
        public Book(string title, string author, string noOfpages, string language, string _path)
        {
            mTitle = title;
            mAuthor = author;
            mNoOfPages = noOfpages;
            mLanguage = language;
            path = _path;
        }
        public string PATH
        {
            get { return path; }
            set { path = value; }
        }
        public string Title
        {
            get { return mTitle; }
            set { mTitle = value; }
        }
        public string Author
        {
            get { return mAuthor; }
            set { mAuthor = value; }
        }

        public string NoOfPages
        {
            get { return mNoOfPages; }
            set { mNoOfPages = value; }
        }
        public string Language
        {
            get { return mLanguage; }
            set { mLanguage = value; }

        }
    }


}