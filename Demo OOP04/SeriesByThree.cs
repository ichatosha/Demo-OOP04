using Demo_OOP04.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_OOP04
{
    internal class SeriesByThree : ISeries
    {
        public int Current { get ; set ; }

        public void GetNext()
        {
            Current = Current + 3;
        }

        public void Reset()
        {
            Current = 0;
        }
    }
}
