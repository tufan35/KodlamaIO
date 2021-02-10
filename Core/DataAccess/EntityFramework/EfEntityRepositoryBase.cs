using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
        //Kurallar
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()

    {
        public void Add(TEntity entity)
        {
            //IDısposable pattern implementaion of c#
            using (TContext context = new TContext())  //bir class newlendiğinde belirli zamanda düenzlenir ve atar
            {
                var addedEntity = context.Entry(entity); //referens yakala
                addedEntity.State = EntityState.Added; //eklenecek nesne
                context.SaveChanges(); //ve ekle
            }
        }

        public void Delete(TEntity entity)
        {
            using (TContext context = new TContext())  //bir class newlendiğinde belirli zamanda düenzlenir ve atar
            {
                var deletedEntity = context.Entry(entity); //referens yakala
                deletedEntity.State = EntityState.Deleted; //silinecek nesne
                context.SaveChanges(); //ve ekle
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context = new TContext())
            {           //Burası Product tablosu
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                //filtre vermemişse hepsini getir filtre varsa belirli listedekileri çek
                return filter == null
                    ? context.Set<TEntity>().ToList()
                    : context.Set<TEntity>().Where(filter).ToList();
            }
        }

        public void Update(TEntity entity)
        {
            using (TContext context = new TContext())  //bir class newlendiğinde belirli zamanda düenzlenir ve atar
            {
                var updatedEntity = context.Entry(entity); //referens yakala
                updatedEntity.State = EntityState.Modified; //güncellenecek nesne
                context.SaveChanges(); //ve ekle
            }
        }
    }
}