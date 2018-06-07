using Com.Wiseape.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Wiseape.Common.Resources.Business.Contract
{
    public interface ILoginBusinessService
    {
        OperationResult FindByUsernameAndPassword(string username, string password);
    }
}
