using System.Collections.Generic;
using System;
namespace UShortener.Repository
{
    public interface IGenericRepository<T> where T : class
    {
         List<T> allData();
         void generateShortUrl(T obj);
    }
}