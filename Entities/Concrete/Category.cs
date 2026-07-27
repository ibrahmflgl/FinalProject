using Entities.Apstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{

    //bir kuralımız vardı bir class çıplak kalmasın ilerde büyüdüğü zaman sorun yaşamamak için.
    //Bu yüzden bir interface oluşturuyoruz.
    //varlıklarımızı(entity) temsil eden classlar için bir interface oluşturuyoruz.işaretleme eğilimine gitmeliyiz
    //bu sebep ile Apstract katmanında IEntitiy adında bir interface oluşturuyoruz. Ve bu interface'i implement ediyoruz.
    //deriz ki bu class bir veritabanı tablosunu temsil ediyor. 
    //apstract a gidip bir işaretleme tekniği olan IEntitiy interface'ini oluşturuyoruz. Ve bu interface'i implement ediyoruz.
    public class Category : IEntitiy
    {
        public int CategoryId { get; set; }
        public string? CategoryName { get; set; }

    }
}
