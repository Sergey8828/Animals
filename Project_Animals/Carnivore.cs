using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Animals
{
    public abstract class Carnivore : Animal
    {
        public string KillsWith { get; set; }
        public Carnivore()
        {

        }
        public Carnivore(string continent, string description, string gender, string name, string speciesName, string killsWith)
         : base(continent, description, gender, name, speciesName)
        {
            KillsWith = killsWith;
        }
        public override string GetDetail()
        {
            return base.GetDetail() + string.Format($"Typically kills With {KillsWith}\n");
        }
    }  
}
