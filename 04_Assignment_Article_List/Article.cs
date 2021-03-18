using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Assignment_Article_List
{
    class Article
    {
        #region Private Members
        private string title, content, tag;
        private List<string> authors = new List<string>();
        DateTime datePosted, dateLastUpdate;
        private static Random rnd = new Random();
        #endregion

        #region Constructor
        public Article(string title, string content, List<string> authors, DateTime datePosted, DateTime dateLastUpdate, string tag)
        {
            this.title = title;
            this.content = content;
            this.authors = authors;
            this.datePosted = datePosted;
            this.dateLastUpdate = dateLastUpdate;
            this.tag = tag;
        }
        #endregion

        #region Likes/Dislikes
        private int likes { get; } = rnd.Next(0, 10000);
        private int dislikes { get; } = rnd.Next(0, 10000);
        #endregion

        #region Properties
        public string Title { get { return title; } }
        public string Content { get { return content; } }
        public DateTime DatePosted { get { return datePosted; } }
        public DateTime DateLastUpdate { get { return dateLastUpdate; } }
        #endregion

        public string returnAuthorsInString()
        {
            string auth = "";

            for (int i = 0; i < authors.Count - 1; i++)
                auth += authors[i] + ", ";
            auth += authors[authors.Count - 1];

            return auth;
        }

        public override string ToString()
        {
            return $"{title} by {returnAuthorsInString()} \nDate Posted: {datePosted}\n\n{content}\n\n";
        }
    }
}
