using OOP_Balta.NotificationContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Balta.ContentContext
{
    public class Article : Content
    {
        // Nao tem problema ter classe vazia.
        public Article(string title, string url) : base(title, url) { }
    }
}
