using UShortener.Models;
using System.Collections.Generic;
namespace UShortener.Service
{
    public interface IUShortenerService
    {
         void generateShortUrl(string url);
         List<UrlData> getAllUrl();
         
    }
}