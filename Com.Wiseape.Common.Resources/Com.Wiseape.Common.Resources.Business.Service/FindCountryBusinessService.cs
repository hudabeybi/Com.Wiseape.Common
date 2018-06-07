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
    /// Business Service for Country module.
    /// </summary>
    public class FindCountryBusinessService : BaseBusinessService<Country>, IFindCountryBusinessService
    {
        class Keywords
        {
            public static string FindCountry = "Find.Common.Resources.Country";
        }
        
        public FindCountryBusinessService(string repoKey) : base(repoKey)
        {
        }
        
        public FindCountryBusinessService()
        {
            this.RepoKey = Keywords.FindCountry;
        }


        /// <summary>
        /// Finds all  Country data with country Name containing specified keyword
        /// </summary>
		/// <param name="countryName"> Country Name</param>
		/// <returns>The result of the operation</returns>
		public OperationResult FindByCountryName(string countryName)
		{
            IFindCountryRepository repository = (IFindCountryRepository)RepositoryFactory.Create(Keywords.FindCountry);
            try
            {
                List<Country> res = repository.FindByCountryName(countryName);
                return new OperationResult(true, res);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Finds all  Country data with country Desc containing specified keyword
        /// </summary>
		/// <param name="countryDesc"> Country Desc</param>
		/// <returns>The result of the operation</returns>
		public OperationResult FindByCountryDesc(string countryDesc)
		{
            IFindCountryRepository repository = (IFindCountryRepository)RepositoryFactory.Create(Keywords.FindCountry);
            try
            {
                List<Country> res = repository.FindByCountryDesc(countryDesc);
                return new OperationResult(true, res);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Finds all  Country data with country Flag Icon containing specified keyword
        /// </summary>
		/// <param name="countryFlagIcon"> Country Flag Icon</param>
		/// <returns>The result of the operation</returns>
		public OperationResult FindByCountryFlagIcon(string countryFlagIcon)
		{
            IFindCountryRepository repository = (IFindCountryRepository)RepositoryFactory.Create(Keywords.FindCountry);
            try
            {
                List<Country> res = repository.FindByCountryFlagIcon(countryFlagIcon);
                return new OperationResult(true, res);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Finds all  Country data with is Active containing specified keyword
        /// </summary>
		/// <param name="isActive"> Is Active</param>
		/// <returns>The result of the operation</returns>
		public OperationResult FindByIsActive(Int16 isActive)
		{
            IFindCountryRepository repository = (IFindCountryRepository)RepositoryFactory.Create(Keywords.FindCountry);
            try
            {
                List<Country> res = repository.FindByIsActive(isActive);
                return new OperationResult(true, res);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}



    }
 }