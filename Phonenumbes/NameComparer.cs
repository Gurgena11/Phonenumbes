using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonenumbes
{
    internal class NameComparer : IComparer<Human>
    {
        public int Compare(Human x, Human y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }
}
