using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    //constants sabitler demek ve bu sabitleri bir class ın içine koyuyoruz
    //static class ise bu class ın new lenemeyeceğini ve sadece içindeki
    //değerlerin kullanılabileceğini gösterir

    //productAdded ne demek? Ürün eklendi demek.
    //ProductNameInvalid ne demek? Ürün ismi geçersiz demek.
    //MaintenanceTime ne demek? Sistem bakımda demek.
    //ProductsListed ne demek? Ürünler listelendi demek.

    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string ProductsListed = "Ürünler listelendi";
    }
}
