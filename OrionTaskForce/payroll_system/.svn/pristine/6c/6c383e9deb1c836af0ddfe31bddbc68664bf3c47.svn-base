using System.Diagnostics;
using DatabaseLibrary;
using System;

namespace ProjectTester
{
    class Program
    {
        // test AbstractModel.All()
        //static void Main(string[] args)
        //{
        //    var result = ModelsLibrary.ModelCollection.All<ModelsLibrary.Payroll.TaxGroup>();
        //    foreach (ModelsLibrary.Payroll.TaxGroup item in result) 
        //    {
        //        Console.WriteLine("{0} - {1}", item.Id, item.Description);
        //    }

        //    Console.ReadLine();
        //}

        // create a model
        static void Main()
        {
            var ans = "";
            while (ans != "n")
            {
                DisplayMenu();
                Console.Write("Another?:[y/n] ");
                ans = Console.ReadLine();
            }
        }

        private static void DisplayMenu()
        {
            Console.WriteLine("--- Create a model based on table structure --- ");
            Console.WriteLine("C: Create");
            Console.WriteLine("X: Exit");

            Console.Write("Enter option: ");

            var option = Console.ReadLine();
            Debug.Assert(option != null, "option != null");
            if (option.ToLower() == "c")
            {
                Console.Write("Enter class name: ");
                var className = Console.ReadLine();
                Debug.Assert(className != null, "className != null");
                if (className.Length > 2)
                {
                    var tempFile = ModelCreator.Create(className);
                    Process.Start(tempFile);
                }
            }
        }
    }
}
