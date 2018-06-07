using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Wiseape.Common.Data.Model;
using Com.Wiseape.Common.Resources.Business.Contract;

using System.ServiceModel;

namespace Com.Wiseape.Common.Resources.Webservice
{
    /// <summary>
    /// Interface for UserLogin Service
    /// </summary>
    [ServiceContract]
    public interface IUserLoginService
    {
    
        /// <summary>
        /// Service to add UserLogin data to data store.
        /// This is a POST request.
        /// </summary>
        /// <param name="UserLoginForm">UserLogin data from POST request</param>
        /// <return>JSON string representation of operation result</return>
        [OperationContract]
        Stream AddUserLogin(UserLogin userLoginForm);

        /// <summary>
        /// Service to update UserLogin data to data store.
        /// This is a POST request.
        /// </summary>
        /// <param name="userLoginForm">UserLogin data from POST request</param>
        /// <return>JSON string representation of operation result</return>
        [OperationContract]
        Stream UpdateUserLogin(UserLogin userLoginForm);

        /// <summary>
        /// Service to delete UserLogin data from data store. 
        /// The data deleted is defined by idUser.
        /// This is a GET request.
        /// </summary>
        /// <param name="idUser">the key value of the data</param>
        /// <return>JSON string representation of operation result</return>  
        [OperationContract]
        Stream DeleteUserLogin(string idUser);

        /// <summary>
        /// Service to get a UserLogin data from data store. 
        /// The data retrieved is defined by idUser.
        /// This is a GET request.
        /// </summary>
        /// <param name="idUser">the key value of the data</param>
        /// <return>JSON string representation of operation result</return>    
        [OperationContract]
       	Stream GetUserLogin(string idUser);

        /// <summary>
        /// Service to get all the UserLogin data from data store. 
        /// The data items retrieved are those who contain the keyword given. 
        /// This is a GET request.
        /// </summary>
        /// <param name="keyword">the keyword to search</param>
        /// <param name="page">the page of the data navigation</param>
        /// <param name="max">the maximum amount of data to retrieve</param>
        /// <return>JSON string representation of operation result</return>    
		[OperationContract]
        Stream FindUserLogin(string keyword, string page, string max);	
        

        /// <summary>
        /// Finds all  User Login data with username containing specified keyword
        /// </summary>
		/// <param name="username"> Username</param>
		/// <returns>List of  User Login</returns>
		[OperationContract]
		Stream FindByUsername(string username);

        /// <summary>
        /// Updates  User Login's username which has specified idUser
        /// </summary>
		/// <param name="idUser">id User</param>
		/// <param name="username">username</param>
		/// <returns>List of  User Login</returns>
		[OperationContract]
		Stream UpdateUsername(string idUser,string username);

        /// <summary>
        /// Delete all  User Login data with username containing specified keyword
        /// </summary>
		/// <param name="username"> Username</param>
		/// <returns>List of  User Login</returns>
		[OperationContract]
		Stream DeleteByUsername(string username);

        /// <summary>
        /// Finds all  User Login data with user Password containing specified keyword
        /// </summary>
		/// <param name="userPassword"> User Password</param>
		/// <returns>List of  User Login</returns>
		[OperationContract]
		Stream FindByUserPassword(string userPassword);

        /// <summary>
        /// Updates  User Login's user Password which has specified idUser
        /// </summary>
		/// <param name="idUser">id User</param>
		/// <param name="userPassword">user Password</param>
		/// <returns>List of  User Login</returns>
		[OperationContract]
		Stream UpdateUserPassword(string idUser,string userPassword);

        /// <summary>
        /// Delete all  User Login data with user Password containing specified keyword
        /// </summary>
		/// <param name="userPassword"> User Password</param>
		/// <returns>List of  User Login</returns>
		[OperationContract]
		Stream DeleteByUserPassword(string userPassword);

        /// <summary>
        /// Finds all  User Login with CreatedDate between CreatedDate1 and CreatedDate2
        /// </summary>
		/// <param name="createdDate1"> Created Date</param>
		/// <param name="createdDate2"> Created Date</param>
		/// <returns>List of  User Login</returns>
		[OperationContract]
		Stream FindByCreatedDateBetween(string createdDate1,string createdDate2);

        /// <summary>
        /// Updates  User Login's created Date which has specified idUser
        /// </summary>
		/// <param name="idUser">id User</param>
		/// <param name="createdDate">created Date</param>
		/// <returns>List of  User Login</returns>
		[OperationContract]
		Stream UpdateCreatedDate(string idUser,string createdDate);

        /// <summary>
        /// Delete all  User Login data with created Date containing specified keyword
        /// </summary>
		/// <param name="createdDate"> Created Date</param>
		/// <returns>List of  User Login</returns>
		[OperationContract]
		Stream DeleteByCreatedDate(string createdDate);

        /// <summary>
        /// Finds all  User Login data with application I D containing specified keyword
        /// </summary>
		/// <param name="applicationID"> Application I D</param>
		/// <returns>List of  User Login</returns>
		[OperationContract]
		Stream FindByApplicationID(string applicationID);

        /// <summary>
        /// Updates  User Login's application I D which has specified idUser
        /// </summary>
		/// <param name="idUser">id User</param>
		/// <param name="applicationID">application I D</param>
		/// <returns>List of  User Login</returns>
		[OperationContract]
		Stream UpdateApplicationID(string idUser,string applicationID);

        /// <summary>
        /// Delete all  User Login data with application I D containing specified keyword
        /// </summary>
		/// <param name="applicationID"> Application I D</param>
		/// <returns>List of  User Login</returns>
		[OperationContract]
		Stream DeleteByApplicationID(string applicationID);

        /// <summary>
        /// Finds all  User Login data with specified is Active 
        /// </summary>
		/// <param name="isActive"> Is Active</param>
		/// <returns>List of  User Login</returns>
		[OperationContract]
		Stream FindByIsActive(string isActive);

        /// <summary>
        /// Updates  User Login's is Active which has specified idUser
        /// </summary>
		/// <param name="idUser">id User</param>
		/// <param name="isActive">is Active</param>
		/// <returns>List of  User Login</returns>
		[OperationContract]
		Stream UpdateIsActive(string idUser,string isActive);

        /// <summary>
        /// Delete all  User Login data with specified is Active 
        /// </summary>
		/// <param name="isActive"> Is Active</param>
		/// <returns>List of  User Login</returns>
		[OperationContract]
		Stream DeleteByIsActive(string isActive);
    
    }
}