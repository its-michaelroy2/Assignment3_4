using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assignment3_4_Coffee_WPF
{
    // Coffee class inherit from Beverage class
    public class Coffee : Beverage
    {
        // Additional for Coffee
        public string RoastLevel { get; set; }
        public bool HasMilk { get; set; }

        // Provides a detailed description of the coffee
        public override string GetDescription()
        {
            return $"{Name} - {Size} - ${Price:F2} - Roast: {RoastLevel} - Milk: {(HasMilk ? "Yes" : "No")}";
        }
    }
}
