using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Animals
{
    public class Giraffe : Herbivore
    {
        public double NeckLength { get; set; }

        public Giraffe()
        {
        }
        public Giraffe(string continent, string description, string gender, string name, string speciesName, int foodKgPerWeight, double neckLength)
          : base(continent, description, gender, name, speciesName, foodKgPerWeight)
        {
            NeckLength = neckLength;
        }
        public override string GetDetail()
        {
            return base.GetDetail() + string.Format($"Neck Length: {NeckLength}");
        }
    }
}
