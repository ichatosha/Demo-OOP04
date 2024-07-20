using Demo_OOP04.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_OOP04
{
    // class : class -> inherit
    // class : interface -> implement
    // struct : interface -> implement 
    // interface : interface -> inherit
    // interface can implemnent through class or struct 
    internal class MyType : IMyType
    {
        public int Id { get ; set; } // automatic prop


        public void MyFun(int x)
        {
            Console.WriteLine($"Hello Route : X = {x} , id = {Id}");
        }
    }
}
