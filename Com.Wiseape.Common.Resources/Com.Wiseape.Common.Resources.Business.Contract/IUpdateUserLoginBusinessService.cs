using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Wiseape.Utility;
using Com.Wiseape.Common.Data.Model;


namespace Com.Wiseape.Common.Resources.Business.Contract
{
    public interface IUpdateUserLoginBusinessService
    {

        /// <summary>
        /// Updates  User Login's username which has specified idUser
        /// </summary>
		/// <param name="idUser">id User</param>
		/// <param name="username">username</param>
		/// <returns>List of  User Login</returns>
		OperationResult UpdateUsername(Int64 idUser, string username);

        /// <summary>
        /// Updates  User Login's user Password which has specified idUser
        /// </summary>
		/// <param name="idUser">id User</param>
		/// <param name="userPassword">user Password</param>
		/// <returns>List of  User Login</returns>
		OperationResult UpdateUserPassword(Int64 idUser, string userPassword);

        /// <summary>
        /// Updates  User Login's created Date which has specified idUser
        /// </summary>
		/// <param name="idUser">id User</param>
		/// <param name="createdDate">created Date</param>
		/// <returns>List of  User Login</returns>
		OperationResult UpdateCreatedDate(Int64 idUser, DateTime createdDate);

        /// <summary>
        /// Updates  User Login's application I D which has specified idUser
        /// </summary>
		/// <param name="idUser">id User</param>
		/// <param name="applicationID">application I D</param>
		/// <returns>List of  User Login</returns>
		OperationResult UpdateApplicationID(Int64 idUser, string applicationID);

        /// <summary>
        /// Updates  User Login's is Active which has specified idUser
        /// </summary>
		/// <param name="idUser">id User</param>
		/// <param name="isActive">is Active</param>
		/// <returns>List of  User Login</returns>
		OperationResult UpdateIsActive(Int64 idUser, Int16 isActive);

	}
}