using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleTutorialWithBeqa
{
    class Human
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public int Age {
            get {
                return DateTime.Now.Year - BirthDate.Year;
            }
        }
    }
}
