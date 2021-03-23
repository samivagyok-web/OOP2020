﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace With_Array
{
    static class Sort
    {
        public static List<Article> Chronologically(List<Article> articles)
        {
            articles.Sort((x, y) => DateTime.Compare(x.DatePosted, y.DatePosted));
            return articles;
        }

        public static List<Article> LikeDislikes(List<Article> articles)
        {
            articles.Sort((x, y) => ((double)(y.Likes / y.Dislikes)).CompareTo((double)(x.Likes / x.Dislikes)));
            return articles;
        }

        public static void AuthorPostings(List<Article> articles)
        {
            Dictionary<string, int> authors = new Dictionary<string, int>();

            for (int i = 0; i < articles.Count; i++)
            {
                for (int j = 0; j < articles[i].Authors.Count; j++)
                {
                    if (!authors.ContainsKey(articles[i].Authors[j]))
                        authors.Add(articles[i].Authors[j], 1);
                    else
                        authors[articles[i].Authors[j]]++;
                }
            }

            var sortedDict = from author in authors orderby author.Value descending select author;

            foreach (var element in sortedDict)
                Console.WriteLine(element);
        }
    }
}
