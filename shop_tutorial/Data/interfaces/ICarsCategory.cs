using shop_tutorial.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shop_tutorial.Data.interfaces
{
    public interface ICarsCategory
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
