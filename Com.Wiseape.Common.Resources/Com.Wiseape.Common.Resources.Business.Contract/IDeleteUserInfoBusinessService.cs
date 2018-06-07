using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Wiseape.Utility;
using Com.Wiseape.Common.Data.Model;


namespace Com.Wiseape.Common.Resources.Business.Contract
{
    public interface IDeleteUserInfoBusinessService
    {

        /// <summary>
        /// Delete all  User Info data with first Name containing specified keyword
        /// </summary>
		/// <param name="firstName"> First Name</param>
		/// <returns>List of  User Info</returns>
		OperationResult DeleteByFirstName(string firstName);

        /// <summary>
        /// Delete all  User Info data with last Name containing specified keyword
        /// </summary>
		/// <param name="lastName"> Last Name</param>
		/// <returns>List of  User Info</returns>
		OperationResult DeleteByLastName(string lastName);

        /// <summary>
        /// Delete all  User Info data with mobile Phone containing specified keyword
        /// </summary>
		/// <param name="mobilePhone"> Mobile Phone</param>
		/// <returns>List of  User Info</returns>
		OperationResult DeleteByMobilePhone(string mobilePhone);

        /// <summary>
        /// Delete all  User Info data with phone containing specified keyword
        /// </summary>
		/// <param name="phone"> Phone</param>
		/// <returns>List of  User Info</returns>
		OperationResult DeleteByPhone(string phone);

        /// <summary>
        /// Delete all  User Info data with address containing specified keyword
        /// </summary>
		/// <param name="address"> Address</param>
		/// <returns>List of  User Info</returns>
		OperationResult DeleteByAddress(string address);

        /// <summary>
        /// Delete all  User Info data with specified user Id 
        /// </summary>
		/// <param name="userId"> User Id</param>
		/// <returns>List of  User Info</returns>
		OperationResult DeleteByUserId(Int64 userId);

        /// <summary>
        /// Delete all  User Info data with specified user Id, gender Id 
        /// </summary>
		/// <param name="userId"> User Id</param>
		/// <param name="genderId"> Gender Id</param>
		/// <returns>List of  User Info</returns>
		OperationResult DeleteByUserIdAndGenderId(Int64 userId, Int16 genderId);

        /// <summary>
        /// Delete all  User Info data with specified user Id, gender Id, city Id 
        /// </summary>
		/// <param name="userId"> User Id</param>
		/// <param name="genderId"> Gender Id</param>
		/// <param name="cityId"> City Id</param>
		/// <returns>List of  User Info</returns>
		OperationResult DeleteByUserIdAndGenderIdAndCityId(Int64 userId, Int16 genderId, Int16 cityId);

        /// <summary>
        /// Delete all  User Info data with specified user Id, city Id 
        /// </summary>
		/// <param name="userId"> User Id</param>
		/// <param name="cityId"> City Id</param>
		/// <returns>List of  User Info</returns>
		OperationResult DeleteByUserIdAndCityId(Int64 userId, Int16 cityId);

        /// <summary>
        /// Delete all  User Info data with specified gender Id 
        /// </summary>
		/// <param name="genderId"> Gender Id</param>
		/// <returns>List of  User Info</returns>
		OperationResult DeleteByGenderId(Int16 genderId);

        /// <summary>
        /// Delete all  User Info data with specified gender Id, city Id 
        /// </summary>
		/// <param name="genderId"> Gender Id</param>
		/// <param name="cityId"> City Id</param>
		/// <returns>List of  User Info</returns>
		OperationResult DeleteByGenderIdAndCityId(Int16 genderId, Int16 cityId);

        /// <summary>
        /// Delete all  User Info data with specified city Id 
        /// </summary>
		/// <param name="cityId"> City Id</param>
		/// <returns>List of  User Info</returns>
		OperationResult DeleteByCityId(Int16 cityId);

	}
}