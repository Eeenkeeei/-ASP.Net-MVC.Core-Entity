using shop_tutorial.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shop_tutorial.Data.interfaces
{
    public interface IAllCars
    {
        IEnumerable<Car> Cars { get;}
        IEnumerable<Car> GetFavCars { get; set; }
        Car GetObjectCar(int carId);
    }
}
