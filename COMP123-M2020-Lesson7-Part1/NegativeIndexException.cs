using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_M2020_Lesson7_Part1
{
    class NegativeIndexException : Exception
    {
        public NegativeIndexException()
            :base("You've entered a negative index")
        {

        }
    }
}
