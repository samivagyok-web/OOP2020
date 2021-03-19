using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Assignment_Article_List
{
    static class Filter
    {
        public static List<Article> ByAuthor(List<Article> articles, string author)
        {
            List<Article> filteredList = new List<Article>();

            for (int i = 0; i < articles.Count; i++)
            {
                if (articles[i].Authors.Contains(author))
                    filteredList.Add(articles[i]);
            }

            return filteredList;
        }

        public static List<Article> ByTag(List<Article> articles, string tag)
        {
            List<Article> filteredList = new List<Article>();

            for (int i = 0; i < articles.Count; i++)
            {
                if (articles[i].Tag == tag)
                    filteredList.Add(articles[i]);
            }

            return filteredList;
        }

        public static List<Article> ByDatePosted(List<Article> articles, DateTime startDate, DateTime endDate)
        {
            List<Article> filteredList = new List<Article>();

            for (int i = 0; i < articles.Count; i++)
            {
                DateTime dateToCheck = articles[i].DatePosted;

                if (dateToCheck >= startDate && dateToCheck <= endDate)
                    filteredList.Add(articles[i]);
            }

            return filteredList;
        }

        public static List<Article> PostedOnWeekend(List<Article> articles)
        {
            List<Article> filteredList = new List<Article>();

            for (int i = 0; i < articles.Count; i++)
            {
                if (articles[i].DatePosted.DayOfWeek == DayOfWeek.Saturday || articles[i].DatePosted.DayOfWeek == DayOfWeek.Sunday)
                {
                    filteredList.Add(articles[i]);
                }
            }
            return filteredList;
        }
    }
}
