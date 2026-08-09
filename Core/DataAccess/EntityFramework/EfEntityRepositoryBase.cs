using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;


namespace Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity, TContext>:IEntityRepository<TEntity>  
        where TEntity : class,IEntity, new()
        where TContext : DbContext, new()
    {
        public void Add(TEntity entity)
        {
            //tamamen hız ve performans için using kullanıyoruz
            //bunun amacı using bittiği anda context nesnesini bellekten atmak ve garbage collector tarafından temizlenmesini sağlamak
            using (TContext context = new TContext())
            {
                var addedEntity = context.Entry(entity); //referansı yakala
                addedEntity.State = Microsoft.EntityFrameworkCore.EntityState.Added; //ekleme işlemi yap
                context.SaveChanges(); //değişiklikleri kaydet
            }
        }

        public void Delete(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var deletedEntity = context.Entry(entity); //referansı yakala
                deletedEntity.State = Microsoft.EntityFrameworkCore.EntityState.Deleted; //silme işlemi yap
                context.SaveChanges();
            }


        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter); //filtreye göre tek bir ürün getir
            }

        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>>? filter = null)
        {
            using (TContext context = new TContext())
            {
                //filtre null ise tüm ürünleri getir, filtre varsa filtreye göre getir
                //alttakilerin hepsi yan yana da yazılıyor 
                return filter == null
                    ? context.Set<TEntity>().ToList() //filtre yoksa tüm ürünleri getir
                    : context.Set<TEntity>().Where(filter).ToList(); //filtre varsa filtreye göre getir



            }
        }

        public void Update(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var updatedEntity = context.Entry(entity); //referansı yakala
                updatedEntity.State = Microsoft.EntityFrameworkCore.EntityState.Modified; //güncelleme işlemi yap
                context.SaveChanges();
            }
        }

    }
}
