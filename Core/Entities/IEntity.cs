using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities

{

    //burada isim belirlerken başına I harfi koyuyoruz. Bu bir interface olduğunu gösteriyor.
    //ve aynı zamanda bize bu bir veritabanı nesnesidir diye işaretleme tekniği ile gösteriyor.
    //yani bunu biz yazlımcıların bir yorumudur.
    //Bu interface'i implement eden classlar bir veritabanı tablosunu temsil ediyor demektir.

    //IEntity i implemente eden class bir veritabanı tablosudur
    public interface IEntity
    {

    }
}
