using System;
using System.Collections.Generic;
using System.Text;

namespace LinqDemo
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Phone[] Phones { get; set; }
    }
}
