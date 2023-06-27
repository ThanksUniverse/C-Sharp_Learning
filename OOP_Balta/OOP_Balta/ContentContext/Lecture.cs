using OOP_Balta.ContentContext.Enums;
using OOP_Balta.NotificationContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Balta.ContentContext
{
    public class Lecture : Base
    {
        public int Order { get; set; }
        public string Title { get; set; }
        public int DurationInMinutes { get; set; } // CleanCode
        public EContentLevel Level { get; set; }
    }
}
