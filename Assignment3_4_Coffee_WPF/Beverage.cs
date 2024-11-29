using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assignment3_4_Coffee_WPF
{
    // Abstract base class for all beverages
    public abstract class Beverage
    {
        // Common properties for all beverages
        public string Name { get; set; }
        public double Price { get; set; }
        public string Size { get; set; }

        // This will provide a description of the specific beverage
        public abstract string GetDescription();
    }
}