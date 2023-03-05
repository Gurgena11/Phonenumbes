using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonenumbes
{
    internal class LastnameComparer : Comparer<Human>
    {
        public override int Compare(Human x, Human y)
        {
            return x.LastName.CompareTo(y.LastName);
        }
    }
}
