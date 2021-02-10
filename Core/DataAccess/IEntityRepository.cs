//CORE KATMANI DİĞER KATMANLARI REFERANS ALMAZ
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Core.DataAccess
{
    //generic constraint
    // class : referans tip olabilir demek
    //sadece referans olan .cs leri getirme zorunluluğu
    // IEntity = IEntity olabilir yada IEntity implemente eden bir nesne olabilir.
    //new() :
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null); //filtreleme Burası filtreme yazmamızı sağlar ürünleri şunlara göre listele gibi

        T Get(Expression<Func<T, bool>> filter); //tek bir sorgu getirir

        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);

        //   List<T> GetAllByCategory(int cagtegoryId); //filtreme yapılan alan
    }
}