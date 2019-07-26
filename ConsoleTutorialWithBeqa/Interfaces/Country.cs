using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleTutorialWithBeqa.Interfaces
{
    class Country : IDescription
    {
        public string Name { get; set; }

        public string Description {
            get {
                return Name;
            }
        }
    }
}
