using RoyalLibrary.Domain.Entitie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoyalLibrary.Domain.Notification
{
    public interface INotification
    {
        public void SendInsertBook(object sender, Book book);
    }
}
