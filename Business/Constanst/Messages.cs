using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constanst
{
    public static class Messages
    {
        internal static string ProcessFailed = "İşlem başarısız";
        internal static string DataListed = "Veri Listelendi";

        public static class Brand
        {
            internal static string Added = "Marka eklendi";
            internal static string Deleted = "Marka silindi.";
            internal static string Updated = "Marka güncellendi";
            internal static string Listed = "Markalar Listelendi";
        }
        public static class Car
        {
            internal static string Added = "Araç eklendi";
            internal static string Deleted = "Araç silindi.";
            internal static string Updated = "Araç güncellendi";
            internal static string Listed = "Renkler listelendi";
        }
        public static class Color
        {
            internal static string Added = "Renk eklendi";
            internal static string Deleted = "Renk silindi.";
            internal static string Updated = "Renk güncellendi";
            internal static string Listed = "Renkler listelendi";
        }
        public static class Customer
        {
            internal static string Added = "Müşteri eklendi";
            internal static string Deleted = "Müşteri silindi.";
            internal static string Updated = "Müşteri güncellendi";
            internal static string Listed = "Müşteri listelendi";
        }
        public static class Rental
        {
            internal static string Added = "Kiralama işlemi eklendi";
            internal static string Deleted = "Kiralama işlemi silindi.";
            internal static string Updated = "Kiralama işlemi güncellendi";
            internal static string Listed = "Kiralama işlemi listelendi";
        }
        public static class Validation
        {
            public static string GreaterThanRentDate = "Teslim tarihi kiralama tarihinden önce olamaz.";
        }
        public static class Error
        {

        }
    }
}
