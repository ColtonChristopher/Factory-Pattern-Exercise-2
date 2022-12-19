using System;
namespace FactoryPatternExercise2
{
	public static class DataAccessFactory
	{
		public static IDataAccess GetDataAccessType(string databaseType)
		{
			switch (databaseType.ToLower())
			{
				case "mongo":
					return new MongoDataAccess();
				case "sql":
					return new SQLDataAccess();
				case "List":
					return new ListDataAccess();
				default:
					return new ListDataAccess();

			}
		}
    }
}

