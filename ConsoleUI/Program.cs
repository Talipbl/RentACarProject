using Business.Concretes;
using DataAccess.Concretes.EntityFramework;
using Entities.Concretes.Models;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var item in brandManager.GetAll())
            {
                Console.WriteLine(item.BrandName);
            }
            Console.ReadKey();
            Brand brand = new Brand
            {
                BrandName = "Tofaş"
            };
            brandManager.Add(brand);
            
        }
    }
}
