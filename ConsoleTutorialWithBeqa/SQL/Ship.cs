using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleTutorialWithBeqa.SQL
{
    public class Ship
    {
        public string Name { get; set; }
        public string Flag { get; set; }

        public string Description {
            get {
                return $"{Name} {Flag}";
            }
        }
    }
}
