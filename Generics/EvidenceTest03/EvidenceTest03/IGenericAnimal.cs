using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidenceTest03
{
    public interface IGenericAnimal<T>
    {
        string GetGenericAnimal(T obj);
    }
}
