using System;

namespace TechTalkReactJS.Repository
{
    using Dapper;
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using System.Threading.Tasks;
    using TechTalkReactJS.DBEngine;
    using TechTalkReactJS.Common;
    using TechTalkReactJS.Models.Input;
    using TechTalkReactJS.Models.Output;

    public interface IUserRepository
    {

        Task<UserDetailsResults> GetUser();
        Task<List<UserDetails>> GetUserList();
        Task<UserDetails> GetUserById(int userId);
        Task<int> SaveUser(UserDetails user);
        Task DeleteUser(int userId);


    }


    public class UserRepository : IUserRepository
    {
        private readonly ISQLServerHandler _SQLServerHandler;

        public UserRepository(ISQLServerHandler sQLServerHandler)
        {
            _SQLServerHandler = sQLServerHandler;
        }

        public async Task<UserDetailsResults> GetUser()
        {
            UserDetailsResults usersSearchResult = new UserDetailsResults();

            using (_SQLServerHandler.Connection)
            {
                var multipleResults = await _SQLServerHandler.QueryMultipleAsync(_SQLServerHandler.Connection, StroredProc.GetUser, CommandType.StoredProcedure, null);

                if (multipleResults != null)
                {

                    usersSearchResult.UsersList = (await multipleResults.ReadAsync<UserDetails>()).ToList();
                    usersSearchResult.RoleList = (await multipleResults.ReadAsync<UserRole>()).ToList();
                }
            }
            return usersSearchResult;
        }


        public async Task<List<UserDetails>> GetUserList()
        {
            return (await _SQLServerHandler.QueryAsync<UserDetails>(_SQLServerHandler.Connection, StroredProc.GetUserList, CommandType.StoredProcedure, null)).ToList();

        }

        public async Task<UserDetails> GetUserById(int userId)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@UserId", userId, DbType.Int32, ParameterDirection.Input);
            return await _SQLServerHandler.QueryFirstOrDefaultAsync<UserDetails>(_SQLServerHandler.Connection, StroredProc.GetUserById, CommandType.StoredProcedure, parameters);
        }
        public async Task DeleteUser(int userId)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@UserId", userId, DbType.Int32, ParameterDirection.Input);
            await _SQLServerHandler.ExecuteAsync(_SQLServerHandler.Connection, StroredProc.DeleteUser, CommandType.StoredProcedure, parameters);
        }
        public async Task<int> SaveUser(UserDetails user)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@UserId", user.UserId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@FirstName", user.FirstName, DbType.String, ParameterDirection.Input);
            parameters.Add("@LastName", user.FirstName, DbType.String, ParameterDirection.Input);
            parameters.Add("@UserName", user.UserName, DbType.String, ParameterDirection.Input);
            parameters.Add("@Password", user.Password, DbType.String, ParameterDirection.Input);
            parameters.Add("@MobileNo", user.MobileNo, DbType.String, ParameterDirection.Input);
            parameters.Add("@EmailId", user.EmailId, DbType.String, ParameterDirection.Input);
            parameters.Add("@RoleId", user.RoleId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@GenderId", user.GenderId, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@DOB", user.DOB, DbType.Date, ParameterDirection.Input);
            parameters.Add("@returnVal", dbType: DbType.Int32, direction: ParameterDirection.Output);
            await _SQLServerHandler.ExecuteAsync(_SQLServerHandler.Connection, StroredProc.SaveUser, CommandType.StoredProcedure, parameters);
            return parameters.Get<int>("@returnVal");
        }
    }
}
