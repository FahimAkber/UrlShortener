using UShortener.Models;
using System.Collections.Generic;
using UShortener.Repository;
using System;
using System.Linq;
using System.Globalization;
namespace UShortener.Service
{
    public class UShortenerService : IUShortenerService
    {
        private IGenericRepository<UrlData> genericRepository;
        public UShortenerService(IGenericRepository<UrlData> genericRepository){
            this.genericRepository = genericRepository;
        }
        public void generateShortUrl(string originalUrl){
            
            List<UrlData> alldata = genericRepository.allData();
            UrlData shortUrl =  alldata.Find(i => i.OriginalUrl == originalUrl); 

            if(shortUrl == null){
                // string shortCode = ShortId.Generate(true, true, 8);
                
                string safe =string.Empty;
                Enumerable.Range(48, 75)
                .Where(i => i < 58 || i > 64 && i < 91 || i > 96)
                .OrderBy(o => new Random().Next())
                .ToList()
                .ForEach(i => safe += Convert.ToChar(i));

            
                string shortCode = safe.Substring(1, 8);

                UrlData url = new UrlData();
                url.OriginalUrl = originalUrl;
                url.ShortCode = shortCode;
                url.ShortUrl = shortCode;
                url.CreatedAt = DateTime.Now.ToString();

                genericRepository.generateShortUrl(url);
            }
            
        }
        public List<UrlData> getAllUrl(){
            List<UrlData> allUrl = genericRepository.allData();
            return allUrl;
        }
    }
}