using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Com.Wiseape.Factory;
using Com.Wiseape.Common.Resources.Business.Contract;
using Com.Wiseape.Common.Data.Model;
using Com.Wiseape.Utility;
using System.IO;
using System.ServiceModel.Activation;

namespace Com.Wiseape.Common.Resources.Webservice
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "LoginService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select LoginService.svc or LoginService.svc.cs at the Solution Explorer and start debugging.

    [AspNetCompatibilityRequirements(
            RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class LoginService : ILoginService
    {
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "login/{username}/{password}")]
        public Stream Login(string username, string password)
        {
            ILoginBusinessService businessService = (ILoginBusinessService)BusinessFactory.Create("Find.Common.Resources.UserLogin");
            OperationResult result = businessService.FindByUsernameAndPassword(username, password);
            return result.ToJsonStream();

        }

        [WebInvoke(Method = "GET",
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "info/{username}")]
        public Stream Info(string username)
        {
            IFindUserLoginBusinessService businessService = (IFindUserLoginBusinessService)BusinessFactory.Create("Find.Common.Resources.UserLogin");
            OperationResult result = businessService.FindByUsername(username);

            List<UserLogin> logins = (List<UserLogin>)result.Data;
            if(logins.Count > 0)
            {
                Int64 userID = logins[0].IdUser;
                IFindUserInfoBusinessService bs = (IFindUserInfoBusinessService)BusinessFactory.Create("Find.Common.Resources.UserInfo");
                result = bs.FindByUserId(userID);
                List<UserInfo> userInfoes = (List<UserInfo>)result.Data;
                if (userInfoes.Count > 0)
                {
                    UserInfo info = userInfoes[0];
                    info.Username = username;
                }
            }

            return result.ToJsonStream();

        }
    }
}
