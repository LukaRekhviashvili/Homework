using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleTutorialWithBeqa.Interfaces
{
    public class InterfacesWorkflow : IRun
    {
        public void Run()
        {
            List<IDescription> descriptions = new List<IDescription>
            {
                new Building{Name="shenoba 1", Year=2000},
                new Building{Name="shenoba 2", Year=2001},
                new Country{ Name = "saqartvelo"}
            };

            foreach (var descriptionObject in descriptions)
            {
                Console.WriteLine(descriptionObject.Description);
            }
        }
    }
}
