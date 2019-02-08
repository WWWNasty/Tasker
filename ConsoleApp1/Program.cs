using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic;
using DataAccess;
using Domain;


namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var connectionString =
                "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog='Tasker';Integrated Security=True";
     
            var context = new ObjectiveContext(connectionString);

            Console.WriteLine("Все записи:");

            ObjectiveManager objectiveManager = new ObjectiveManager(context);

            foreach (Objective objective in objectiveManager.GetAll())
            {
                Console.WriteLine(objective);
            }
            
            Console.ReadKey();

        }

    }
}
