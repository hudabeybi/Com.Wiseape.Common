using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Wiseape.Utility;
using Com.Wiseape.Common.Data.Model;


namespace Com.Wiseape.Common.Resources.Business.Contract
{
    public interface IFindUserLoginBusinessService
    {

        /// <summary>
        /// Finds all  User Login data with username containing specified keyword
        /// </summary>
		/// <param name="username"> Username</param>
		/// <returns>List of  User Login</returns>
		OperationResult FindByUsername(string username);

        /// <summary>
        /// Finds all  User Login data with user Password containing specified keyword
        /// </summary>
		/// <param name="userPassword"> User Password</param>
		/// <returns>List of  User Login</returns>
		OperationResult FindByUserPassword(string userPassword);

        /// <summary>
        /// Finds all  User Login with CreatedDate between CreatedDate1 and CreatedDate2
        /// </summary>
		/// <param name="createdDate1"> Created Date</param>
		/// <param name="createdDate2"> Created Date</param>
		/// <returns>List of  User Login</returns>
		OperationResult FindByCreatedDateBetween(DateTime createdDate1, DateTime createdDate2);

        /// <summary>
        /// Finds all  User Login data with application I D containing specified keyword
        /// </summary>
		/// <param name="applicationID"> Application I D</param>
		/// <returns>List of  User Login</returns>
		OperationResult FindByApplicationID(string applicationID);

        /// <summary>
        /// Finds all  User Login data with specified is Active 
        /// </summary>
		/// <param name="isActive"> Is Active</param>
		/// <returns>List of  User Login</returns>
		OperationResult FindByIsActive(Int16 isActive);

	}
}