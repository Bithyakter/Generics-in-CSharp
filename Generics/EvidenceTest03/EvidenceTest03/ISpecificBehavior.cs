using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidenceTest03
{
    //For Specific Behavior
    public interface ISpecificBehavior<T>
    {
        string GetSpecificBehavior<T>(T data) where T : Animal;
    }
}
