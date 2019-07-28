using System;
using System.Collections.Generic;

namespace ConsoleTutorialWithBeqa
{
    class Program
    {
        static void Main(string[] args)
        {
            //IRun runner = new Interfaces.InterfacesWorkflow();
            //IRun runner = new SQL.SQLWorkflow();
            IRun runner = new Dapper.DapperWorkflow();

            runner.Run();

            Console.ReadKey();
        }
    }
}
