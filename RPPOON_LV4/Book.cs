using System;
using System.Collections.Generic;
using System.Text;

namespace RPPOON_LV4
{
    class Book : IRentable
    {
        private readonly double BaseBookPrice = 3.99;
        public String Title { get; private set; }
        public Book(String name) { this.Title = name; }
        public string Description { get { return this.Title; } }
        public double CalculatePrice() { return BaseBookPrice; }
    }
}
