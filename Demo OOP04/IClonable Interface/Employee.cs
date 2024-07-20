﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_OOP04.IClonable_Interface
{
    internal class Employee : ICloneable
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public decimal Salary { get; set; }

        public object Clone()
        {
            return new Employee()
            {
                Id = Id,Name = Name,Salary = Salary
            };
        }

        public override string ToString()
        {
            return $"id : {Id} , name {Name}, slaary : {Salary}";
        }
    }
}
