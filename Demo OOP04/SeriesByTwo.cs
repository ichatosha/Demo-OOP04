using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo_OOP04.Interfaces;

namespace Demo_OOP04
{
    internal class SeriesByTwo : ISeries
    {
        // auto prop
        public int Current { get; set; }

        public void GetNext()
        {
            Current = Current + 2;
        }

        public void Reset()
        {
            Current = 0;
        }
    }
}
