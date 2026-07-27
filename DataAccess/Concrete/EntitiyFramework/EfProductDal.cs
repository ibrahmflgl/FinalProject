using DataAccess.Apstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntitiyFramework
{
    public class EfProductDal : IProductDal
    {
        public void Add(Product entitiy)
        {
            //tamamen hız ve performans için using kullanıyoruz
            //bunun amacı using bittiği anda context nesnesini bellekten atmak ve garbage collector tarafından temizlenmesini sağlamak
            using (NorthwindContext context = new NorthwindContext())
            {
               var addedEntity = context.Entry(entitiy); //referansı yakala
                addedEntity.State = Microsoft.EntityFrameworkCore.EntityState.Added; //ekleme işlemi yap
                context.SaveChanges(); //değişiklikleri kaydet
            }
        }

        public void Delete(Product entitiy)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var deletedEntity = context.Entry(entitiy); //referansı yakala
                deletedEntity.State = Microsoft.EntityFrameworkCore.EntityState.Deleted; //silme işlemi yap
                context.SaveChanges(); 
            }


        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return context.Set<Product>().SingleOrDefault(filter); //filtreye göre tek bir ürün getir
            }

        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                //filtre null ise tüm ürünleri getir, filtre varsa filtreye göre getir
                //alttakilerin hepsi yan yana da yazılıyor 
                return filter == null
                    ? context.Set<Product>().ToList() //filtre yoksa tüm ürünleri getir
                    : context.Set<Product>().Where(filter).ToList(); //filtre varsa filtreye göre getir

            }
        }

        public void Update(Product entitiy)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var updatedEntity = context.Entry(entitiy); //referansı yakala
                updatedEntity.State = Microsoft.EntityFrameworkCore.EntityState.Modified; //güncelleme işlemi yap
                context.SaveChanges();
            }
        }
    }
}
