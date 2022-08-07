using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndIndexers4
{

    class Store
    {
        private Article[] articles;

        public Store(int size)
        {
            articles = new Article[Math.Abs(size)];
        }

        public string this[int index]
        {
            get
            {
                if (index - 1 >= 0 && index - 1 < articles.Length)
                {
                    return articles[index-1].Info();
                }
                return "You try to reach outside the array. ";
            }
        }
        public void AddArticle(Article value, int index)
        {
            if (index >= 0 && index < articles.Length)
            {
                articles[index] = value;
            }
            else
            {
                Console.WriteLine("You try to add value outside the array. ");
            }
        }
        public string this[string index]
        {
            get
            {
                for (int i = 0; i < articles.Length; i++)
                    if (articles[i].Name == index)
                        return articles[i].Info();
                return string.Format("Cannot find {0}", index);
            }
        }
        public void Show()
        {
            for (int i = 0; i < articles.Length; i++)
                Console.WriteLine(articles[i].Info());
        }

        
    }
}
