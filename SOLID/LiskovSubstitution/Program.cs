using System;
using System.Threading.Tasks;
using LiskovSubstitution.Models;
using ViolationExample;

namespace LiskovSubstitution
{
    class Program
    {
        static async Task Main(string[] args)
        {
            SaveToStorage saveToStorage;

            var storageModel = new StorageModel<Invoice>()
            {
                Id = Guid.NewGuid().ToString()
            };

            saveToStorage = new SaveToMSSQL();
            await saveToStorage.Execute(storageModel);

            saveToStorage = new SaveToBlobStorage();
            await saveToStorage.Execute(storageModel);

            /* Preconditions */
            new Preconditions().Run();
            /* Preconditions */

            /* Postconditions */
            new Postconditions().Run();
            /* Postconditions */

            /* Exceptions */
            new Exceptions().Run();
            /* Exceptions */

            Console.ReadKey();
        }
    }
}
