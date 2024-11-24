using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF06_
{
    
    public class Product
    {
        public string Name { get; set; }
        public decimal Count { get; set; }
        public Unit Unit { get; set; }

        public Product(string name, Unit measureUnit, decimal price)
        {
            Name = name;
            Unit = Unit;
            Count = Count;
        }

        public Product()
        {
            Name = "Лак";
            Unit = Unit.Milliliter;
            Count = 10;
        }

       

        public Product(Product p)
        {
            Name = p.Name;
            Unit = p.Unit;
            Count = p.Count;

        }

        private static IReadOnlyList<Unit> allUnits = Unit.All;
        public IReadOnlyList<Unit> AllUnits => allUnits;

    }
}
