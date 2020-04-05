using Microsoft.AspNetCore.Mvc;
using shop_tutorial.Data.interfaces;
using shop_tutorial.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shop_tutorial.Controllers
{
    public class CarsController : Controller
    {
        private readonly IAllCars _allCars;
        private readonly ICarsCategory _allCategories;

        public CarsController(IAllCars iAllCars, ICarsCategory iCarsCat) // конструктор
        {
            _allCars = iAllCars;
            _allCategories = iCarsCat;
        }

        public ViewResult List()
        {
            ViewBag.Title = "Список всех машин";
            CarsListViewModel obj = new CarsListViewModel(); // создаем объект с данными, который передаем на страницу. Для объекта создаем новый ViewModel
            obj.AllCars = _allCars.Cars;
            obj.CurrCategory = "Автомобили";

            return View(obj);
        }
    }
}
