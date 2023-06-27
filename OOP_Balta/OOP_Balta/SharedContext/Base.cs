using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Balta.NotificationContext
{
    public abstract class Base : Notifiable
    {
        public Base()
        {
            Id = Guid.NewGuid(); // SPOF (Single Point of Failure)
        }
        public Guid Id { get; set; }
    }
}
