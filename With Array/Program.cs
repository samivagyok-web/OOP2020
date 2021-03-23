using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace With_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            TextReader file = new StreamReader("Arcticles.txt");
            int numOfArticles = int.Parse(file.ReadLine());

            Article[] articles = new Article[numOfArticles];

            int j = 0;
            while (file.ReadLine() != null)
            {
                string title = file.ReadLine();

                var authorList = new List<string>();
                string authors = file.ReadLine();

                if (authors.Contains(','))
                {
                    string[] names = authors.Split(',');

                    for (int i = 0; i < names.Length; i++)
                        authorList.Add(names[i].Trim());
                }
                else
                    authorList.Add(authors);

                string content = file.ReadLine();

                DateTime datePosted = DateTime.Parse(file.ReadLine());
                DateTime dateUpdated = DateTime.Parse(file.ReadLine());

                string tag = file.ReadLine();

                articles[j] = new Article(title, content, authorList, datePosted, dateUpdated, tag);
                j++;
            }

            Filter.ByTag(articles, "Sports");
        }
    }
}
