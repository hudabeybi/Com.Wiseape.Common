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
    /// Business Service for UserLogin module.
    /// </summary>
    public class FindUserLoginBusinessService : BaseBusinessService<UserLogin>, IFindUserLoginBusinessService
    {
        class Keywords
        {
            public static string FindUserLogin = "Find.Common.Resources.UserLogin";
        }
        
        public FindUserLoginBusinessService(string repoKey) : base(repoKey)
        {
        }
        
        public FindUserLoginBusinessService()
        {
            this.RepoKey = Keywords.FindUserLogin;
        }


        /// <summary>
        /// Finds all  User Login data with username containing specified keyword
        /// </summary>
		/// <param name="username"> Username</param>
		/// <returns>The result of the operation</returns>
		public OperationResult FindByUsername(string username)
		{
            IFindUserLoginRepository repository = (IFindUserLoginRepository)RepositoryFactory.Create(Keywords.FindUserLogin);
            try
            {
                List<UserLogin> res = repository.FindByUsername(username);
                return new OperationResult(true, res);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Finds all  User Login data with user Password containing specified keyword
        /// </summary>
		/// <param name="userPassword"> User Password</param>
		/// <returns>The result of the operation</returns>
		public OperationResult FindByUserPassword(string userPassword)
		{
            IFindUserLoginRepository repository = (IFindUserLoginRepository)RepositoryFactory.Create(Keywords.FindUserLogin);
            try
            {
                List<UserLogin> res = repository.FindByUserPassword(userPassword);
                return new OperationResult(true, res);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Finds all  User Login data with created Date1, created Date2 containing specified keyword
        /// </summary>
		/// <param name="createdDate1"> Created Date</param>
		/// <param name="createdDate2"> Created Date</param>
		/// <returns>The result of the operation</returns>
		public OperationResult FindByCreatedDateBetween(DateTime createdDate1, DateTime createdDate2)
		{
            IFindUserLoginRepository repository = (IFindUserLoginRepository)RepositoryFactory.Create(Keywords.FindUserLogin);
            try
            {
                List<UserLogin> res = repository.FindByCreatedDateBetween(createdDate1, createdDate2);
                return new OperationResult(true, res);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Finds all  User Login data with application I D containing specified keyword
        /// </summary>
		/// <param name="applicationID"> Application I D</param>
		/// <returns>The result of the operation</returns>
		public OperationResult FindByApplicationID(string applicationID)
		{
            IFindUserLoginRepository repository = (IFindUserLoginRepository)RepositoryFactory.Create(Keywords.FindUserLogin);
            try
            {
                List<UserLogin> res = repository.FindByApplicationID(applicationID);
                return new OperationResult(true, res);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Finds all  User Login data with is Active containing specified keyword
        /// </summary>
		/// <param name="isActive"> Is Active</param>
		/// <returns>The result of the operation</returns>
		public OperationResult FindByIsActive(Int16 isActive)
		{
            IFindUserLoginRepository repository = (IFindUserLoginRepository)RepositoryFactory.Create(Keywords.FindUserLogin);
            try
            {
                List<UserLogin> res = repository.FindByIsActive(isActive);
                return new OperationResult(true, res);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}



    }
 }