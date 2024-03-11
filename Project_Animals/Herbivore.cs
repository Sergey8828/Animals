using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Animals
{
    
    public class Herbivore : Animal
    {
        public double FoodKgPerWeightKg { get; set; }

        public Herbivore()
        {

        }
        public Herbivore(string continent, string description, string gender, string name, string speciesName, double foodKgPerWeight)
           : base(continent, description, gender, name, speciesName)
        {
            FoodKgPerWeightKg = foodKgPerWeight;
        }
        public override string GetDetail()
        {
            return base.GetDetail() + string.Format($"Typically eats {FoodKgPerWeightKg} of food per kg\n");
        }
    }
}
