using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsLab2
{
    public class Teams<T> : ITeam<T>
    {
        public void CreateTeam(T value)
        {
            throw new NotImplementedException();
        }

        public T getTeam()
        {
            throw new NotImplementedException();
        }
    }
}
