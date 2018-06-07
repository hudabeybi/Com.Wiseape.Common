using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Wiseape.Utility;
using Com.Wiseape.Common.Data.Model;


namespace Com.Wiseape.Common.Resources.Business.Contract
{
    public interface IDeleteUserLoginBusinessService
    {

        /// <summary>
        /// Delete all  User Login data with username containing specified keyword
        /// </summary>
		/// <param name="username"> Username</param>
		/// <returns>List of  User Login</returns>
		OperationResult DeleteByUsername(string username);

        /// <summary>
        /// Delete all  User Login data with user Password containing specified keyword
        /// </summary>
		/// <param name="userPassword"> User Password</param>
		/// <returns>List of  User Login</returns>
		OperationResult DeleteByUserPassword(string userPassword);

        /// <summary>
        /// Delete all  User Login data with created Date containing specified keyword
        /// </summary>
		/// <param name="createdDate"> Created Date</param>
		/// <returns>List of  User Login</returns>
		OperationResult DeleteByCreatedDate(DateTime createdDate);

        /// <summary>
        /// Delete all  User Login data with application I D containing specified keyword
        /// </summary>
		/// <param name="applicationID"> Application I D</param>
		/// <returns>List of  User Login</returns>
		OperationResult DeleteByApplicationID(string applicationID);

        /// <summary>
        /// Delete all  User Login data with specified is Active 
        /// </summary>
		/// <param name="isActive"> Is Active</param>
		/// <returns>List of  User Login</returns>
		OperationResult DeleteByIsActive(Int16 isActive);

	}
}