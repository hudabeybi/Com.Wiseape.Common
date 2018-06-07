using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Wiseape.Utility;
using Com.Wiseape.Common.Data.Model;


namespace Com.Wiseape.Common.Resources.Business.Contract
{
    public interface IFindUserInfoBusinessService
    {

        /// <summary>
        /// Finds all  User Info data with first Name containing specified keyword
        /// </summary>
		/// <param name="firstName"> First Name</param>
		/// <returns>List of  User Info</returns>
		OperationResult FindByFirstName(string firstName);

        /// <summary>
        /// Finds all  User Info data with last Name containing specified keyword
        /// </summary>
		/// <param name="lastName"> Last Name</param>
		/// <returns>List of  User Info</returns>
		OperationResult FindByLastName(string lastName);

        /// <summary>
        /// Finds all  User Info data with mobile Phone containing specified keyword
        /// </summary>
		/// <param name="mobilePhone"> Mobile Phone</param>
		/// <returns>List of  User Info</returns>
		OperationResult FindByMobilePhone(string mobilePhone);

        /// <summary>
        /// Finds all  User Info data with phone containing specified keyword
        /// </summary>
		/// <param name="phone"> Phone</param>
		/// <returns>List of  User Info</returns>
		OperationResult FindByPhone(string phone);

        /// <summary>
        /// Finds all  User Info data with address containing specified keyword
        /// </summary>
		/// <param name="address"> Address</param>
		/// <returns>List of  User Info</returns>
		OperationResult FindByAddress(string address);

        /// <summary>
        /// Finds all  User Info data with specified user Id 
        /// </summary>
		/// <param name="userId"> User Id</param>
		/// <returns>List of  User Info</returns>
		OperationResult FindByUserId(Int64 userId);

        /// <summary>
        /// Finds all  User Info data with specified user Id, gender Id 
        /// </summary>
		/// <param name="userId"> User Id</param>
		/// <param name="genderId"> Gender Id</param>
		/// <returns>List of  User Info</returns>
		OperationResult FindByUserIdAndGenderId(Int64 userId, Int16 genderId);

        /// <summary>
        /// Finds all  User Info data with specified user Id, gender Id, city Id 
        /// </summary>
		/// <param name="userId"> User Id</param>
		/// <param name="genderId"> Gender Id</param>
		/// <param name="cityId"> City Id</param>
		/// <returns>List of  User Info</returns>
		OperationResult FindByUserIdAndGenderIdAndCityId(Int64 userId, Int16 genderId, Int16 cityId);

        /// <summary>
        /// Finds all  User Info data with specified user Id, city Id 
        /// </summary>
		/// <param name="userId"> User Id</param>
		/// <param name="cityId"> City Id</param>
		/// <returns>List of  User Info</returns>
		OperationResult FindByUserIdAndCityId(Int64 userId, Int16 cityId);

        /// <summary>
        /// Finds all  User Info data with specified gender Id 
        /// </summary>
		/// <param name="genderId"> Gender Id</param>
		/// <returns>List of  User Info</returns>
		OperationResult FindByGenderId(Int16 genderId);

        /// <summary>
        /// Finds all  User Info data with specified gender Id, city Id 
        /// </summary>
		/// <param name="genderId"> Gender Id</param>
		/// <param name="cityId"> City Id</param>
		/// <returns>List of  User Info</returns>
		OperationResult FindByGenderIdAndCityId(Int16 genderId, Int16 cityId);

        /// <summary>
        /// Finds all  User Info data with specified city Id 
        /// </summary>
		/// <param name="cityId"> City Id</param>
		/// <returns>List of  User Info</returns>
		OperationResult FindByCityId(Int16 cityId);

	}
}