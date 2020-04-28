using Microsoft.AspNetCore.Mvc;
using UShortener.Models;
using UShortener.Service;
using System.Collections.Generic;
namespace UShortener.Controllers
{
    public class UrlController : Controller
    {
        private IUShortenerService uShortenerService;
        public UrlController(IUShortenerService uShortenerService){
            this.uShortenerService = uShortenerService;
        }
        [HttpGet]
        public IActionResult index(string url){
            List<UrlData> allUrl = uShortenerService.getAllUrl();
            UrlData getUrl = allUrl.Find(i => i.ShortUrl == url);

            if(getUrl== null){
                return View(allUrl);
            }

           return Redirect("http://"+getUrl.OriginalUrl);
            
        }
        [HttpPost]
        public IActionResult shortUrl(string url){
            uShortenerService.generateShortUrl(url);
            return Redirect("index");
        }
    }
}