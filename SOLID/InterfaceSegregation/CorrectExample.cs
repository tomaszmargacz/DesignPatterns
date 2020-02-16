using System.Threading.Tasks;

namespace InterfaceSegregation
{
    public interface ICreateAccount
    {
        public Task Create();
    }

    public interface IEditAccount
    {
        public Task Edit();
    }

    public interface IDeleteAccount
    {
        public Task Delete();
    }

    public class Register : ICreateAccount
    {
        public async Task Create()
        {
            //implementation
        }
    }

    public class UserProfile : IEditAccount, IDeleteAccount
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
