using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleTutorialWithBeqa
{
    class Building
    {
        public string Address { get; set; }
        public DateTime BuildDate { get; set; }

        public Appartment[] Appartments { get; set; }
    }
}
