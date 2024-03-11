using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Animals
{
    public class Bear : Carnivore
    {
        public bool Endangered { get; set; }

        public Bear()
        {
        }

        public Bear(string continent, string description, string gender, string name, string speciesName, string killsWith, bool endangered)
            : base(continent, description, gender, name, speciesName, killsWith)
        {
            Endangered = endangered;
        }
        public override string GetDetail()
        {
            string temp;
            if (Endangered)
            {
                temp = "Yes";
            }
            else
            {
                temp = "No";
            }
            return base.GetDetail() + string.Format($"Endangered: {temp}");
        }
    }
}
