using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Wiseape.Common.Data.Model;
using Com.Wiseape.Common.Resources.Repository.Contract;
using Com.Wiseape.Common.Resources.Business.Contract;
using Com.Wiseape.Utility;
using Com.Wiseape.Factory;

namespace Com.Wiseape.Common.Resources.Business.Service
{
    public class LoginBusinessService : FindUserLoginBusinessService, ILoginBusinessService
    {
        public OperationResult FindByUsernameAndPassword(string username, string password)
        {
            IFindUserLoginRepository repositiory = (IFindUserLoginRepository)RepositoryFactory.Create("Find.Common.Resources.UserLogin");
            List<UserLogin> userLoginList = repositiory.FindByUsername(username);

            if (userLoginList.Count == 0)
                return new OperationResult(false, "Username does not exists");

            UserLogin userLogin = userLoginList.Find(x => x.UserPassword.Equals(password));
            if(userLogin == null)
            {
                return new OperationResult(false, "Password is invalid");
            }

            return new OperationResult(true, userLogin);
        }
    }
}
