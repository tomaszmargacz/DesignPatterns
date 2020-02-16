using System;
using System.Threading.Tasks;

namespace ViolationExample
{
    public interface IAccount
    {
        public Task Create();
        public Task Edit();
        public Task Delete();
    }

    public class Register : IAccount
    {
        public async Task Create()
        {
            //implementation
        }

        public async Task Edit()
        {
            throw new NotImplementedException();
        }

        public async Task Delete()
        {
            throw new NotImplementedException();
        }
    }

    public class UserProfile : IAccount
    {
        public async Task Create()
        {
            throw new NotImplementedException();
        }

        public async Task Edit()
        {
            //implementation
        }

        public async Task Delete()
        {
            //implementation
        }
    }
}
