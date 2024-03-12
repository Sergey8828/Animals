using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Animals
{
    public abstract class Animal
    {
        public string Continent { get; set; }
        public string Description { get; set; }
        public string Gender { get; set; }
        public string Image { get; set; }
        public string Name { get; set; }
        public string SpeciesName { get; set; }

        public Animal(string continent, string description, string gender, string name, string speciesName)
        {
            Continent = continent;
            Description = description;
            Gender = gender;
           // Image = image;
            Name = name;
            SpeciesName = speciesName;
        }
            public Animal()
        {

        }

        public override string ToString()
        {
            return string.Format($"{this.GetType().Name.ToUpper()} - {Name}");
        }
        public virtual string GetDetail()
        {
            return string.Format($"{Gender} {this.GetType().Name} from {Continent} goes by the name {Name}\nSpecies: {SpeciesName}\n" +
                $"Other Info: {Description}\n");
        }
    }
}