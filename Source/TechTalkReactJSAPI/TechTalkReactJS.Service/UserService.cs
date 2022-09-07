
namespace TechTalkReactJS.Service
{ 
    using System; 
    using System.Threading.Tasks;
    using TechTalkReactJS.Models;
    using TechTalkReactJS.Models.Input; 
    using TechTalkReactJS.Repository;

    public interface IUserService
    {
        Task<ResultArgs> GetUser();
        Task<ResultArgs> GetUserById(int userId);
        Task<ResultArgs> DeleteUser(int userId);
        Task<ResultArgs> SaveUser(UserDetails user);

        bool ValidateCredentials(string username, string password);

    }



    public class UserService : IUserService
    {

        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            this._userRepository = userRepository;
        }


        public async Task<ResultArgs> GetUser()
        {
            var RresultArgs = new ResultArgs();
            var userDetailResult = await _userRepository.GetUser();


            if (userDetailResult != null)
            {
                RresultArgs.StatusCode = 200;
                RresultArgs.StatusMessage = "Record is success";
                RresultArgs.ResultData = userDetailResult;
            }
            else
            {
                RresultArgs.StatusCode = 205;
                RresultArgs.StatusMessage = "Failed to save";
            }
            return RresultArgs;


        }
        public async Task<ResultArgs> GetUserById(int userId)
        {
            var RresultArgs = new ResultArgs();

            var userResult = await _userRepository.GetUserById(Convert.ToInt32(userId));

            RresultArgs.StatusCode = 200;
            RresultArgs.StatusMessage = "Get user record is success";
            RresultArgs.ResultData = userResult;

            return RresultArgs;
        }
        public async Task<ResultArgs> DeleteUser(int userId)
        {
            var RresultArgs = new ResultArgs();

            await _userRepository.DeleteUser(userId);

            RresultArgs.StatusCode = 200;
            RresultArgs.StatusMessage = "Deleted success";

            return RresultArgs;
        }


        public async Task<ResultArgs> SaveUser(UserDetails user)
        {
            var RresultArgs = new ResultArgs();

            var userId = await _userRepository.SaveUser(user);
            if (userId > 0)
            {
                RresultArgs.StatusCode = 200;
                RresultArgs.StatusMessage = "Save success";
            }
            else
            {
                RresultArgs.StatusCode = 201;
                RresultArgs.StatusMessage = "Failed to save";
            }

            return RresultArgs;
        }

        public bool ValidateCredentials(string username, string password)
        {
            return username.Equals("jus") && password.Equals("jus");
        }

    }
}

