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
    /// Repository for UpdateUserLogin data.
    /// </summary>
    public class UpdateUserLoginRepository : BaseRepository<UserLogin>, IUpdateUserLoginRepository
    {
        class Keywords
        {
            public static string UpdateUserLogin = "Update.Common.Resources.UserLogin";
        }

        /// <summary>
        /// Constructor for UserLoginRepository
        /// </summary>
        /// <param name="dataContextKey">Key for Datacontext to use</param>
        public UpdateUserLoginRepository(string dataContextKey) : base(dataContextKey)
        {
        }
        
        
        public UpdateUserLoginRepository()
        {
            this.DataContextKey = Keywords.UpdateUserLogin;
        }


//-------------------------- Update columns by Primary key -----------------------------------------

        /// <summary>
        /// Updates  User Login's id User, username by idUser
        /// </summary>
		/// <param name="idUser">id User</param>
		/// <param name="username">username</param>
		/// <returns>List of  User Login</returns>
        public void UpdateUsername(Int64 idUser, string username)
        {
            CommonDataContext dataContext = (CommonDataContext)this.DataContext;
            var list = from o in dataContext.UserLogins
                       where
                       		o.IdUser == idUser
                       	select o;
           	list.ToList().ForEach(o => {
      			o.Username = username;	
            });
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Updates  User Login's id User, user Password by idUser
        /// </summary>
		/// <param name="idUser">id User</param>
		/// <param name="userPassword">user Password</param>
		/// <returns>List of  User Login</returns>
        public void UpdateUserPassword(Int64 idUser, string userPassword)
        {
            CommonDataContext dataContext = (CommonDataContext)this.DataContext;
            var list = from o in dataContext.UserLogins
                       where
                       		o.IdUser == idUser
                       	select o;
           	list.ToList().ForEach(o => {
      			o.UserPassword = userPassword;	
            });
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Updates  User Login's id User, created Date by idUser
        /// </summary>
		/// <param name="idUser">id User</param>
		/// <param name="createdDate">created Date</param>
		/// <returns>List of  User Login</returns>
        public void UpdateCreatedDate(Int64 idUser, DateTime createdDate)
        {
            CommonDataContext dataContext = (CommonDataContext)this.DataContext;
            var list = from o in dataContext.UserLogins
                       where
                       		o.IdUser == idUser
                       	select o;
           	list.ToList().ForEach(o => {
      			o.CreatedDate = createdDate;	
            });
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Updates  User Login's id User, application I D by idUser
        /// </summary>
		/// <param name="idUser">id User</param>
		/// <param name="applicationID">application I D</param>
		/// <returns>List of  User Login</returns>
        public void UpdateApplicationID(Int64 idUser, string applicationID)
        {
            CommonDataContext dataContext = (CommonDataContext)this.DataContext;
            var list = from o in dataContext.UserLogins
                       where
                       		o.IdUser == idUser
                       	select o;
           	list.ToList().ForEach(o => {
      			o.ApplicationID = applicationID;	
            });
            dataContext.SaveChanges();
        }


//-------------------------- Update foreign keys -----------------------------------------

        /// <summary>
        /// Updates  User Login's id User, is Active by idUser
        /// </summary>
		/// <param name="idUser">id User</param>
		/// <param name="isActive">is Active</param>
		/// <returns>List of  User Login</returns>
        public void UpdateIsActive(Int64 idUser, Int16 isActive)
        {
            CommonDataContext dataContext = (CommonDataContext)this.DataContext;
            var list = from o in dataContext.UserLogins
                       where
                       		o.IdUser == idUser
                       	select o;
           	list.ToList().ForEach(o => {
      			o.IsActive = isActive;
	
            });
            dataContext.SaveChanges();
        }


    }
}
