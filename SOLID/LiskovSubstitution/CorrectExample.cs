using System;
using System.Threading.Tasks;

namespace LiskovSubstitution
{
    public class StorageModel<T>
    {
        public string Id { get; set; }
        public T Model { get; set; }
    }

    public abstract class SaveToStorage
    {
        public virtual async Task Execute<T>(StorageModel<T> model)
        {
            if (string.IsNullOrWhiteSpace(model.Id))
            {
                throw new ArgumentException("Id cannot be null or whitespace.");
            }
        }
    }

    public class SaveToMSSQL : SaveToStorage
    {
        public override async Task Execute<T>(StorageModel<T> model)
        {
            await base.Execute<T>(model);
            //save to MSSQL
        }
    }

    public class SaveToPostgresql : SaveToStorage
    {
        public override async Task Execute<T>(StorageModel<T> model)
        {
            await base.Execute<T>(model);
            //save to Postgresql
        }
    }

    public class SaveToAccountStorage : SaveToStorage
    {
        public override async Task Execute<T>(StorageModel<T> model)
        {
            await base.Execute<T>(model);
            //save to AccountStorage
        }
    }

    public class SaveToBlobStorage : SaveToAccountStorage
    {
        public override async Task Execute<T>(StorageModel<T> model)
        {
            await base.Execute<T>(model);
            //save to BlobStorage
        }
    }
}
