using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_Balta.NotificationContext;

namespace OOP_Balta.ContentContext
{
    public abstract class Content : Base
    {
        public Content(string title, string url)
        {
            Title = title;
            Url = url;
        }
        public string Title { get; set; }
        public string Url { get; set; }
    }
}
