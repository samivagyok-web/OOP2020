using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace With_Array
{
    static class Filter
    {
        public static Article[] ByAuthor(Article[] articles, string author)
        {
            List<Article> filteredList = new List<Article>();

            for (int i = 0; i < articles.Length; i++)
            {
                if (articles[i].Authors.Contains(author))
                    filteredList.Add(articles[i]);
            }

            return filteredList.ToArray();
        }

        public static Article[] ByTag(Article[] articles, string tag)
        {
            List<Article> filteredList = new List<Article>();

            for (int i = 0; i < articles.Length; i++)
            {
                if (articles[i].Tag == tag)
                    filteredList.Add(articles[i]);
            }

            return filteredList.ToArray();
        }

        public static Article[] ByDatePosted(Article[] articles, DateTime startDate, DateTime endDate)
        {
            List<Article> filteredList = new List<Article>();

            for (int i = 0; i < articles.Length; i++)
            {
                DateTime dateToCheck = articles[i].DatePosted;

                if (dateToCheck >= startDate && dateToCheck <= endDate)
                    filteredList.Add(articles[i]);
            }

            return filteredList.ToArray();
        }

        public static Article[] PostedOnWeekend(Article[] articles)
        {
            List<Article> filteredList = new List<Article>();

            for (int i = 0; i < articles.Length; i++)
            {
                if (articles[i].DatePosted.DayOfWeek == DayOfWeek.Saturday || articles[i].DatePosted.DayOfWeek == DayOfWeek.Sunday)
                {
                    filteredList.Add(articles[i]);
                }
            }
            return filteredList.ToArray();
        }
    }
}
