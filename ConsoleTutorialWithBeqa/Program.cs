using System;
using System.Collections.Generic;

namespace ConsoleTutorialWithBeqa
{
    class Program
    {
        static void Main(string[] args)
        {
            //IRun runner = new Interfaces.InterfacesWorkflow();
            IRun runner = new SQL.SQLWorkflow();

            runner.Run();

            runner.Run();

            for (int i = 0; i < 5; i++)
            {
                runner.Run();
            }

            Console.ReadKey();
        }
    }
}
