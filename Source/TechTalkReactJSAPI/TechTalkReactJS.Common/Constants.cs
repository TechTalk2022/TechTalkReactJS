using System;

namespace TechTalkReactJS.Common
{
    public class Constants
    {
        public const string AdminFileUploadContainer = "adminfileuploadcontainer";

        //Exception Messages
        public const string NotValidUsers = "Please Select Valid Users";

    }


    public class StroredProc
    {
        //Users Details

        public const string DeleteUser = "usp_UserDelete";
        public const string GetUser = "usp_UserGetDetils";
        public const string GetUserList = "usp_UserGetDetilsList";
        public const string GetUserById = "usp_UserGetDetilsById";
        public const string UserLogin = "usp_UserLogin";
        public const string SaveUser = "usp_UserSave";



        //Employee Details

        public const string DeleteEmployee = "usp_UserDelete";
        public const string GetEmployee = "usp_UserGet";
        public const string GetEmployeeById = "usp_UserGetById";
        public const string SaveEmployee = "usp_UserSave";





    }



    public class GlobalConstants
    {
        //Dashboard 
        public const int SixMonth = 6;

    }
}
