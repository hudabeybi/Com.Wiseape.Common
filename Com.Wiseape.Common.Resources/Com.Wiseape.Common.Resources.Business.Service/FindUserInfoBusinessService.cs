using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Wiseape.Framework;
using Com.Wiseape.Utility;
using Com.Wiseape.Factory;
using Com.Wiseape.Common.Data.Model;
using Com.Wiseape.Common.Resources.Repository.Contract;
using Com.Wiseape.Common.Resources.Business.Contract;

namespace Com.Wiseape.Common.Resources.Business.Service
{
    /// <summary>
    /// Business Service for UserInfo module.
    /// </summary>
    public class FindUserInfoBusinessService : BaseBusinessService<UserInfo>, IFindUserInfoBusinessService
    {
        class Keywords
        {
            public static string FindUserInfo = "Find.Common.Resources.UserInfo";
        }
        
        public FindUserInfoBusinessService(string repoKey) : base(repoKey)
        {
        }
        
        public FindUserInfoBusinessService()
        {
            this.RepoKey = Keywords.FindUserInfo;
        }


        /// <summary>
        /// Finds all  User Info data with first Name containing specified keyword
        /// </summary>
		/// <param name="firstName"> First Name</param>
		/// <returns>The result of the operation</returns>
		public OperationResult FindByFirstName(string firstName)
		{
            IFindUserInfoRepository repository = (IFindUserInfoRepository)RepositoryFactory.Create(Keywords.FindUserInfo);
            try
            {
                List<UserInfo> res = repository.FindByFirstName(firstName);
                return new OperationResult(true, res);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Finds all  User Info data with last Name containing specified keyword
        /// </summary>
		/// <param name="lastName"> Last Name</param>
		/// <returns>The result of the operation</returns>
		public OperationResult FindByLastName(string lastName)
		{
            IFindUserInfoRepository repository = (IFindUserInfoRepository)RepositoryFactory.Create(Keywords.FindUserInfo);
            try
            {
                List<UserInfo> res = repository.FindByLastName(lastName);
                return new OperationResult(true, res);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Finds all  User Info data with mobile Phone containing specified keyword
        /// </summary>
		/// <param name="mobilePhone"> Mobile Phone</param>
		/// <returns>The result of the operation</returns>
		public OperationResult FindByMobilePhone(string mobilePhone)
		{
            IFindUserInfoRepository repository = (IFindUserInfoRepository)RepositoryFactory.Create(Keywords.FindUserInfo);
            try
            {
                List<UserInfo> res = repository.FindByMobilePhone(mobilePhone);
                return new OperationResult(true, res);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Finds all  User Info data with phone containing specified keyword
        /// </summary>
		/// <param name="phone"> Phone</param>
		/// <returns>The result of the operation</returns>
		public OperationResult FindByPhone(string phone)
		{
            IFindUserInfoRepository repository = (IFindUserInfoRepository)RepositoryFactory.Create(Keywords.FindUserInfo);
            try
            {
                List<UserInfo> res = repository.FindByPhone(phone);
                return new OperationResult(true, res);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Finds all  User Info data with address containing specified keyword
        /// </summary>
		/// <param name="address"> Address</param>
		/// <returns>The result of the operation</returns>
		public OperationResult FindByAddress(string address)
		{
            IFindUserInfoRepository repository = (IFindUserInfoRepository)RepositoryFactory.Create(Keywords.FindUserInfo);
            try
            {
                List<UserInfo> res = repository.FindByAddress(address);
                return new OperationResult(true, res);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Finds all  User Info data with user Id containing specified keyword
        /// </summary>
		/// <param name="userId"> User Id</param>
		/// <returns>The result of the operation</returns>
		public OperationResult FindByUserId(Int64 userId)
		{
            IFindUserInfoRepository repository = (IFindUserInfoRepository)RepositoryFactory.Create(Keywords.FindUserInfo);
            try
            {
                List<UserInfo> res = repository.FindByUserId(userId);
                return new OperationResult(true, res);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Finds all  User Info data with user Id, gender Id containing specified keyword
        /// </summary>
		/// <param name="userId"> User Id</param>
		/// <param name="genderId"> Gender Id</param>
		/// <returns>The result of the operation</returns>
		public OperationResult FindByUserIdAndGenderId(Int64 userId, Int16 genderId)
		{
            IFindUserInfoRepository repository = (IFindUserInfoRepository)RepositoryFactory.Create(Keywords.FindUserInfo);
            try
            {
                List<UserInfo> res = repository.FindByUserIdAndGenderId(userId, genderId);
                return new OperationResult(true, res);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Finds all  User Info data with user Id, gender Id, city Id containing specified keyword
        /// </summary>
		/// <param name="userId"> User Id</param>
		/// <param name="genderId"> Gender Id</param>
		/// <param name="cityId"> City Id</param>
		/// <returns>The result of the operation</returns>
		public OperationResult FindByUserIdAndGenderIdAndCityId(Int64 userId, Int16 genderId, Int16 cityId)
		{
            IFindUserInfoRepository repository = (IFindUserInfoRepository)RepositoryFactory.Create(Keywords.FindUserInfo);
            try
            {
                List<UserInfo> res = repository.FindByUserIdAndGenderIdAndCityId(userId, genderId, cityId);
                return new OperationResult(true, res);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Finds all  User Info data with user Id, city Id containing specified keyword
        /// </summary>
		/// <param name="userId"> User Id</param>
		/// <param name="cityId"> City Id</param>
		/// <returns>The result of the operation</returns>
		public OperationResult FindByUserIdAndCityId(Int64 userId, Int16 cityId)
		{
            IFindUserInfoRepository repository = (IFindUserInfoRepository)RepositoryFactory.Create(Keywords.FindUserInfo);
            try
            {
                List<UserInfo> res = repository.FindByUserIdAndCityId(userId, cityId);
                return new OperationResult(true, res);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Finds all  User Info data with gender Id containing specified keyword
        /// </summary>
		/// <param name="genderId"> Gender Id</param>
		/// <returns>The result of the operation</returns>
		public OperationResult FindByGenderId(Int16 genderId)
		{
            IFindUserInfoRepository repository = (IFindUserInfoRepository)RepositoryFactory.Create(Keywords.FindUserInfo);
            try
            {
                List<UserInfo> res = repository.FindByGenderId(genderId);
                return new OperationResult(true, res);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Finds all  User Info data with gender Id, city Id containing specified keyword
        /// </summary>
		/// <param name="genderId"> Gender Id</param>
		/// <param name="cityId"> City Id</param>
		/// <returns>The result of the operation</returns>
		public OperationResult FindByGenderIdAndCityId(Int16 genderId, Int16 cityId)
		{
            IFindUserInfoRepository repository = (IFindUserInfoRepository)RepositoryFactory.Create(Keywords.FindUserInfo);
            try
            {
                List<UserInfo> res = repository.FindByGenderIdAndCityId(genderId, cityId);
                return new OperationResult(true, res);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Finds all  User Info data with city Id containing specified keyword
        /// </summary>
		/// <param name="cityId"> City Id</param>
		/// <returns>The result of the operation</returns>
		public OperationResult FindByCityId(Int16 cityId)
		{
            IFindUserInfoRepository repository = (IFindUserInfoRepository)RepositoryFactory.Create(Keywords.FindUserInfo);
            try
            {
                List<UserInfo> res = repository.FindByCityId(cityId);
                return new OperationResult(true, res);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}



    }
 }