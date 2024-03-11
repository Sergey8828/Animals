using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Animals
{
    public class Elephant : Herbivore
    {
        public enum TypeOfElephant { African, Asian }
        public TypeOfElephant ElephantType { get; set; }
        public double TuskLength { get; set; }

        public Elephant()
        {
        }

        public Elephant(string continent, string description, string gender, string name, string speciesName, int foodKgPerWeight, TypeOfElephant elephantType, double tuskLength)
            : base(continent, description, gender, name, speciesName, foodKgPerWeight)
        {
            ElephantType = elephantType;
            TuskLength = tuskLength;
        }
        public override string GetDetail()
        {
            return base.GetDetail() + string.Format($"Tusk Length: {TuskLength}\nElephant Type: {ElephantType}");
        }

    }
}
