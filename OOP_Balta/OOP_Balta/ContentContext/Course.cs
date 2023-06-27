using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_Balta.ContentContext.Enums;
using OOP_Balta.NotificationContext;

namespace OOP_Balta.ContentContext
{
    public class Course : Content
    {
        public Course(string title, string url, EContentLevel level) : base(title, url)
        {
            if ((EContentLevel)level == null)
                AddNotification(new Notification("Level", "Level invalido"));
            Modules = new List<Module>(); // Sempre inicializar a lista pra evitar nullException
            Level = level;
        }
        public string Tag { get; set; } // 2802
        public IList<Module> Modules { get; set; } // IList abstracao e nunca implementacao
        public int DurationInMinutes { get; set; } // CleanCode
        public EContentLevel Level { get; set; }
    }
}
