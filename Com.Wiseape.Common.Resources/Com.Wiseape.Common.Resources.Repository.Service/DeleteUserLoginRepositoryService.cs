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
    public class DeleteUserLoginRepository : BaseRepository<UserLogin>, IDeleteUserLoginRepository
    {
        class Keywords
        {
            public static string DeleteUserLogin = "Delete.Common.Resources.UserLogin";
        }

        /// <summary>
        /// Constructor for DeleteUserLoginRepository
        /// </summary>
        /// <param name="dataContextKey">Key for Datacontext to use</param>
        public DeleteUserLoginRepository(string dataContextKey) : base(dataContextKey)
        {
        }
        
        
        public DeleteUserLoginRepository()
        {
            this.DataContextKey = Keywords.DeleteUserLogin;
        }

//------------------- Delete by keywords --------------------------------------------------------

        /// <summary>
        /// Delete all  User Login data with username containing specified keyword
        /// </summary>
		/// <param name="username"> Username</param>
		/// <returns>List of  User Login</returns>
        public void DeleteByUsername(string username)
        {
            CommonDataContext dataContext = (CommonDataContext)this.DataContext;
            var list = from o in dataContext.UserLogins
                       where
							o.Username.Contains(username) 						
						select o;
			dataContext.UserLogins.RemoveRange(list);
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Delete all  User Login data with user Password containing specified keyword
        /// </summary>
		/// <param name="userPassword"> User Password</param>
		/// <returns>List of  User Login</returns>
        public void DeleteByUserPassword(string userPassword)
        {
            CommonDataContext dataContext = (CommonDataContext)this.DataContext;
            var list = from o in dataContext.UserLogins
                       where
							o.UserPassword.Contains(userPassword) 						
						select o;
			dataContext.UserLogins.RemoveRange(list);
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Delete all  User Login data with created Date containing specified keyword
        /// </summary>
		/// <param name="createdDate"> Created Date</param>
		/// <returns>List of  User Login</returns>
        public void DeleteByCreatedDate(DateTime createdDate)
        {
            CommonDataContext dataContext = (CommonDataContext)this.DataContext;
            var list = from o in dataContext.UserLogins
                       where
							o.CreatedDate.Equals(createdDate) 						
						select o;
			dataContext.UserLogins.RemoveRange(list);
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Delete all  User Login data with application I D containing specified keyword
        /// </summary>
		/// <param name="applicationID"> Application I D</param>
		/// <returns>List of  User Login</returns>
        public void DeleteByApplicationID(string applicationID)
        {
            CommonDataContext dataContext = (CommonDataContext)this.DataContext;
            var list = from o in dataContext.UserLogins
                       where
							o.ApplicationID.Contains(applicationID) 						
						select o;
			dataContext.UserLogins.RemoveRange(list);
            dataContext.SaveChanges();
        }


//-----------------------  Delete by Foreign keys ---------------------------------------

        /// <summary>
        /// Delete all  User Login data with specified is Active 
        /// </summary>
		/// <param name="isActive"> Is Active</param>
		/// <returns>List of  User Login</returns>
        public void DeleteByIsActive(Int16 isActive)
        {
            CommonDataContext dataContext = (CommonDataContext)this.DataContext;
            var list = from o in dataContext.UserLogins
                       where
							o.IsActive == isActive  						
						select o;
            dataContext.UserLogins.RemoveRange(list);
            dataContext.SaveChanges();
        }


    }
}
