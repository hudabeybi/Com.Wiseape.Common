using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Wiseape.Utility;
using Com.Wiseape.Common.Data.Model;


namespace Com.Wiseape.Common.Resources.Business.Contract
{
    public interface IUpdateUserInfoBusinessService
    {

        /// <summary>
        /// Updates  User Info's first Name which has specified idUserInfo
        /// </summary>
		/// <param name="idUserInfo">id User Info</param>
		/// <param name="firstName">first Name</param>
		/// <returns>List of  User Info</returns>
		OperationResult UpdateFirstName(Int64 idUserInfo, string firstName);

        /// <summary>
        /// Updates  User Info's last Name which has specified idUserInfo
        /// </summary>
		/// <param name="idUserInfo">id User Info</param>
		/// <param name="lastName">last Name</param>
		/// <returns>List of  User Info</returns>
		OperationResult UpdateLastName(Int64 idUserInfo, string lastName);

        /// <summary>
        /// Updates  User Info's mobile Phone which has specified idUserInfo
        /// </summary>
		/// <param name="idUserInfo">id User Info</param>
		/// <param name="mobilePhone">mobile Phone</param>
		/// <returns>List of  User Info</returns>
		OperationResult UpdateMobilePhone(Int64 idUserInfo, string mobilePhone);

        /// <summary>
        /// Updates  User Info's phone which has specified idUserInfo
        /// </summary>
		/// <param name="idUserInfo">id User Info</param>
		/// <param name="phone">phone</param>
		/// <returns>List of  User Info</returns>
		OperationResult UpdatePhone(Int64 idUserInfo, string phone);

        /// <summary>
        /// Updates  User Info's address which has specified idUserInfo
        /// </summary>
		/// <param name="idUserInfo">id User Info</param>
		/// <param name="address">address</param>
		/// <returns>List of  User Info</returns>
		OperationResult UpdateAddress(Int64 idUserInfo, string address);

        /// <summary>
        /// Updates  User Info's user Id which has specified idUserInfo
        /// </summary>
		/// <param name="idUserInfo">id User Info</param>
		/// <param name="userId">user Id</param>
		/// <returns>List of  User Info</returns>
		OperationResult UpdateUserId(Int64 idUserInfo, Int64 userId);

        /// <summary>
        /// Updates  User Info's user Id, gender Id which has specified idUserInfo
        /// </summary>
		/// <param name="idUserInfo">id User Info</param>
		/// <param name="userId">user Id</param>
		/// <param name="genderId">gender Id</param>
		/// <returns>List of  User Info</returns>
		OperationResult UpdateUserIdAndGenderId(Int64 idUserInfo, Int64 userId, Int16 genderId);

        /// <summary>
        /// Updates  User Info's user Id, gender Id, city Id which has specified idUserInfo
        /// </summary>
		/// <param name="idUserInfo">id User Info</param>
		/// <param name="userId">user Id</param>
		/// <param name="genderId">gender Id</param>
		/// <param name="cityId">city Id</param>
		/// <returns>List of  User Info</returns>
		OperationResult UpdateUserIdAndGenderIdAndCityId(Int64 idUserInfo, Int64 userId, Int16 genderId, Int16 cityId);

        /// <summary>
        /// Updates  User Info's user Id, city Id which has specified idUserInfo
        /// </summary>
		/// <param name="idUserInfo">id User Info</param>
		/// <param name="userId">user Id</param>
		/// <param name="cityId">city Id</param>
		/// <returns>List of  User Info</returns>
		OperationResult UpdateUserIdAndCityId(Int64 idUserInfo, Int64 userId, Int16 cityId);

        /// <summary>
        /// Updates  User Info's gender Id which has specified idUserInfo
        /// </summary>
		/// <param name="idUserInfo">id User Info</param>
		/// <param name="genderId">gender Id</param>
		/// <returns>List of  User Info</returns>
		OperationResult UpdateGenderId(Int64 idUserInfo, Int16 genderId);

        /// <summary>
        /// Updates  User Info's gender Id, city Id which has specified idUserInfo
        /// </summary>
		/// <param name="idUserInfo">id User Info</param>
		/// <param name="genderId">gender Id</param>
		/// <param name="cityId">city Id</param>
		/// <returns>List of  User Info</returns>
		OperationResult UpdateGenderIdAndCityId(Int64 idUserInfo, Int16 genderId, Int16 cityId);

        /// <summary>
        /// Updates  User Info's city Id which has specified idUserInfo
        /// </summary>
		/// <param name="idUserInfo">id User Info</param>
		/// <param name="cityId">city Id</param>
		/// <returns>List of  User Info</returns>
		OperationResult UpdateCityId(Int64 idUserInfo, Int16 cityId);

	}
}