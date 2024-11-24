using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WPF06_
{

    public class Unit
    {
        public static readonly Unit Gram = new Unit("Грам");
        public static readonly Unit Milliliter = new Unit("Миллитров");
        public static readonly Unit Piece = new Unit("Штук");

        public string Name { get; set; }

        public static IReadOnlyList<Unit> All { get; }
            = new List<Unit> { Gram, Milliliter, Piece };

        private Unit(string name)
        {
            Name = name;
        }

        public override string ToString() => Name;

     }
}
