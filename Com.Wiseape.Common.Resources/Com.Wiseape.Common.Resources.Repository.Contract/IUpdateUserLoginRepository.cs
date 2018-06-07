using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Wiseape.Common.Data.Model;



namespace Com.Wiseape.Common.Resources.Repository.Contract
{
    public interface IUpdateUserLoginRepository
    {

	    /// <summary>
	    /// Updates  User Login's id User, username by idUser
	    /// </summary>
		/// <param name="idUser">id User</param>
		/// <param name="username">username</param>
		/// <returns>List of  User Login</returns>
		void UpdateUsername(Int64 idUser, string username);
	
	    /// <summary>
	    /// Updates  User Login's id User, user Password by idUser
	    /// </summary>
		/// <param name="idUser">id User</param>
		/// <param name="userPassword">user Password</param>
		/// <returns>List of  User Login</returns>
		void UpdateUserPassword(Int64 idUser, string userPassword);
	
	    /// <summary>
	    /// Updates  User Login's id User, created Date by idUser
	    /// </summary>
		/// <param name="idUser">id User</param>
		/// <param name="createdDate">created Date</param>
		/// <returns>List of  User Login</returns>
		void UpdateCreatedDate(Int64 idUser, DateTime createdDate);
	
	    /// <summary>
	    /// Updates  User Login's id User, application I D by idUser
	    /// </summary>
		/// <param name="idUser">id User</param>
		/// <param name="applicationID">application I D</param>
		/// <returns>List of  User Login</returns>
		void UpdateApplicationID(Int64 idUser, string applicationID);
	
	    /// <summary>
	    /// Updates  User Login's id User, is Active by idUser
	    /// </summary>
		/// <param name="idUser">id User</param>
		/// <param name="isActive">is Active</param>
		/// <returns>List of  User Login</returns>
		void UpdateIsActive(Int64 idUser, Int16 isActive);
	
    }
}

