using System.Threading.Tasks;

namespace InterfaceSegregation
{
    public interface ICreateAccount
    {
        public Task Create();
    }

    public interface IModifyAccount
    {
        public Task Edit();
        public Task Delete();
    }

    public class Register : ICreateAccount
    {
        public async Task Create()
        {
            //implementation
        }
    }

    public class UserProfile : IModifyAccount
    {
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
