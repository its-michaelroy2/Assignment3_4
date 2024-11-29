using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assignment3_4_Coffee_WPF
{
    public static class CoffeeDataSource
    {
        public static List<Coffee> GetInitialCoffees()
        {
            return new List<Coffee>
            {
                new Coffee { Name = "Bob Smith", Price = 3.99, Size = "12oz (S)", RoastLevel = "Dark", HasMilk = false },
                new Coffee { Name = "Alice Johnson", Price = 4.50, Size = "16oz (M)", RoastLevel = "Medium", HasMilk = true },
                new Coffee { Name = "Charlie Brown", Price = 5.25, Size = "20oz (L)", RoastLevel = "Light", HasMilk = false },
                new Coffee { Name = "Donald Trump", Price = 3.75, Size = "16oz (M)", RoastLevel = "Dark", HasMilk = false },
                new Coffee { Name = "Joe Biden", Price = 3.75, Size = "16oz (M)", RoastLevel = "Dark", HasMilk = false }
            };
        }
    }
}