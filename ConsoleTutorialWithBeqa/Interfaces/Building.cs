using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleTutorialWithBeqa.Interfaces
{
    class Building : IDescription
    {
        public string Name { get; set; }
        public int Year { get; set; }

        public string Description {
            get {
                return $"{Name} {Year}";
            }
        }
    }
}
