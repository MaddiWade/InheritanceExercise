using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    internal class Reptile : Animals
    {
        public string Skintype { get; set; }
        public string Movement { get; set; }
        public bool Poisionious { get; set; }
        public bool Harmful { get; set; }
    }
}
