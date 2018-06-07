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
    /// Interface for UserInfo Service
    /// </summary>
    [ServiceContract]
    public interface IUserInfoService
    {
    
        /// <summary>
        /// Service to add UserInfo data to data store.
        /// This is a POST request.
        /// </summary>
        /// <param name="UserInfoForm">UserInfo data from POST request</param>
        /// <return>JSON string representation of operation result</return>
        [OperationContract]
        Stream AddUserInfo(UserInfo userInfoForm);

        /// <summary>
        /// Service to update UserInfo data to data store.
        /// This is a POST request.
        /// </summary>
        /// <param name="userInfoForm">UserInfo data from POST request</param>
        /// <return>JSON string representation of operation result</return>
        [OperationContract]
        Stream UpdateUserInfo(UserInfo userInfoForm);

        /// <summary>
        /// Service to delete UserInfo data from data store. 
        /// The data deleted is defined by idUserInfo.
        /// This is a GET request.
        /// </summary>
        /// <param name="idUserInfo">the key value of the data</param>
        /// <return>JSON string representation of operation result</return>  
        [OperationContract]
        Stream DeleteUserInfo(string idUserInfo);

        /// <summary>
        /// Service to get a UserInfo data from data store. 
        /// The data retrieved is defined by idUserInfo.
        /// This is a GET request.
        /// </summary>
        /// <param name="idUserInfo">the key value of the data</param>
        /// <return>JSON string representation of operation result</return>    
        [OperationContract]
       	Stream GetUserInfo(string idUserInfo);

        /// <summary>
        /// Service to get all the UserInfo data from data store. 
        /// The data items retrieved are those who contain the keyword given. 
        /// This is a GET request.
        /// </summary>
        /// <param name="keyword">the keyword to search</param>
        /// <param name="page">the page of the data navigation</param>
        /// <param name="max">the maximum amount of data to retrieve</param>
        /// <return>JSON string representation of operation result</return>    
		[OperationContract]
        Stream FindUserInfo(string keyword, string page, string max);	
        

        /// <summary>
        /// Finds all  User Info data with first Name containing specified keyword
        /// </summary>
		/// <param name="firstName"> First Name</param>
		/// <returns>List of  User Info</returns>
		[OperationContract]
		Stream FindByFirstName(string firstName);

        /// <summary>
        /// Updates  User Info's first Name which has specified idUserInfo
        /// </summary>
		/// <param name="idUserInfo">id User Info</param>
		/// <param name="firstName">first Name</param>
		/// <returns>List of  User Info</returns>
		[OperationContract]
		Stream UpdateFirstName(string idUserInfo,string firstName);

        /// <summary>
        /// Delete all  User Info data with first Name containing specified keyword
        /// </summary>
		/// <param name="firstName"> First Name</param>
		/// <returns>List of  User Info</returns>
		[OperationContract]
		Stream DeleteByFirstName(string firstName);

        /// <summary>
        /// Finds all  User Info data with last Name containing specified keyword
        /// </summary>
		/// <param name="lastName"> Last Name</param>
		/// <returns>List of  User Info</returns>
		[OperationContract]
		Stream FindByLastName(string lastName);

        /// <summary>
        /// Updates  User Info's last Name which has specified idUserInfo
        /// </summary>
		/// <param name="idUserInfo">id User Info</param>
		/// <param name="lastName">last Name</param>
		/// <returns>List of  User Info</returns>
		[OperationContract]
		Stream UpdateLastName(string idUserInfo,string lastName);

        /// <summary>
        /// Delete all  User Info data with last Name containing specified keyword
        /// </summary>
		/// <param name="lastName"> Last Name</param>
		/// <returns>List of  User Info</returns>
		[OperationContract]
		Stream DeleteByLastName(string lastName);

        /// <summary>
        /// Finds all  User Info data with mobile Phone containing specified keyword
        /// </summary>
		/// <param name="mobilePhone"> Mobile Phone</param>
		/// <returns>List of  User Info</returns>
		[OperationContract]
		Stream FindByMobilePhone(string mobilePhone);

        /// <summary>
        /// Updates  User Info's mobile Phone which has specified idUserInfo
        /// </summary>
		/// <param name="idUserInfo">id User Info</param>
		/// <param name="mobilePhone">mobile Phone</param>
		/// <returns>List of  User Info</returns>
		[OperationContract]
		Stream UpdateMobilePhone(string idUserInfo,string mobilePhone);

        /// <summary>
        /// Delete all  User Info data with mobile Phone containing specified keyword
        /// </summary>
		/// <param name="mobilePhone"> Mobile Phone</param>
		/// <returns>List of  User Info</returns>
		[OperationContract]
		Stream DeleteByMobilePhone(string mobilePhone);

        /// <summary>
        /// Finds all  User Info data with phone containing specified keyword
        /// </summary>
		/// <param name="phone"> Phone</param>
		/// <returns>List of  User Info</returns>
		[OperationContract]
		Stream FindByPhone(string phone);

        /// <summary>
        /// Updates  User Info's phone which has specified idUserInfo
        /// </summary>
		/// <param name="idUserInfo">id User Info</param>
		/// <param name="phone">phone</param>
		/// <returns>List of  User Info</returns>
		[OperationContract]
		Stream UpdatePhone(string idUserInfo,string phone);

        /// <summary>
        /// Delete all  User Info data with phone containing specified keyword
        /// </summary>
		/// <param name="phone"> Phone</param>
		/// <returns>List of  User Info</returns>
		[OperationContract]
		Stream DeleteByPhone(string phone);

        /// <summary>
        /// Finds all  User Info data with address containing specified keyword
        /// </summary>
		/// <param name="address"> Address</param>
		/// <returns>List of  User Info</returns>
		[OperationContract]
		Stream FindByAddress(string address);

        /// <summary>
        /// Updates  User Info's address which has specified idUserInfo
        /// </summary>
		/// <param name="idUserInfo">id User Info</param>
		/// <param name="address">address</param>
		/// <returns>List of  User Info</returns>
		[OperationContract]
		Stream UpdateAddress(string idUserInfo,string address);

        /// <summary>
        /// Delete all  User Info data with address containing specified keyword
        /// </summary>
		/// <param name="address"> Address</param>
		/// <returns>List of  User Info</returns>
		[OperationContract]
		Stream DeleteByAddress(string address);

        /// <summary>
        /// Finds all  User Info data with specified user Id 
        /// </summary>
		/// <param name="userId"> User Id</param>
		/// <returns>List of  User Info</returns>
		[OperationContract]
		Stream FindByUserId(string userId);

        /// <summary>
        /// Updates  User Info's user Id which has specified idUserInfo
        /// </summary>
		/// <param name="idUserInfo">id User Info</param>
		/// <param name="userId">user Id</param>
		/// <returns>List of  User Info</returns>
		[OperationContract]
		Stream UpdateUserId(string idUserInfo,string userId);

        /// <summary>
        /// Delete all  User Info data with specified user Id 
        /// </summary>
		/// <param name="userId"> User Id</param>
		/// <returns>List of  User Info</returns>
		[OperationContract]
		Stream DeleteByUserId(string userId);

        /// <summary>
        /// Finds all  User Info data with specified user Id, gender Id 
        /// </summary>
		/// <param name="userId"> User Id</param>
		/// <param name="genderId"> Gender Id</param>
		/// <returns>List of  User Info</returns>
		[OperationContract]
		Stream FindByUserIdAndGenderId(string userId,string genderId);

        /// <summary>
        /// Updates  User Info's user Id, gender Id which has specified idUserInfo
        /// </summary>
		/// <param name="idUserInfo">id User Info</param>
		/// <param name="userId">user Id</param>
		/// <param name="genderId">gender Id</param>
		/// <returns>List of  User Info</returns>
		[OperationContract]
		Stream UpdateUserIdAndGenderId(string idUserInfo,string userId,string genderId);

        /// <summary>
        /// Delete all  User Info data with specified user Id, gender Id 
        /// </summary>
		/// <param name="userId"> User Id</param>
		/// <param name="genderId"> Gender Id</param>
		/// <returns>List of  User Info</returns>
		[OperationContract]
		Stream DeleteByUserIdAndGenderId(string userId,string genderId);

        /// <summary>
        /// Finds all  User Info data with specified user Id, gender Id, city Id 
        /// </summary>
		/// <param name="userId"> User Id</param>
		/// <param name="genderId"> Gender Id</param>
		/// <param name="cityId"> City Id</param>
		/// <returns>List of  User Info</returns>
		[OperationContract]
		Stream FindByUserIdAndGenderIdAndCityId(string userId,string genderId,string cityId);

        /// <summary>
        /// Updates  User Info's user Id, gender Id, city Id which has specified idUserInfo
        /// </summary>
		/// <param name="idUserInfo">id User Info</param>
		/// <param name="userId">user Id</param>
		/// <param name="genderId">gender Id</param>
		/// <param name="cityId">city Id</param>
		/// <returns>List of  User Info</returns>
		[OperationContract]
		Stream UpdateUserIdAndGenderIdAndCityId(string idUserInfo,string userId,string genderId,string cityId);

        /// <summary>
        /// Delete all  User Info data with specified user Id, gender Id, city Id 
        /// </summary>
		/// <param name="userId"> User Id</param>
		/// <param name="genderId"> Gender Id</param>
		/// <param name="cityId"> City Id</param>
		/// <returns>List of  User Info</returns>
		[OperationContract]
		Stream DeleteByUserIdAndGenderIdAndCityId(string userId,string genderId,string cityId);

        /// <summary>
        /// Finds all  User Info data with specified user Id, city Id 
        /// </summary>
		/// <param name="userId"> User Id</param>
		/// <param name="cityId"> City Id</param>
		/// <returns>List of  User Info</returns>
		[OperationContract]
		Stream FindByUserIdAndCityId(string userId,string cityId);

        /// <summary>
        /// Updates  User Info's user Id, city Id which has specified idUserInfo
        /// </summary>
		/// <param name="idUserInfo">id User Info</param>
		/// <param name="userId">user Id</param>
		/// <param name="cityId">city Id</param>
		/// <returns>List of  User Info</returns>
		[OperationContract]
		Stream UpdateUserIdAndCityId(string idUserInfo,string userId,string cityId);

        /// <summary>
        /// Delete all  User Info data with specified user Id, city Id 
        /// </summary>
		/// <param name="userId"> User Id</param>
		/// <param name="cityId"> City Id</param>
		/// <returns>List of  User Info</returns>
		[OperationContract]
		Stream DeleteByUserIdAndCityId(string userId,string cityId);

        /// <summary>
        /// Finds all  User Info data with specified gender Id 
        /// </summary>
		/// <param name="genderId"> Gender Id</param>
		/// <returns>List of  User Info</returns>
		[OperationContract]
		Stream FindByGenderId(string genderId);

        /// <summary>
        /// Updates  User Info's gender Id which has specified idUserInfo
        /// </summary>
		/// <param name="idUserInfo">id User Info</param>
		/// <param name="genderId">gender Id</param>
		/// <returns>List of  User Info</returns>
		[OperationContract]
		Stream UpdateGenderId(string idUserInfo,string genderId);

        /// <summary>
        /// Delete all  User Info data with specified gender Id 
        /// </summary>
		/// <param name="genderId"> Gender Id</param>
		/// <returns>List of  User Info</returns>
		[OperationContract]
		Stream DeleteByGenderId(string genderId);

        /// <summary>
        /// Finds all  User Info data with specified gender Id, city Id 
        /// </summary>
		/// <param name="genderId"> Gender Id</param>
		/// <param name="cityId"> City Id</param>
		/// <returns>List of  User Info</returns>
		[OperationContract]
		Stream FindByGenderIdAndCityId(string genderId,string cityId);

        /// <summary>
        /// Updates  User Info's gender Id, city Id which has specified idUserInfo
        /// </summary>
		/// <param name="idUserInfo">id User Info</param>
		/// <param name="genderId">gender Id</param>
		/// <param name="cityId">city Id</param>
		/// <returns>List of  User Info</returns>
		[OperationContract]
		Stream UpdateGenderIdAndCityId(string idUserInfo,string genderId,string cityId);

        /// <summary>
        /// Delete all  User Info data with specified gender Id, city Id 
        /// </summary>
		/// <param name="genderId"> Gender Id</param>
		/// <param name="cityId"> City Id</param>
		/// <returns>List of  User Info</returns>
		[OperationContract]
		Stream DeleteByGenderIdAndCityId(string genderId,string cityId);

        /// <summary>
        /// Finds all  User Info data with specified city Id 
        /// </summary>
		/// <param name="cityId"> City Id</param>
		/// <returns>List of  User Info</returns>
		[OperationContract]
		Stream FindByCityId(string cityId);

        /// <summary>
        /// Updates  User Info's city Id which has specified idUserInfo
        /// </summary>
		/// <param name="idUserInfo">id User Info</param>
		/// <param name="cityId">city Id</param>
		/// <returns>List of  User Info</returns>
		[OperationContract]
		Stream UpdateCityId(string idUserInfo,string cityId);

        /// <summary>
        /// Delete all  User Info data with specified city Id 
        /// </summary>
		/// <param name="cityId"> City Id</param>
		/// <returns>List of  User Info</returns>
		[OperationContract]
		Stream DeleteByCityId(string cityId);
    
    }
}