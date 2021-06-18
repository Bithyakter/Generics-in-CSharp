using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidenceTest03
{
    public class SpecificAnimal<T> : ISpecificBehavior<T>
    {
        //For Specific Behavior
        public string GetSpecificBehavior<T>(T data) where T : Animal
        {
            string Behavior = string.Empty;
            switch (data.Type)
            {
                case AnimalType.Mammals:
                    Behavior = "Mammals have a relatively large brain and a high level of intelligence.";
                    break;
                case AnimalType.Amphibians:
                    Behavior = "All amphibians are vertebrates, and they need moist environments or water to survive.";
                    break;
                case AnimalType.Birds:
                    Behavior = "Birds belong to the phylum Chordata and are in the class of Aves.";
                    break;
                default:
                    Behavior = "Not Found yet! Unknown Behaviour";
                    break;

            }
            return Behavior;
        }
    }

}
