using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Wiseape.Common.Data.Model;



namespace Com.Wiseape.Common.Resources.Repository.Contract
{
    public interface IFindUserInfoRepository
    {

        /// <summary>
        /// Finds all  User Info data with first Name containing specified keyword
        /// </summary>
		/// <param name="firstName"> First Name</param>
		/// <returns>List of  User Info</returns>
		List<UserInfo> FindByFirstName(string firstName);

        /// <summary>
        /// Finds all  User Info data with last Name containing specified keyword
        /// </summary>
		/// <param name="lastName"> Last Name</param>
		/// <returns>List of  User Info</returns>
		List<UserInfo> FindByLastName(string lastName);

        /// <summary>
        /// Finds all  User Info data with mobile Phone containing specified keyword
        /// </summary>
		/// <param name="mobilePhone"> Mobile Phone</param>
		/// <returns>List of  User Info</returns>
		List<UserInfo> FindByMobilePhone(string mobilePhone);

        /// <summary>
        /// Finds all  User Info data with phone containing specified keyword
        /// </summary>
		/// <param name="phone"> Phone</param>
		/// <returns>List of  User Info</returns>
		List<UserInfo> FindByPhone(string phone);

        /// <summary>
        /// Finds all  User Info data with address containing specified keyword
        /// </summary>
		/// <param name="address"> Address</param>
		/// <returns>List of  User Info</returns>
		List<UserInfo> FindByAddress(string address);

        /// <summary>
        /// Finds all  User Info data with user Id containing specified keyword
        /// </summary>
		/// <param name="userId"> User Id</param>
		/// <returns>List of  User Info</returns>
		List<UserInfo> FindByUserId(Int64 userId);

        /// <summary>
        /// Finds all  User Info data with user Id, gender Id containing specified keyword
        /// </summary>
		/// <param name="userId"> User Id</param>
		/// <param name="genderId"> Gender Id</param>
		/// <returns>List of  User Info</returns>
		List<UserInfo> FindByUserIdAndGenderId(Int64 userId, Int16 genderId);

        /// <summary>
        /// Finds all  User Info data with user Id, gender Id, city Id containing specified keyword
        /// </summary>
		/// <param name="userId"> User Id</param>
		/// <param name="genderId"> Gender Id</param>
		/// <param name="cityId"> City Id</param>
		/// <returns>List of  User Info</returns>
		List<UserInfo> FindByUserIdAndGenderIdAndCityId(Int64 userId, Int16 genderId, Int16 cityId);

        /// <summary>
        /// Finds all  User Info data with user Id, city Id containing specified keyword
        /// </summary>
		/// <param name="userId"> User Id</param>
		/// <param name="cityId"> City Id</param>
		/// <returns>List of  User Info</returns>
		List<UserInfo> FindByUserIdAndCityId(Int64 userId, Int16 cityId);

        /// <summary>
        /// Finds all  User Info data with gender Id containing specified keyword
        /// </summary>
		/// <param name="genderId"> Gender Id</param>
		/// <returns>List of  User Info</returns>
		List<UserInfo> FindByGenderId(Int16 genderId);

        /// <summary>
        /// Finds all  User Info data with gender Id, city Id containing specified keyword
        /// </summary>
		/// <param name="genderId"> Gender Id</param>
		/// <param name="cityId"> City Id</param>
		/// <returns>List of  User Info</returns>
		List<UserInfo> FindByGenderIdAndCityId(Int16 genderId, Int16 cityId);

        /// <summary>
        /// Finds all  User Info data with city Id containing specified keyword
        /// </summary>
		/// <param name="cityId"> City Id</param>
		/// <returns>List of  User Info</returns>
		List<UserInfo> FindByCityId(Int16 cityId);

    }
}

