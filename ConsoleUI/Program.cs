using Business.Concrete;
using DataAccess.Concrete.CarDatabase;

namespace ConsoleUI;
class Program
{
    static void Main(string[] args)
    {
        CarManager carManager = new CarManager(new EfCarDal());
        foreach (var car in carManager.GetCarDetails())
        {
            Console.WriteLine
                (car.CarName+"---"+car.BrandName+"---"
                +car.ColorName+"---"+car.ColorName+"---"+car.DailyPrice+"---");
        }
    }
}
