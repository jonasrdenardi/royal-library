using RoyalLibrary.Domain.Cache;
using RoyalLibrary.Domain.Entitie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoyalLibrary.Infra.Cache
{
    public class RedisCache : ICache
    {
        public void AddInsertBook(object sender, Book book)
        {
            Console.WriteLine("Send Get Books to Redis");
        }
    }
}
