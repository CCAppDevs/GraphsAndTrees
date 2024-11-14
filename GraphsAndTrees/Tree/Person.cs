using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphsAndTrees.Tree
{
    public class Person : IComparable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthdate { get; set; }

        public int CompareTo(object? obj)
        {
            if (obj == null) return 1;
            if (obj == this) return 0;

            if ((obj as Person).Birthdate == Birthdate)
            {
                return 0;
            }
            else if ((obj as Person).Birthdate < Birthdate)
            {
                return -1;
            }
            else
            {
                return 1;
            }

        }
    }
}
