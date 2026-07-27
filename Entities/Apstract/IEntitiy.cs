using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Apstract
{
    //IEntitiy implemente eden class bir veritabanı tablosudur
    //burada isim belirlerken başına I harfi koyuyoruz. Bu bir interface olduğunu gösteriyor.
    //ve aynı zamanda bize bu bir veritabanı nesnesidir diye işaretleme tekniği ile gösteriyor.
    //yani bunu biz yazlımcıların bir yorumudur.
    //Bu interface'i implement eden classlar bir veritabanı tablosunu temsil ediyor demektir.

    public interface IEntitiy
    {
    }
}
