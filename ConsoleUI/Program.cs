using Business.Concretes;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concretes.EntityFramework;
using Entities.Concretes.Models;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //BrandTest();
            //AddBrandTest();
            RentalTest();

            Console.ReadKey();
        }

        private static void RentalTest()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            foreach (var item in rentalManager.RentalDetails())
            {
                Console.WriteLine(item.RentId + " / " + item.CustomerName + " / " + item.CarName + " / " + item.RentDate.ToString());
            }
        }

        private static void AddBrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            Brand brand = new Brand
            {
                BrandName = "Tofaş"
            };
            brandManager.Add(brand);
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var item in brandManager.GetAll())
            {
                Console.WriteLine(item.BrandName);
            }
        }
    }
}
