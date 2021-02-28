using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        private static object car;

        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.ColorId);
                Console.WriteLine(car.BrandId);
                Console.WriteLine(car.DailyPrice);
                Console.WriteLine(car.DesCription);
            }
            Console.WriteLine("Hello World!");
        }
    }
}
