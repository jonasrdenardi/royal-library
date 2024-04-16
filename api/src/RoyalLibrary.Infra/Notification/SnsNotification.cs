using RoyalLibrary.Domain.Entitie;
using RoyalLibrary.Domain.Notification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoyalLibrary.Infra.Notification
{
    public class SnsNotification : INotification
    {
        public void SendInsertBook(object sender, Book book)
        {
            Console.WriteLine("Send Get Books to SNS");
        }
    }
}
