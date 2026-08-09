
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    //core katmanı kimseye referans almamalı cünkü amac bağımsız calışan bir yapı kurmak 


    //generic constraint 
    //class: reference type olabilir demek 
    //IEntitiy: IEntitiy olabilir demek veya IEntitiy implemente eden bir nesne olabilir demek
    //new(): new'lenebilir olmalı demek normalde IEntitiy new'lenemez interface olduğu için ama new() ile bunu kısıtlıyoruz.

    public interface IEntityRepository<T> where T : class, IEntity, new()
    {

        List<T> GetAll(Expression<Func<T, bool>>? filter = null);

        T Get(Expression<Func<T, bool>> filter);

        void Add(T entitiy);
        void Update(T entitiy);
        void Delete(T entitiy);
        


    }
}
