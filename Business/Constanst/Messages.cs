using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constanst
{
    public static class Messages
    {
        public static string ProcessFailed = "İşlem başarısız";
        public static string DataListed = "Veri Listelendi";

        public static class Brand
        {
            public static string Added = "Marka eklendi";
            public static string Deleted = "Marka silindi.";
            public static string Updated = "Marka güncellendi";
            public static string Listed = "Markalar Listelendi";
        }
        public static class Car
        {
            public static string Added = "Araç eklendi";
            public static string Deleted = "Araç silindi.";
            public static string Updated = "Araç güncellendi";
            public static string Listed = "Renkler listelendi";
        }
        public static class CarImage
        {
            public static string CarImageLimitExceed = "Seçilen araç için maksimum resim sayısına ulaşıldı";
        }
        public static class Color
        {
            public static string Added = "Renk eklendi";
            public static string Deleted = "Renk silindi.";
            public static string Updated = "Renk güncellendi";
            public static string Listed = "Renkler listelendi";
        }
        public static class Customer
        {
            public static string Added = "Müşteri eklendi";
            public static string Deleted = "Müşteri silindi.";
            public static string Updated = "Müşteri güncellendi";
            public static string Listed = "Müşteri listelendi";
        }
        public static class Rental
        {
            public static string Added = "Kiralama işlemi eklendi";
            public static string Deleted = "Kiralama işlemi silindi.";
            public static string Updated = "Kiralama işlemi güncellendi";
            public static string Listed = "Kiralama işlemi listelendi";
        }
        public static class Validation
        {
            public static string GreaterThanRentDate = "Teslim tarihi kiralama tarihinden önce olamaz.";
        }
        public static class Error
        {
            public static string EmptyFile = "Seçili dosya yok";
        }
    }
}
