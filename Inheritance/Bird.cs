using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    internal class Bird : Animals
    {
        public bool CanFly { get; set; }
        public string BeakType { get; set; }
        public bool Migrate { get; set; }
        public string NestDiscription { get; set; }
    }
}
