using shop_tutorial.Data.interfaces;
using shop_tutorial.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shop_tutorial.Data.mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory _categoryCars = new MockCategory();
        public IEnumerable<Car> Cars { 
            get {
                return new List<Car>
                {
                    new Car {Name = "Tesla", ShortDesc = "короткое описание теслы", LongDesc = "длинное описание теслы", Img = "", Price = 45000, IsFavourite = true, Available = true, Category = _categoryCars.AllCategories.First()},
                    new Car {Name = "BMW", ShortDesc = "короткое описание BMW", LongDesc = "длинное описание BMW", Img = "", Price = 30000, IsFavourite = true, Available = true, Category = _categoryCars.AllCategories.Last()}
                };
            }
        }
        public IEnumerable<Car> GetFavCars { get; set; }

        public Car GetObjectCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
