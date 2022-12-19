using System;
namespace FactoryPatternExercise2
{
	public class MongoDataAccess : IDataAccess
	{
        public static List<Product> Products = new List<Product>()
        {
             new Product(){Name="Xbox",Price = 300},
             new Product(){Name="Guitar",Price = 865},
             new Product(){Name="Blender",Price = 55},
             new Product(){Name="PS5",Price = 450},
        };

        public List<Product> LoadData()
        {
            Console.WriteLine("I am reading data from { Mongo database}");

            return Products;
        }

        public void SaveData()
        {
            Console.WriteLine("I am saving data from Mongo Data Access");
        }
    }
}

