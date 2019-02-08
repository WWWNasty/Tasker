using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic;


namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Все записи:");

            ObjectiveManager objectiveManager = new ObjectiveManager();

            Console.WriteLine(objectiveManager.GetAll());

            Console.ReadKey();

        }
    }
}
