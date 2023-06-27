using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Balta.ContentContext
{
    public class Career : Content
    {
        public Career(string title, string url) : base(title, url)
        {
            Items = new List<CareerItem>();
        }
        public IList<CareerItem> Items { get; set; }
        public int TotalCourses => Items.Count; // Expression Body
    }
}
