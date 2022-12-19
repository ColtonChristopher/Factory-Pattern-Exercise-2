using System;

namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What database would you like to work with?");
            Console.WriteLine("type sql");
            Console.WriteLine("type List");
            Console.WriteLine("type mongo");

            var userInput = Console.ReadLine();

            IDataAccess db = DataAccessFactory.GetDataAccessType(userInput);

           var products = db.LoadData();
            db.SaveData();

            foreach(var product in products)
            {
                Console.WriteLine($"Name: {product.Name} Price: {product.Price}");
            }
        }
    }
}
