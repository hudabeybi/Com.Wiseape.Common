using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Wiseape.Common.Data.Model;



namespace Com.Wiseape.Common.Resources.Repository.Contract
{
    public interface IUpdateUserInfoRepository
    {

	    /// <summary>
	    /// Updates  User Info's id User Info, first Name by idUserInfo
	    /// </summary>
		/// <param name="idUserInfo">id User Info</param>
		/// <param name="firstName">first Name</param>
		/// <returns>List of  User Info</returns>
		void UpdateFirstName(Int64 idUserInfo, string firstName);
	
	    /// <summary>
	    /// Updates  User Info's id User Info, last Name by idUserInfo
	    /// </summary>
		/// <param name="idUserInfo">id User Info</param>
		/// <param name="lastName">last Name</param>
		/// <returns>List of  User Info</returns>
		void UpdateLastName(Int64 idUserInfo, string lastName);
	
	    /// <summary>
	    /// Updates  User Info's id User Info, mobile Phone by idUserInfo
	    /// </summary>
		/// <param name="idUserInfo">id User Info</param>
		/// <param name="mobilePhone">mobile Phone</param>
		/// <returns>List of  User Info</returns>
		void UpdateMobilePhone(Int64 idUserInfo, string mobilePhone);
	
	    /// <summary>
	    /// Updates  User Info's id User Info, phone by idUserInfo
	    /// </summary>
		/// <param name="idUserInfo">id User Info</param>
		/// <param name="phone">phone</param>
		/// <returns>List of  User Info</returns>
		void UpdatePhone(Int64 idUserInfo, string phone);
	
	    /// <summary>
	    /// Updates  User Info's id User Info, address by idUserInfo
	    /// </summary>
		/// <param name="idUserInfo">id User Info</param>
		/// <param name="address">address</param>
		/// <returns>List of  User Info</returns>
		void UpdateAddress(Int64 idUserInfo, string address);
	
	    /// <summary>
	    /// Updates  User Info's id User Info, user Id by idUserInfo
	    /// </summary>
		/// <param name="idUserInfo">id User Info</param>
		/// <param name="userId">user Id</param>
		/// <returns>List of  User Info</returns>
		void UpdateUserId(Int64 idUserInfo, Int64 userId);
	
	    /// <summary>
	    /// Updates  User Info's id User Info, user Id, gender Id by idUserInfo
	    /// </summary>
		/// <param name="idUserInfo">id User Info</param>
		/// <param name="userId">user Id</param>
		/// <param name="genderId">gender Id</param>
		/// <returns>List of  User Info</returns>
		void UpdateUserIdAndGenderId(Int64 idUserInfo, Int64 userId, Int16 genderId);
	
	    /// <summary>
	    /// Updates  User Info's id User Info, user Id, gender Id, city Id by idUserInfo
	    /// </summary>
		/// <param name="idUserInfo">id User Info</param>
		/// <param name="userId">user Id</param>
		/// <param name="genderId">gender Id</param>
		/// <param name="cityId">city Id</param>
		/// <returns>List of  User Info</returns>
		void UpdateUserIdAndGenderIdAndCityId(Int64 idUserInfo, Int64 userId, Int16 genderId, Int16 cityId);
	
	    /// <summary>
	    /// Updates  User Info's id User Info, user Id, city Id by idUserInfo
	    /// </summary>
		/// <param name="idUserInfo">id User Info</param>
		/// <param name="userId">user Id</param>
		/// <param name="cityId">city Id</param>
		/// <returns>List of  User Info</returns>
		void UpdateUserIdAndCityId(Int64 idUserInfo, Int64 userId, Int16 cityId);
	
	    /// <summary>
	    /// Updates  User Info's id User Info, gender Id by idUserInfo
	    /// </summary>
		/// <param name="idUserInfo">id User Info</param>
		/// <param name="genderId">gender Id</param>
		/// <returns>List of  User Info</returns>
		void UpdateGenderId(Int64 idUserInfo, Int16 genderId);
	
	    /// <summary>
	    /// Updates  User Info's id User Info, gender Id, city Id by idUserInfo
	    /// </summary>
		/// <param name="idUserInfo">id User Info</param>
		/// <param name="genderId">gender Id</param>
		/// <param name="cityId">city Id</param>
		/// <returns>List of  User Info</returns>
		void UpdateGenderIdAndCityId(Int64 idUserInfo, Int16 genderId, Int16 cityId);
	
	    /// <summary>
	    /// Updates  User Info's id User Info, city Id by idUserInfo
	    /// </summary>
		/// <param name="idUserInfo">id User Info</param>
		/// <param name="cityId">city Id</param>
		/// <returns>List of  User Info</returns>
		void UpdateCityId(Int64 idUserInfo, Int16 cityId);
	
    }
}

