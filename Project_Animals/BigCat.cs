using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Animals
{
    public class BigCat : Carnivore
    {
        public enum OrganisationType { Solitary, Coalition, Pride }
        public OrganisationType TypeOfOrganisation { get; set; }

        public BigCat()
        {
        }

        public BigCat(string continent, string description, string gender, string name, string speciesName, string killsWith, OrganisationType typeOfOrganisation)
            : base(continent, description, gender, name, speciesName, killsWith)
        {
            TypeOfOrganisation = typeOfOrganisation;
        }
        public override string GetDetail()
        {
            return base.GetDetail() + string.Format($"Organisation Type: {TypeOfOrganisation}");
        }
    }
}
