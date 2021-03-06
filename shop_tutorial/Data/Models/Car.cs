﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shop_tutorial.Data.Models
{
    public class Car
    {
        public int Id { set; get; }

        public string Name { set; get; }

        public string ShortDesc { set; get; }

        public string LongDesc { set; get; }

        public string Img { set; get; }

        public ushort Price { set; get; } // тип данных u - не может быть отрицательным

        public bool IsFavourite { set; get; }

        public bool Available { set; get; }

        public int CategoryID { set; get; }

        public virtual Category Category { set; get; }
    }
}
