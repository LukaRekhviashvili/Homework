using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleTutorialWithBeqa.HomeWork
{
    static class Datavaleba1
    {
        public static void Print()
        {
            Building building = new Building
            {
                Address = "varketili",
                BuildDate = new DateTime(1970, 1, 1),
                Appartments = new Appartment[]
                {
                    new Appartment
                    {
                        AppartmentNo = 1, Area = 60,
                        Humans = new Human[]
                        {
                            new Human
                            {
                                Name ="luka"
                            },
                            new Human
                            {
                                Name = "klara"
                            }
                        }
                    },
                    new Appartment
                    {
                        AppartmentNo = 120,
                        Area = 100,
                        Humans = new Human[]
                        {
                            new Human
                            {
                                Name = "beqa"
                            }
                        }
                    }
                }
            };

            foreach (var appartment in building.Appartments)
            {
                Console.WriteLine(appartment.AppartmentNo + " " + appartment.Area);

                foreach (var human in appartment.Humans)
                {
                    Console.WriteLine(human.Name);
                }

                Console.WriteLine();
            }
        }
    }
}
