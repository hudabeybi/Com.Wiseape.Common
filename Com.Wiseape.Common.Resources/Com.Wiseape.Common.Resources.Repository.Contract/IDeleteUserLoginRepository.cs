using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Wiseape.Common.Data.Model;

namespace Com.Wiseape.Common.Resources.Repository.Contract
{
    public interface IDeleteUserLoginRepository
    {

	   	/// <summary>
	   	/// Delete all  User Login data with username containing specified keyword
	    /// </summary>
		/// <param name="username"> Username</param>
		/// <returns>List of  User Login</returns>
		void DeleteByUsername(string username);
	
	   	/// <summary>
	   	/// Delete all  User Login data with user Password containing specified keyword
	    /// </summary>
		/// <param name="userPassword"> User Password</param>
		/// <returns>List of  User Login</returns>
		void DeleteByUserPassword(string userPassword);
	
	   	/// <summary>
	   	/// Delete all  User Login data with created Date containing specified keyword
	    /// </summary>
		/// <param name="createdDate"> Created Date</param>
		/// <returns>List of  User Login</returns>
		void DeleteByCreatedDate(DateTime createdDate);
	
	   	/// <summary>
	   	/// Delete all  User Login data with application I D containing specified keyword
	    /// </summary>
		/// <param name="applicationID"> Application I D</param>
		/// <returns>List of  User Login</returns>
		void DeleteByApplicationID(string applicationID);
	
	   	/// <summary>
	    /// Delete all  User Login data with specified is Active 
	    /// </summary>
		/// <param name="isActive"> Is Active</param>
		/// <returns>List of  User Login</returns>
		void DeleteByIsActive(Int16 isActive);
	
    }
}

