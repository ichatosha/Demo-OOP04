using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_OOP04.Interfaces
{
    internal interface IMyType
    {
        public int Id { get; set; }

        public void MyFun(int x);


        public void Print()
        {
            Console.WriteLine($"Hello Default Implememnted Method From Interface");
        }
    }
}
