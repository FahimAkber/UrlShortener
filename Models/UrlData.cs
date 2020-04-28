namespace UShortener.Models
{
    public class UrlData
    {
        public int  ID{get; set;}   
        public string OriginalUrl{get; set;}
        public string ShortUrl{get; set;}
        public string ShortCode{get; set;}
        public string CreatedAt{get;set;}
    }
}