using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Wiseape.Framework;
using Com.Wiseape.Common.Data.Model;
using Com.Wiseape.Common.Data.Context;
using Com.Wiseape.Common.Resources.Repository.Contract;

namespace Com.Wiseape.Common.Resources.Repository.Service
{
    /// <summary>
    /// Repository for UserLogin data.
    /// </summary>
    public class FindUserLoginRepository : BaseRepository<UserLogin>, IFindUserLoginRepository
    {
        class Keywords
        {
            public static string FindUserLogin = "Find.Common.Resources.UserLogin";
        }

        /// <summary>
        /// Constructor for UserLoginRepository
        /// </summary>
        /// <param name="dataContextKey">Key for Datacontext to use</param>
        public FindUserLoginRepository(string dataContextKey) : base(dataContextKey)
        {
        }
        
        
        public FindUserLoginRepository()
        {
            this.DataContextKey = Keywords.FindUserLogin;
        }

//------------------- Find by keywords --------------------------------------------------------

        /// <summary>
        /// Finds all  User Login data with username containing specified keyword
        /// </summary>
		/// <param name="username"> Username</param>
		/// <returns>List of  User Login</returns>
        public List<UserLogin> FindByUsername(string username)
        {
            CommonDataContext dataContext = (CommonDataContext)this.DataContext;
            var list = from o in dataContext.UserLogins
                       where
							o.Username.Contains(username) 						
						select o;
            return list.ToList();
        }

        /// <summary>
        /// Finds all  User Login data with user Password containing specified keyword
        /// </summary>
		/// <param name="userPassword"> User Password</param>
		/// <returns>List of  User Login</returns>
        public List<UserLogin> FindByUserPassword(string userPassword)
        {
            CommonDataContext dataContext = (CommonDataContext)this.DataContext;
            var list = from o in dataContext.UserLogins
                       where
							o.UserPassword.Contains(userPassword) 						
						select o;
            return list.ToList();
        }

        /// <summary>
        /// Finds all  User Login data with application I D containing specified keyword
        /// </summary>
		/// <param name="applicationID"> Application I D</param>
		/// <returns>List of  User Login</returns>
        public List<UserLogin> FindByApplicationID(string applicationID)
        {
            CommonDataContext dataContext = (CommonDataContext)this.DataContext;
            var list = from o in dataContext.UserLogins
                       where
							o.ApplicationID.Contains(applicationID) 						
						select o;
            return list.ToList();
        }


//----------------------  find by dates -----------------------------------------------

        /// <summary>
        /// Finds all  User Login with CreatedDate between CreatedDate1 and CreatedDate2
        /// </summary>
		/// <param name="createdDate1"> Created Date</param>
		/// <param name="createdDate2"> Created Date</param>
		/// <returns>List of  User Login</returns>
        public List<UserLogin> FindByCreatedDateBetween(DateTime createdDate1, DateTime createdDate2)
        {
            CommonDataContext dataContext = (CommonDataContext)this.DataContext;
            var list = from o in dataContext.UserLogins
                       where
                            o.CreatedDate >= createdDate1 &&
                            o.CreatedDate <= createdDate2
                       select o;
            return list.ToList();
        }


//-----------------------  Find by Foreign keys ---------------------------------------

        /// <summary>
        /// Finds all  User Login data with specified is Active 
        /// </summary>
		/// <param name="isActive"> Is Active</param>
		/// <returns>List of  User Login</returns>
        public List<UserLogin> FindByIsActive(Int16 isActive)
        {
            CommonDataContext dataContext = (CommonDataContext)this.DataContext;
            var list = from o in dataContext.UserLogins
                       where
							o.IsActive == isActive  						
						select o;
            return list.ToList();
        }




    }
}
