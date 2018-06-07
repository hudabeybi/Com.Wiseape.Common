using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel.Web;
using Com.Wiseape.Framework;
using Com.Wiseape.Utility;
using Com.Wiseape.Factory;
using Com.Wiseape.Common.Data.Model;
using Com.Wiseape.Common.Resources.Business.Contract;
using System.ServiceModel.Activation;

namespace Com.Wiseape.Common.Resources.Webservice
{

    [AspNetCompatibilityRequirements(
            RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class UserLoginService : IUserLoginService
    {

        class Keywords
        {
            public static string UserLogin = "Common.Resources.UserLogin";
            public static string FindUserLogin = "Find.Common.Resources.UserLogin";
            public static string AddUserLogin = "Add.Common.Resources.UserLogin";
            public static string UpdateUserLogin = "Update.Common.Resources.UserLogin";
            public static string DeleteUserLogin = "Delete.Common.Resources.UserLogin";
        }

        /// <summary>
        /// Service to add UserLogin data to data store.
        /// This is a POST request.
        /// </summary>
        /// <param name="UserLoginForm">UserLogin data from POST request</param>
        /// <return>JSON string representation of operation result</return>
        [WebInvoke(Method = "POST",
                    ResponseFormat = WebMessageFormat.Json,
                    RequestFormat = WebMessageFormat.Json,
                    UriTemplate = "userlogin/add")]
        public Stream AddUserLogin(UserLogin userLoginForm)
        {
            BaseBusinessService<UserLogin> businessService = (BaseBusinessService<UserLogin>)BusinessFactory.Create(Keywords.AddUserLogin);
            OperationResult result = businessService.Add(userLoginForm);
            return result.ToJsonStream();
        }

        /// <summary>
        /// Service to update UserLogin data to data store.
        /// This is a POST request.
        /// </summary>
        /// <param name="userLoginForm">UserLogin data from POST request</param>
        /// <return>JSON string representation of operation result</return>
        [WebInvoke(Method = "POST",
                    ResponseFormat = WebMessageFormat.Json,
                    RequestFormat = WebMessageFormat.Json,
                    UriTemplate = "userlogin/update")]
        public Stream UpdateUserLogin(UserLogin userLoginForm)
        {
            BaseBusinessService<UserLogin> businessService = (BaseBusinessService<UserLogin>)BusinessFactory.Create(Keywords.UpdateUserLogin);
            OperationResult result = businessService.Update(userLoginForm);
            return result.ToJsonStream();
        }

        /// <summary>
        /// Service to delete UserLogin data from data store. 
        /// The data deleted is defined by idUser.
        /// This is a GET request.
        /// </summary>
        /// <param name="idUser">the key value of the data</param>
        /// <return>JSON string representation of operation result</return>  
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "userlogin/delete/{idUser}")]
        public Stream DeleteUserLogin(string idUser)
        {
            BaseBusinessService<UserLogin> businessService = (BaseBusinessService<UserLogin>)BusinessFactory.Create(Keywords.DeleteUserLogin);
            OperationResult result = businessService.Delete(idUser);
            return result.ToJsonStream();
        }

        /// <summary>
        /// Service to get a UserLogin data from data store. 
        /// The data retrieved is defined by idUser.
        /// This is a GET request.
        /// </summary>
        /// <param name="idUser">the key value of the data</param>
        /// <return>JSON string representation of operation result</return>    
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "userlogin/get/{idUser}")]
        public Stream GetUserLogin(string idUser)
        {
            BaseBusinessService<UserLogin> businessService = (BaseBusinessService<UserLogin>)BusinessFactory.Create(Keywords.FindUserLogin);
            OperationResult result = businessService.Get(idUser);
            return result.ToJsonStream();
        }

        /// <summary>
        /// Service to get all the UserLogin data from data store. 
        /// The data items retrieved are those who contain the keyword given. 
        /// This is a GET request.
        /// </summary>
        /// <param name="keyword">the keyword to search</param>
        /// <param name="page">the page of the data navigation</param>
        /// <param name="max">the maximum amount of data to retrieve</param>
        /// <return>JSON string representation of operation result</return>    
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "userlogin/find/{keyword}/{page}/{max}")]
        public Stream FindUserLogin(string keyword, string page, string max)
        {
            BaseBusinessService<UserLogin> businessService = (BaseBusinessService<UserLogin>)BusinessFactory.Create(Keywords.FindUserLogin);

            SelectParam selectParam = new SelectParam();
            selectParam.Keyword = keyword;
            if (keyword.ToLower() == "all")
                selectParam.Keyword = "";
            OperationResult result = businessService.FindAll(selectParam, Convert.ToInt16(page), Convert.ToInt16(max) );

            return result.ToJsonStream();
        }	
        

        /// <summary>
        /// Finds all  User Login data with username containing specified keyword
        /// </summary>
		/// <param name="username"> Username</param>
		/// <returns>List of  User Login</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "userlogin/find-by-username/{username}")]
        public Stream FindByUsername(string username)
        {
            IFindUserLoginBusinessService businessService = (IFindUserLoginBusinessService)BusinessFactory.Create(Keywords.FindUserLogin);
            OperationResult result = businessService.FindByUsername(Convert.ToString(username));
            return result.ToJsonStream();
        }		
		

        /// <summary>
        /// Updates  User Login's username which has specified idUser
        /// </summary>
		/// <param name="idUser">id User</param>
		/// <param name="username">username</param>
		/// <returns>Result of the operation</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "userlogin/update-username/{idUser}/{username}")]
        public Stream UpdateUsername(string idUser,string username)
        {
            IUpdateUserLoginBusinessService businessService = (IUpdateUserLoginBusinessService)BusinessFactory.Create(Keywords.UpdateUserLogin);
            OperationResult result = businessService.UpdateUsername(Convert.ToInt64(idUser),Convert.ToString(username) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Delete all  User Login data with username containing specified keyword
        /// </summary>
		/// <param name="username"> Username</param>
		/// <returns>List of  User Login</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "userlogin/delete-by-username/{username}")]
        public Stream DeleteByUsername(string username)
        {
            IDeleteUserLoginBusinessService businessService = (IDeleteUserLoginBusinessService)BusinessFactory.Create(Keywords.DeleteUserLogin);
            OperationResult result = businessService.DeleteByUsername(Convert.ToString(username) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Finds all  User Login data with user Password containing specified keyword
        /// </summary>
		/// <param name="userPassword"> User Password</param>
		/// <returns>List of  User Login</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "userlogin/find-by-user-password/{userPassword}")]
        public Stream FindByUserPassword(string userPassword)
        {
            IFindUserLoginBusinessService businessService = (IFindUserLoginBusinessService)BusinessFactory.Create(Keywords.FindUserLogin);
            OperationResult result = businessService.FindByUserPassword(Convert.ToString(userPassword));
            return result.ToJsonStream();
        }		
		

        /// <summary>
        /// Updates  User Login's user Password which has specified idUser
        /// </summary>
		/// <param name="idUser">id User</param>
		/// <param name="userPassword">user Password</param>
		/// <returns>Result of the operation</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "userlogin/update-user-password/{idUser}/{userPassword}")]
        public Stream UpdateUserPassword(string idUser,string userPassword)
        {
            IUpdateUserLoginBusinessService businessService = (IUpdateUserLoginBusinessService)BusinessFactory.Create(Keywords.UpdateUserLogin);
            OperationResult result = businessService.UpdateUserPassword(Convert.ToInt64(idUser),Convert.ToString(userPassword) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Delete all  User Login data with user Password containing specified keyword
        /// </summary>
		/// <param name="userPassword"> User Password</param>
		/// <returns>List of  User Login</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "userlogin/delete-by-user-password/{userPassword}")]
        public Stream DeleteByUserPassword(string userPassword)
        {
            IDeleteUserLoginBusinessService businessService = (IDeleteUserLoginBusinessService)BusinessFactory.Create(Keywords.DeleteUserLogin);
            OperationResult result = businessService.DeleteByUserPassword(Convert.ToString(userPassword) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Finds all  User Login with CreatedDate between CreatedDate1 and CreatedDate2
        /// </summary>
		/// <param name="createdDate1"> Created Date</param>
		/// <param name="createdDate2"> Created Date</param>
		/// <returns>List of  User Login</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "userlogin/find-by-created-date-between/{createdDate1}/{createdDate2}")]
        public Stream FindByCreatedDateBetween(string createdDate1,string createdDate2)
        {
            IFindUserLoginBusinessService businessService = (IFindUserLoginBusinessService)BusinessFactory.Create(Keywords.FindUserLogin);
            OperationResult result = businessService.FindByCreatedDateBetween(Convert.ToDateTime(createdDate1),Convert.ToDateTime(createdDate2) );
            return result.ToJsonStream();
        }		
		

        /// <summary>
        /// Updates  User Login's created Date which has specified idUser
        /// </summary>
		/// <param name="idUser">id User</param>
		/// <param name="createdDate">created Date</param>
		/// <returns>Result of the operation</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "userlogin/update-created-date/{idUser}/{createdDate}")]
        public Stream UpdateCreatedDate(string idUser,string createdDate)
        {
            IUpdateUserLoginBusinessService businessService = (IUpdateUserLoginBusinessService)BusinessFactory.Create(Keywords.UpdateUserLogin);
            OperationResult result = businessService.UpdateCreatedDate(Convert.ToInt64(idUser),Convert.ToDateTime(createdDate) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Delete all  User Login data with created Date containing specified keyword
        /// </summary>
		/// <param name="createdDate"> Created Date</param>
		/// <returns>List of  User Login</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "userlogin/delete-by-created-date/{createdDate}")]
        public Stream DeleteByCreatedDate(string createdDate)
        {
            IDeleteUserLoginBusinessService businessService = (IDeleteUserLoginBusinessService)BusinessFactory.Create(Keywords.DeleteUserLogin);
            OperationResult result = businessService.DeleteByCreatedDate(Convert.ToDateTime(createdDate) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Finds all  User Login data with application I D containing specified keyword
        /// </summary>
		/// <param name="applicationID"> Application I D</param>
		/// <returns>List of  User Login</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "userlogin/find-by-application-i-d/{applicationID}")]
        public Stream FindByApplicationID(string applicationID)
        {
            IFindUserLoginBusinessService businessService = (IFindUserLoginBusinessService)BusinessFactory.Create(Keywords.FindUserLogin);
            OperationResult result = businessService.FindByApplicationID(Convert.ToString(applicationID));
            return result.ToJsonStream();
        }		
		

        /// <summary>
        /// Updates  User Login's application I D which has specified idUser
        /// </summary>
		/// <param name="idUser">id User</param>
		/// <param name="applicationID">application I D</param>
		/// <returns>Result of the operation</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "userlogin/update-application-i-d/{idUser}/{applicationID}")]
        public Stream UpdateApplicationID(string idUser,string applicationID)
        {
            IUpdateUserLoginBusinessService businessService = (IUpdateUserLoginBusinessService)BusinessFactory.Create(Keywords.UpdateUserLogin);
            OperationResult result = businessService.UpdateApplicationID(Convert.ToInt64(idUser),Convert.ToString(applicationID) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Delete all  User Login data with application I D containing specified keyword
        /// </summary>
		/// <param name="applicationID"> Application I D</param>
		/// <returns>List of  User Login</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "userlogin/delete-by-application-i-d/{applicationID}")]
        public Stream DeleteByApplicationID(string applicationID)
        {
            IDeleteUserLoginBusinessService businessService = (IDeleteUserLoginBusinessService)BusinessFactory.Create(Keywords.DeleteUserLogin);
            OperationResult result = businessService.DeleteByApplicationID(Convert.ToString(applicationID) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Finds all  User Login data with specified is Active 
        /// </summary>
		/// <param name="isActive"> Is Active</param>
		/// <returns>List of  User Login</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "userlogin/find-by-is-active/{isActive}")]
        public Stream FindByIsActive(string isActive)
        {
            IFindUserLoginBusinessService businessService = (IFindUserLoginBusinessService)BusinessFactory.Create(Keywords.FindUserLogin);
            OperationResult result = businessService.FindByIsActive(Convert.ToInt16(isActive) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Updates  User Login's is Active which has specified idUser
        /// </summary>
		/// <param name="idUser">id User</param>
		/// <param name="isActive">is Active</param>
		/// <returns>List of  User Login</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "userlogin/update-is-active/{idUser}/{isActive}")]
        public Stream UpdateIsActive(string idUser,string isActive)
        {
            IUpdateUserLoginBusinessService businessService = (IUpdateUserLoginBusinessService)BusinessFactory.Create(Keywords.UpdateUserLogin);
            OperationResult result = businessService.UpdateIsActive(Convert.ToInt64(idUser),Convert.ToInt16(isActive) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Delete all  User Login data with specified is Active 
        /// </summary>
		/// <param name="isActive"> Is Active</param>
		/// <returns>List of  User Login</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "userlogin/delete-by-is-active/{isActive}")]
        public Stream DeleteByIsActive(string isActive)
        {
            IDeleteUserLoginBusinessService businessService = (IDeleteUserLoginBusinessService)BusinessFactory.Create(Keywords.DeleteUserLogin);
            OperationResult result = businessService.DeleteByIsActive(Convert.ToInt16(isActive) );
            return result.ToJsonStream();
        }	
		
 
	}
}