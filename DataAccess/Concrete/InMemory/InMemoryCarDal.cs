using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal 
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car { Id = 1, BrandId = 1, ColorId = 1, ModelYear=2015, DailyPrice=580000, Description="Led farlar"},
                new Car { Id = 2, BrandId = 1, ColorId = 1, ModelYear=2011, DailyPrice=160000, Description="Dijital ekran"},
                new Car { Id = 3, BrandId = 1, ColorId = 2, ModelYear=2019, DailyPrice=750000, Description="Çelik jant"},
                new Car { Id = 4, BrandId = 1, ColorId = 3, ModelYear=2022, DailyPrice=890000, Description="Hidrolik direksiyon"},
                new Car { Id = 5, BrandId = 1, ColorId = 2, ModelYear=2020, DailyPrice=850000, Description="Koltuk ısıtması"}
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(p=>p.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public Car GetById(int id)
        {
            return _cars.Where(c => c.Id == id).First();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c=> c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
