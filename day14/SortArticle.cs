using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day14
{
    class SortArticle : IComparer<Article>
    {
        public int Compare(Article article, Article article1)
        {
            if (article.NameOfArticle.Length > article1.NameOfArticle.Length) return 1;
            else if (article.NameOfArticle.Length < article1.NameOfArticle.Length) return -1;
            else return 0;
        }
        //public int Compare(Article article, Article article1)
        //{
        //    if (article.SecondNameOfAuthor.Length > article1.SecondNameOfAuthor.Length) return 1;
        //    else if (article.SecondNameOfAuthor.Length < article1.SecondNameOfAuthor.Length) return -1;
        //    else return 0;
        //}
    }
    class SortArticleName : IComparer<Article>
    {
        public int Compare(Article article, Article article1)
        {
            if (article.NameOfArticle.Length > article1.NameOfArticle.Length) return 1;
            else if (article.NameOfArticle.Length < article1.NameOfArticle.Length) return -1;
            else return 0;
        }
    }
    class SortArticalSurName : IComparer<Article>
    {
        public int Compare(Article article, Article article1)
        {
            if (article.SecondNameOfAuthor.Length > article1.SecondNameOfAuthor.Length) return 1;
            else if (article.SecondNameOfAuthor.Length < article1.SecondNameOfAuthor.Length) return -1;
            else return 0;
        }
    }
    class SortArticleRate : IComparer<Article>
    {
        public int Compare(Article article, Article article1)
        {
            if (article.Rating > article1.Rating) return 1;
            else if (article.Rating < article1.Rating) return -1;
            else return 0;
        }
    }
}
