using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidenceTest03
{
    public class GenericAnimal<T> : IGenericAnimal<T>
    {
        public string GetGenericAnimal(T obj)
        {
            string Behavior = string.Empty;
            if (obj is Animal)
            {
                Animal animal = obj as Animal;
                switch (animal.Type)
                {
                    case AnimalType.Mammals:
                        Behavior = "They have four types of teeth, so they can eat a wide range of foods.";
                        break;
                    case AnimalType.Amphibians:
                        Behavior = "Amphibians will pretty much eat anything live that they can fit in their mouths.";
                        break;
                    case AnimalType.Birds:
                        Behavior = "Most Birds naturally eat include insects,plant material,fruit, and nuts.";
                        break;
                    default:
                        Behavior = "Not Found yet! Unknown Behaviour";
                        break;
                }
            }
            else { Behavior = "This is not an Animal"; }
            return Behavior;
        }
    }
}
