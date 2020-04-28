using UShortener.Models;
using System.Linq;
using System.Collections.Generic;
using System;
using Microsoft.EntityFrameworkCore;

namespace UShortener.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        public DbUrlContext db;
        private DbSet<T> table;

        public GenericRepository(){
           db  = new DbUrlContext();
           table = db.Set<T>();
        }
        public List<T> allData(){
            return table.ToList();
        }

        public void generateShortUrl(T obj){
            db.Add(obj);
            db.SaveChanges();
        }
    }
} 