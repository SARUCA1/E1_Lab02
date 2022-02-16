using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsLab2
{
    interface ITeam<T>
    {
        T getTeam();
        void CreateTeam(T value);
    }
}
