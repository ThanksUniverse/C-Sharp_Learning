using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Balta.NotificationContext
{
    public sealed class Notification // Downloadable through dotnet add package flunt
    {
        public Notification() { }

        public Notification(string property, string message)
        {
            Property = property;
            Message = message;
        }

        public string Property { get; set; }
        public string Message { get; set; }
    }
}
