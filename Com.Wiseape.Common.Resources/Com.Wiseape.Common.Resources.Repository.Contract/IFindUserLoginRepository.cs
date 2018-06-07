using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Wiseape.Common.Data.Model;



namespace Com.Wiseape.Common.Resources.Repository.Contract
{
    public interface IFindUserLoginRepository
    {

        /// <summary>
        /// Finds all  User Login data with username containing specified keyword
        /// </summary>
		/// <param name="username"> Username</param>
		/// <returns>List of  User Login</returns>
		List<UserLogin> FindByUsername(string username);

        /// <summary>
        /// Finds all  User Login data with user Password containing specified keyword
        /// </summary>
		/// <param name="userPassword"> User Password</param>
		/// <returns>List of  User Login</returns>
		List<UserLogin> FindByUserPassword(string userPassword);

        /// <summary>
        /// Finds all  User Login data with created Date1, created Date2 containing specified keyword
        /// </summary>
		/// <param name="createdDate1"> Created Date</param>
		/// <param name="createdDate2"> Created Date</param>
		/// <returns>List of  User Login</returns>
		List<UserLogin> FindByCreatedDateBetween(DateTime createdDate1, DateTime createdDate2);

        /// <summary>
        /// Finds all  User Login data with application I D containing specified keyword
        /// </summary>
		/// <param name="applicationID"> Application I D</param>
		/// <returns>List of  User Login</returns>
		List<UserLogin> FindByApplicationID(string applicationID);

        /// <summary>
        /// Finds all  User Login data with is Active containing specified keyword
        /// </summary>
		/// <param name="isActive"> Is Active</param>
		/// <returns>List of  User Login</returns>
		List<UserLogin> FindByIsActive(Int16 isActive);

    }
}

