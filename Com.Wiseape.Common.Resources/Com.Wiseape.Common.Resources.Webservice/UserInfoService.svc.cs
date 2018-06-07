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
    public class UserInfoService : IUserInfoService
    {

        class Keywords
        {
            public static string UserInfo = "Common.Resources.UserInfo";
            public static string FindUserInfo = "Find.Common.Resources.UserInfo";
            public static string AddUserInfo = "Add.Common.Resources.UserInfo";
            public static string UpdateUserInfo = "Update.Common.Resources.UserInfo";
            public static string DeleteUserInfo = "Delete.Common.Resources.UserInfo";
        }

        /// <summary>
        /// Service to add UserInfo data to data store.
        /// This is a POST request.
        /// </summary>
        /// <param name="UserInfoForm">UserInfo data from POST request</param>
        /// <return>JSON string representation of operation result</return>
        [WebInvoke(Method = "POST",
                    ResponseFormat = WebMessageFormat.Json,
                    RequestFormat = WebMessageFormat.Json,
                    UriTemplate = "userinfo/add")]
        public Stream AddUserInfo(UserInfo userInfoForm)
        {
            BaseBusinessService<UserInfo> businessService = (BaseBusinessService<UserInfo>)BusinessFactory.Create(Keywords.AddUserInfo);
            OperationResult result = businessService.Add(userInfoForm);
            return result.ToJsonStream();
        }

        /// <summary>
        /// Service to update UserInfo data to data store.
        /// This is a POST request.
        /// </summary>
        /// <param name="userInfoForm">UserInfo data from POST request</param>
        /// <return>JSON string representation of operation result</return>
        [WebInvoke(Method = "POST",
                    ResponseFormat = WebMessageFormat.Json,
                    RequestFormat = WebMessageFormat.Json,
                    UriTemplate = "userinfo/update")]
        public Stream UpdateUserInfo(UserInfo userInfoForm)
        {
            BaseBusinessService<UserInfo> businessService = (BaseBusinessService<UserInfo>)BusinessFactory.Create(Keywords.UpdateUserInfo);
            OperationResult result = businessService.Update(userInfoForm);
            return result.ToJsonStream();
        }

        /// <summary>
        /// Service to delete UserInfo data from data store. 
        /// The data deleted is defined by idUserInfo.
        /// This is a GET request.
        /// </summary>
        /// <param name="idUserInfo">the key value of the data</param>
        /// <return>JSON string representation of operation result</return>  
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "userinfo/delete/{idUserInfo}")]
        public Stream DeleteUserInfo(string idUserInfo)
        {
            BaseBusinessService<UserInfo> businessService = (BaseBusinessService<UserInfo>)BusinessFactory.Create(Keywords.DeleteUserInfo);
            OperationResult result = businessService.Delete(idUserInfo);
            return result.ToJsonStream();
        }

        /// <summary>
        /// Service to get a UserInfo data from data store. 
        /// The data retrieved is defined by idUserInfo.
        /// This is a GET request.
        /// </summary>
        /// <param name="idUserInfo">the key value of the data</param>
        /// <return>JSON string representation of operation result</return>    
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "userinfo/get/{idUserInfo}")]
        public Stream GetUserInfo(string idUserInfo)
        {
            BaseBusinessService<UserInfo> businessService = (BaseBusinessService<UserInfo>)BusinessFactory.Create(Keywords.FindUserInfo);
            OperationResult result = businessService.Get(idUserInfo);
            return result.ToJsonStream();
        }

        /// <summary>
        /// Service to get all the UserInfo data from data store. 
        /// The data items retrieved are those who contain the keyword given. 
        /// This is a GET request.
        /// </summary>
        /// <param name="keyword">the keyword to search</param>
        /// <param name="page">the page of the data navigation</param>
        /// <param name="max">the maximum amount of data to retrieve</param>
        /// <return>JSON string representation of operation result</return>    
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "userinfo/find/{keyword}/{page}/{max}")]
        public Stream FindUserInfo(string keyword, string page, string max)
        {
            BaseBusinessService<UserInfo> businessService = (BaseBusinessService<UserInfo>)BusinessFactory.Create(Keywords.FindUserInfo);

            SelectParam selectParam = new SelectParam();
            selectParam.Keyword = keyword;
            if (keyword.ToLower() == "all")
                selectParam.Keyword = "";
            OperationResult result = businessService.FindAll(selectParam, Convert.ToInt16(page), Convert.ToInt16(max) );

            return result.ToJsonStream();
        }	
        

        /// <summary>
        /// Finds all  User Info data with first Name containing specified keyword
        /// </summary>
		/// <param name="firstName"> First Name</param>
		/// <returns>List of  User Info</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "userinfo/find-by-first-name/{firstName}")]
        public Stream FindByFirstName(string firstName)
        {
            IFindUserInfoBusinessService businessService = (IFindUserInfoBusinessService)BusinessFactory.Create(Keywords.FindUserInfo);
            OperationResult result = businessService.FindByFirstName(Convert.ToString(firstName));
            return result.ToJsonStream();
        }		
		

        /// <summary>
        /// Updates  User Info's first Name which has specified idUserInfo
        /// </summary>
		/// <param name="idUserInfo">id User Info</param>
		/// <param name="firstName">first Name</param>
		/// <returns>Result of the operation</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "userinfo/update-first-name/{idUserInfo}/{firstName}")]
        public Stream UpdateFirstName(string idUserInfo,string firstName)
        {
            IUpdateUserInfoBusinessService businessService = (IUpdateUserInfoBusinessService)BusinessFactory.Create(Keywords.UpdateUserInfo);
            OperationResult result = businessService.UpdateFirstName(Convert.ToInt64(idUserInfo),Convert.ToString(firstName) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Delete all  User Info data with first Name containing specified keyword
        /// </summary>
		/// <param name="firstName"> First Name</param>
		/// <returns>List of  User Info</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "userinfo/delete-by-first-name/{firstName}")]
        public Stream DeleteByFirstName(string firstName)
        {
            IDeleteUserInfoBusinessService businessService = (IDeleteUserInfoBusinessService)BusinessFactory.Create(Keywords.DeleteUserInfo);
            OperationResult result = businessService.DeleteByFirstName(Convert.ToString(firstName) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Finds all  User Info data with last Name containing specified keyword
        /// </summary>
		/// <param name="lastName"> Last Name</param>
		/// <returns>List of  User Info</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "userinfo/find-by-last-name/{lastName}")]
        public Stream FindByLastName(string lastName)
        {
            IFindUserInfoBusinessService businessService = (IFindUserInfoBusinessService)BusinessFactory.Create(Keywords.FindUserInfo);
            OperationResult result = businessService.FindByLastName(Convert.ToString(lastName));
            return result.ToJsonStream();
        }		
		

        /// <summary>
        /// Updates  User Info's last Name which has specified idUserInfo
        /// </summary>
		/// <param name="idUserInfo">id User Info</param>
		/// <param name="lastName">last Name</param>
		/// <returns>Result of the operation</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "userinfo/update-last-name/{idUserInfo}/{lastName}")]
        public Stream UpdateLastName(string idUserInfo,string lastName)
        {
            IUpdateUserInfoBusinessService businessService = (IUpdateUserInfoBusinessService)BusinessFactory.Create(Keywords.UpdateUserInfo);
            OperationResult result = businessService.UpdateLastName(Convert.ToInt64(idUserInfo),Convert.ToString(lastName) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Delete all  User Info data with last Name containing specified keyword
        /// </summary>
		/// <param name="lastName"> Last Name</param>
		/// <returns>List of  User Info</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "userinfo/delete-by-last-name/{lastName}")]
        public Stream DeleteByLastName(string lastName)
        {
            IDeleteUserInfoBusinessService businessService = (IDeleteUserInfoBusinessService)BusinessFactory.Create(Keywords.DeleteUserInfo);
            OperationResult result = businessService.DeleteByLastName(Convert.ToString(lastName) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Finds all  User Info data with mobile Phone containing specified keyword
        /// </summary>
		/// <param name="mobilePhone"> Mobile Phone</param>
		/// <returns>List of  User Info</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "userinfo/find-by-mobile-phone/{mobilePhone}")]
        public Stream FindByMobilePhone(string mobilePhone)
        {
            IFindUserInfoBusinessService businessService = (IFindUserInfoBusinessService)BusinessFactory.Create(Keywords.FindUserInfo);
            OperationResult result = businessService.FindByMobilePhone(Convert.ToString(mobilePhone));
            return result.ToJsonStream();
        }		
		

        /// <summary>
        /// Updates  User Info's mobile Phone which has specified idUserInfo
        /// </summary>
		/// <param name="idUserInfo">id User Info</param>
		/// <param name="mobilePhone">mobile Phone</param>
		/// <returns>Result of the operation</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "userinfo/update-mobile-phone/{idUserInfo}/{mobilePhone}")]
        public Stream UpdateMobilePhone(string idUserInfo,string mobilePhone)
        {
            IUpdateUserInfoBusinessService businessService = (IUpdateUserInfoBusinessService)BusinessFactory.Create(Keywords.UpdateUserInfo);
            OperationResult result = businessService.UpdateMobilePhone(Convert.ToInt64(idUserInfo),Convert.ToString(mobilePhone) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Delete all  User Info data with mobile Phone containing specified keyword
        /// </summary>
		/// <param name="mobilePhone"> Mobile Phone</param>
		/// <returns>List of  User Info</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "userinfo/delete-by-mobile-phone/{mobilePhone}")]
        public Stream DeleteByMobilePhone(string mobilePhone)
        {
            IDeleteUserInfoBusinessService businessService = (IDeleteUserInfoBusinessService)BusinessFactory.Create(Keywords.DeleteUserInfo);
            OperationResult result = businessService.DeleteByMobilePhone(Convert.ToString(mobilePhone) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Finds all  User Info data with phone containing specified keyword
        /// </summary>
		/// <param name="phone"> Phone</param>
		/// <returns>List of  User Info</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "userinfo/find-by-phone/{phone}")]
        public Stream FindByPhone(string phone)
        {
            IFindUserInfoBusinessService businessService = (IFindUserInfoBusinessService)BusinessFactory.Create(Keywords.FindUserInfo);
            OperationResult result = businessService.FindByPhone(Convert.ToString(phone));
            return result.ToJsonStream();
        }		
		

        /// <summary>
        /// Updates  User Info's phone which has specified idUserInfo
        /// </summary>
		/// <param name="idUserInfo">id User Info</param>
		/// <param name="phone">phone</param>
		/// <returns>Result of the operation</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "userinfo/update-phone/{idUserInfo}/{phone}")]
        public Stream UpdatePhone(string idUserInfo,string phone)
        {
            IUpdateUserInfoBusinessService businessService = (IUpdateUserInfoBusinessService)BusinessFactory.Create(Keywords.UpdateUserInfo);
            OperationResult result = businessService.UpdatePhone(Convert.ToInt64(idUserInfo),Convert.ToString(phone) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Delete all  User Info data with phone containing specified keyword
        /// </summary>
		/// <param name="phone"> Phone</param>
		/// <returns>List of  User Info</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "userinfo/delete-by-phone/{phone}")]
        public Stream DeleteByPhone(string phone)
        {
            IDeleteUserInfoBusinessService businessService = (IDeleteUserInfoBusinessService)BusinessFactory.Create(Keywords.DeleteUserInfo);
            OperationResult result = businessService.DeleteByPhone(Convert.ToString(phone) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Finds all  User Info data with address containing specified keyword
        /// </summary>
		/// <param name="address"> Address</param>
		/// <returns>List of  User Info</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "userinfo/find-by-address/{address}")]
        public Stream FindByAddress(string address)
        {
            IFindUserInfoBusinessService businessService = (IFindUserInfoBusinessService)BusinessFactory.Create(Keywords.FindUserInfo);
            OperationResult result = businessService.FindByAddress(Convert.ToString(address));
            return result.ToJsonStream();
        }		
		

        /// <summary>
        /// Updates  User Info's address which has specified idUserInfo
        /// </summary>
		/// <param name="idUserInfo">id User Info</param>
		/// <param name="address">address</param>
		/// <returns>Result of the operation</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "userinfo/update-address/{idUserInfo}/{address}")]
        public Stream UpdateAddress(string idUserInfo,string address)
        {
            IUpdateUserInfoBusinessService businessService = (IUpdateUserInfoBusinessService)BusinessFactory.Create(Keywords.UpdateUserInfo);
            OperationResult result = businessService.UpdateAddress(Convert.ToInt64(idUserInfo),Convert.ToString(address) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Delete all  User Info data with address containing specified keyword
        /// </summary>
		/// <param name="address"> Address</param>
		/// <returns>List of  User Info</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "userinfo/delete-by-address/{address}")]
        public Stream DeleteByAddress(string address)
        {
            IDeleteUserInfoBusinessService businessService = (IDeleteUserInfoBusinessService)BusinessFactory.Create(Keywords.DeleteUserInfo);
            OperationResult result = businessService.DeleteByAddress(Convert.ToString(address) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Finds all  User Info data with specified user Id 
        /// </summary>
		/// <param name="userId"> User Id</param>
		/// <returns>List of  User Info</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "userinfo/find-by-user-id/{userId}")]
        public Stream FindByUserId(string userId)
        {
            IFindUserInfoBusinessService businessService = (IFindUserInfoBusinessService)BusinessFactory.Create(Keywords.FindUserInfo);
            OperationResult result = businessService.FindByUserId(Convert.ToInt64(userId) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Updates  User Info's user Id which has specified idUserInfo
        /// </summary>
		/// <param name="idUserInfo">id User Info</param>
		/// <param name="userId">user Id</param>
		/// <returns>List of  User Info</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "userinfo/update-user-id/{idUserInfo}/{userId}")]
        public Stream UpdateUserId(string idUserInfo,string userId)
        {
            IUpdateUserInfoBusinessService businessService = (IUpdateUserInfoBusinessService)BusinessFactory.Create(Keywords.UpdateUserInfo);
            OperationResult result = businessService.UpdateUserId(Convert.ToInt64(idUserInfo),Convert.ToInt64(userId) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Delete all  User Info data with specified user Id 
        /// </summary>
		/// <param name="userId"> User Id</param>
		/// <returns>List of  User Info</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "userinfo/delete-by-user-id/{userId}")]
        public Stream DeleteByUserId(string userId)
        {
            IDeleteUserInfoBusinessService businessService = (IDeleteUserInfoBusinessService)BusinessFactory.Create(Keywords.DeleteUserInfo);
            OperationResult result = businessService.DeleteByUserId(Convert.ToInt64(userId) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Finds all  User Info data with specified user Id, gender Id 
        /// </summary>
		/// <param name="userId"> User Id</param>
		/// <param name="genderId"> Gender Id</param>
		/// <returns>List of  User Info</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "userinfo/find-by-user-id-and-gender-id/{userId}/{genderId}")]
        public Stream FindByUserIdAndGenderId(string userId,string genderId)
        {
            IFindUserInfoBusinessService businessService = (IFindUserInfoBusinessService)BusinessFactory.Create(Keywords.FindUserInfo);
            OperationResult result = businessService.FindByUserIdAndGenderId(Convert.ToInt64(userId),Convert.ToInt16(genderId) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Updates  User Info's user Id, gender Id which has specified idUserInfo
        /// </summary>
		/// <param name="idUserInfo">id User Info</param>
		/// <param name="userId">user Id</param>
		/// <param name="genderId">gender Id</param>
		/// <returns>List of  User Info</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "userinfo/update-user-id-and-gender-id/{idUserInfo}/{userId}/{genderId}")]
        public Stream UpdateUserIdAndGenderId(string idUserInfo,string userId,string genderId)
        {
            IUpdateUserInfoBusinessService businessService = (IUpdateUserInfoBusinessService)BusinessFactory.Create(Keywords.UpdateUserInfo);
            OperationResult result = businessService.UpdateUserIdAndGenderId(Convert.ToInt64(idUserInfo),Convert.ToInt64(userId),Convert.ToInt16(genderId) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Delete all  User Info data with specified user Id, gender Id 
        /// </summary>
		/// <param name="userId"> User Id</param>
		/// <param name="genderId"> Gender Id</param>
		/// <returns>List of  User Info</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "userinfo/delete-by-user-id-and-gender-id/{userId}/{genderId}")]
        public Stream DeleteByUserIdAndGenderId(string userId,string genderId)
        {
            IDeleteUserInfoBusinessService businessService = (IDeleteUserInfoBusinessService)BusinessFactory.Create(Keywords.DeleteUserInfo);
            OperationResult result = businessService.DeleteByUserIdAndGenderId(Convert.ToInt64(userId),Convert.ToInt16(genderId) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Finds all  User Info data with specified user Id, gender Id, city Id 
        /// </summary>
		/// <param name="userId"> User Id</param>
		/// <param name="genderId"> Gender Id</param>
		/// <param name="cityId"> City Id</param>
		/// <returns>List of  User Info</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "userinfo/find-by-user-id-and-gender-id-and-city-id/{userId}/{genderId}/{cityId}")]
        public Stream FindByUserIdAndGenderIdAndCityId(string userId,string genderId,string cityId)
        {
            IFindUserInfoBusinessService businessService = (IFindUserInfoBusinessService)BusinessFactory.Create(Keywords.FindUserInfo);
            OperationResult result = businessService.FindByUserIdAndGenderIdAndCityId(Convert.ToInt64(userId),Convert.ToInt16(genderId),Convert.ToInt16(cityId) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Updates  User Info's user Id, gender Id, city Id which has specified idUserInfo
        /// </summary>
		/// <param name="idUserInfo">id User Info</param>
		/// <param name="userId">user Id</param>
		/// <param name="genderId">gender Id</param>
		/// <param name="cityId">city Id</param>
		/// <returns>List of  User Info</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "userinfo/update-user-id-and-gender-id-and-city-id/{idUserInfo}/{userId}/{genderId}/{cityId}")]
        public Stream UpdateUserIdAndGenderIdAndCityId(string idUserInfo,string userId,string genderId,string cityId)
        {
            IUpdateUserInfoBusinessService businessService = (IUpdateUserInfoBusinessService)BusinessFactory.Create(Keywords.UpdateUserInfo);
            OperationResult result = businessService.UpdateUserIdAndGenderIdAndCityId(Convert.ToInt64(idUserInfo),Convert.ToInt64(userId),Convert.ToInt16(genderId),Convert.ToInt16(cityId) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Delete all  User Info data with specified user Id, gender Id, city Id 
        /// </summary>
		/// <param name="userId"> User Id</param>
		/// <param name="genderId"> Gender Id</param>
		/// <param name="cityId"> City Id</param>
		/// <returns>List of  User Info</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "userinfo/delete-by-user-id-and-gender-id-and-city-id/{userId}/{genderId}/{cityId}")]
        public Stream DeleteByUserIdAndGenderIdAndCityId(string userId,string genderId,string cityId)
        {
            IDeleteUserInfoBusinessService businessService = (IDeleteUserInfoBusinessService)BusinessFactory.Create(Keywords.DeleteUserInfo);
            OperationResult result = businessService.DeleteByUserIdAndGenderIdAndCityId(Convert.ToInt64(userId),Convert.ToInt16(genderId),Convert.ToInt16(cityId) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Finds all  User Info data with specified user Id, city Id 
        /// </summary>
		/// <param name="userId"> User Id</param>
		/// <param name="cityId"> City Id</param>
		/// <returns>List of  User Info</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "userinfo/find-by-user-id-and-city-id/{userId}/{cityId}")]
        public Stream FindByUserIdAndCityId(string userId,string cityId)
        {
            IFindUserInfoBusinessService businessService = (IFindUserInfoBusinessService)BusinessFactory.Create(Keywords.FindUserInfo);
            OperationResult result = businessService.FindByUserIdAndCityId(Convert.ToInt64(userId),Convert.ToInt16(cityId) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Updates  User Info's user Id, city Id which has specified idUserInfo
        /// </summary>
		/// <param name="idUserInfo">id User Info</param>
		/// <param name="userId">user Id</param>
		/// <param name="cityId">city Id</param>
		/// <returns>List of  User Info</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "userinfo/update-user-id-and-city-id/{idUserInfo}/{userId}/{cityId}")]
        public Stream UpdateUserIdAndCityId(string idUserInfo,string userId,string cityId)
        {
            IUpdateUserInfoBusinessService businessService = (IUpdateUserInfoBusinessService)BusinessFactory.Create(Keywords.UpdateUserInfo);
            OperationResult result = businessService.UpdateUserIdAndCityId(Convert.ToInt64(idUserInfo),Convert.ToInt64(userId),Convert.ToInt16(cityId) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Delete all  User Info data with specified user Id, city Id 
        /// </summary>
		/// <param name="userId"> User Id</param>
		/// <param name="cityId"> City Id</param>
		/// <returns>List of  User Info</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "userinfo/delete-by-user-id-and-city-id/{userId}/{cityId}")]
        public Stream DeleteByUserIdAndCityId(string userId,string cityId)
        {
            IDeleteUserInfoBusinessService businessService = (IDeleteUserInfoBusinessService)BusinessFactory.Create(Keywords.DeleteUserInfo);
            OperationResult result = businessService.DeleteByUserIdAndCityId(Convert.ToInt64(userId),Convert.ToInt16(cityId) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Finds all  User Info data with specified gender Id 
        /// </summary>
		/// <param name="genderId"> Gender Id</param>
		/// <returns>List of  User Info</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "userinfo/find-by-gender-id/{genderId}")]
        public Stream FindByGenderId(string genderId)
        {
            IFindUserInfoBusinessService businessService = (IFindUserInfoBusinessService)BusinessFactory.Create(Keywords.FindUserInfo);
            OperationResult result = businessService.FindByGenderId(Convert.ToInt16(genderId) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Updates  User Info's gender Id which has specified idUserInfo
        /// </summary>
		/// <param name="idUserInfo">id User Info</param>
		/// <param name="genderId">gender Id</param>
		/// <returns>List of  User Info</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "userinfo/update-gender-id/{idUserInfo}/{genderId}")]
        public Stream UpdateGenderId(string idUserInfo,string genderId)
        {
            IUpdateUserInfoBusinessService businessService = (IUpdateUserInfoBusinessService)BusinessFactory.Create(Keywords.UpdateUserInfo);
            OperationResult result = businessService.UpdateGenderId(Convert.ToInt64(idUserInfo),Convert.ToInt16(genderId) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Delete all  User Info data with specified gender Id 
        /// </summary>
		/// <param name="genderId"> Gender Id</param>
		/// <returns>List of  User Info</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "userinfo/delete-by-gender-id/{genderId}")]
        public Stream DeleteByGenderId(string genderId)
        {
            IDeleteUserInfoBusinessService businessService = (IDeleteUserInfoBusinessService)BusinessFactory.Create(Keywords.DeleteUserInfo);
            OperationResult result = businessService.DeleteByGenderId(Convert.ToInt16(genderId) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Finds all  User Info data with specified gender Id, city Id 
        /// </summary>
		/// <param name="genderId"> Gender Id</param>
		/// <param name="cityId"> City Id</param>
		/// <returns>List of  User Info</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "userinfo/find-by-gender-id-and-city-id/{genderId}/{cityId}")]
        public Stream FindByGenderIdAndCityId(string genderId,string cityId)
        {
            IFindUserInfoBusinessService businessService = (IFindUserInfoBusinessService)BusinessFactory.Create(Keywords.FindUserInfo);
            OperationResult result = businessService.FindByGenderIdAndCityId(Convert.ToInt16(genderId),Convert.ToInt16(cityId) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Updates  User Info's gender Id, city Id which has specified idUserInfo
        /// </summary>
		/// <param name="idUserInfo">id User Info</param>
		/// <param name="genderId">gender Id</param>
		/// <param name="cityId">city Id</param>
		/// <returns>List of  User Info</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "userinfo/update-gender-id-and-city-id/{idUserInfo}/{genderId}/{cityId}")]
        public Stream UpdateGenderIdAndCityId(string idUserInfo,string genderId,string cityId)
        {
            IUpdateUserInfoBusinessService businessService = (IUpdateUserInfoBusinessService)BusinessFactory.Create(Keywords.UpdateUserInfo);
            OperationResult result = businessService.UpdateGenderIdAndCityId(Convert.ToInt64(idUserInfo),Convert.ToInt16(genderId),Convert.ToInt16(cityId) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Delete all  User Info data with specified gender Id, city Id 
        /// </summary>
		/// <param name="genderId"> Gender Id</param>
		/// <param name="cityId"> City Id</param>
		/// <returns>List of  User Info</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "userinfo/delete-by-gender-id-and-city-id/{genderId}/{cityId}")]
        public Stream DeleteByGenderIdAndCityId(string genderId,string cityId)
        {
            IDeleteUserInfoBusinessService businessService = (IDeleteUserInfoBusinessService)BusinessFactory.Create(Keywords.DeleteUserInfo);
            OperationResult result = businessService.DeleteByGenderIdAndCityId(Convert.ToInt16(genderId),Convert.ToInt16(cityId) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Finds all  User Info data with specified city Id 
        /// </summary>
		/// <param name="cityId"> City Id</param>
		/// <returns>List of  User Info</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "userinfo/find-by-city-id/{cityId}")]
        public Stream FindByCityId(string cityId)
        {
            IFindUserInfoBusinessService businessService = (IFindUserInfoBusinessService)BusinessFactory.Create(Keywords.FindUserInfo);
            OperationResult result = businessService.FindByCityId(Convert.ToInt16(cityId) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Updates  User Info's city Id which has specified idUserInfo
        /// </summary>
		/// <param name="idUserInfo">id User Info</param>
		/// <param name="cityId">city Id</param>
		/// <returns>List of  User Info</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "userinfo/update-city-id/{idUserInfo}/{cityId}")]
        public Stream UpdateCityId(string idUserInfo,string cityId)
        {
            IUpdateUserInfoBusinessService businessService = (IUpdateUserInfoBusinessService)BusinessFactory.Create(Keywords.UpdateUserInfo);
            OperationResult result = businessService.UpdateCityId(Convert.ToInt64(idUserInfo),Convert.ToInt16(cityId) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Delete all  User Info data with specified city Id 
        /// </summary>
		/// <param name="cityId"> City Id</param>
		/// <returns>List of  User Info</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "userinfo/delete-by-city-id/{cityId}")]
        public Stream DeleteByCityId(string cityId)
        {
            IDeleteUserInfoBusinessService businessService = (IDeleteUserInfoBusinessService)BusinessFactory.Create(Keywords.DeleteUserInfo);
            OperationResult result = businessService.DeleteByCityId(Convert.ToInt16(cityId) );
            return result.ToJsonStream();
        }	
		
 
	}
}