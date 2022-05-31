using Microsoft.EntityFrameworkCore;
using Rehber.API.Abstract;
using Rehber.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Rehber.API.Concrate
{
    public class Repository<T, Tcontext> : IRepository<T>
        where Tcontext : DbContext, new()
        where T : BaseEntity, new()
    {
        public void Add(T entities)
        {
            using (Tcontext ctx = new Tcontext())
            {
                
                if(ctx == null)
                {
                    entities.Durum = false;
                    ctx.Entry(entities).State = EntityState.Modified;
                    ctx.SaveChanges();
                }
                entities.Durum = true;
                ctx.Entry(entities).State = EntityState.Added;
                ctx.SaveChanges();
               
            }
        }

        public void Delete(T entities)
        {
            using (Tcontext ctx = new Tcontext())
            {
                entities.Durum = false;
                ctx.Entry(entities).State = EntityState.Modified;
                ctx.SaveChanges();
            }


        }

        public T Get(Expression<Func<T, bool>> filter = null)
        {
            using (Tcontext ctx = new Tcontext())
            {
                return ctx.Set<T>().SingleOrDefault(filter);
            }
        }

        public T GetById(int id)
        {
            return Get(x => x.ID == id);
        }

        public List<T> Getlist(Expression<Func<T, bool>> filter = null)
        {
            using (Tcontext ctx = new Tcontext())
            {
                return filter == null
                     ? ctx.Set<T>().ToList()
                     : ctx.Set<T>().Where(x=>x.Durum==true).Where(filter).ToList();

            }
        }

        public T GetWrong(Expression<Func<T, bool>> filter = null)
        {
            using (Tcontext ctx = new Tcontext())
            {
                return ctx.Set<T>().SingleOrDefault(filter);
            }
        }

        public void Update(T entities)
        {
            using (Tcontext ctx = new Tcontext())
            {
                ctx.Entry(entities).State = EntityState.Modified;
                ctx.SaveChanges();
            }
        }
    }
    
    }

