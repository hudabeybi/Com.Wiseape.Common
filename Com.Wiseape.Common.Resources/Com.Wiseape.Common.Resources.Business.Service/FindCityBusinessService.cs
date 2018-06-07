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
    /// Business Service for City module.
    /// </summary>
    public class FindCityBusinessService : BaseBusinessService<City>, IFindCityBusinessService
    {
        class Keywords
        {
            public static string FindCity = "Find.Common.Resources.City";
        }
        
        public FindCityBusinessService(string repoKey) : base(repoKey)
        {
        }
        
        public FindCityBusinessService()
        {
            this.RepoKey = Keywords.FindCity;
        }


        /// <summary>
        /// Finds all  City data with city Name containing specified keyword
        /// </summary>
		/// <param name="cityName"> City Name</param>
		/// <returns>The result of the operation</returns>
		public OperationResult FindByCityName(string cityName)
		{
            IFindCityRepository repository = (IFindCityRepository)RepositoryFactory.Create(Keywords.FindCity);
            try
            {
                List<City> res = repository.FindByCityName(cityName);
                return new OperationResult(true, res);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Finds all  City data with city Location Lon containing specified keyword
        /// </summary>
		/// <param name="cityLocationLon"> City Location Lon</param>
		/// <returns>The result of the operation</returns>
		public OperationResult FindByCityLocationLon(float cityLocationLon)
		{
            IFindCityRepository repository = (IFindCityRepository)RepositoryFactory.Create(Keywords.FindCity);
            try
            {
                List<City> res = repository.FindByCityLocationLon(cityLocationLon);
                return new OperationResult(true, res);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Finds all  City data with city Location Lat containing specified keyword
        /// </summary>
		/// <param name="cityLocationLat"> City Location Lat</param>
		/// <returns>The result of the operation</returns>
		public OperationResult FindByCityLocationLat(float cityLocationLat)
		{
            IFindCityRepository repository = (IFindCityRepository)RepositoryFactory.Create(Keywords.FindCity);
            try
            {
                List<City> res = repository.FindByCityLocationLat(cityLocationLat);
                return new OperationResult(true, res);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Finds all  City data with lang I D containing specified keyword
        /// </summary>
		/// <param name="langID"> Lang I D</param>
		/// <returns>The result of the operation</returns>
		public OperationResult FindByLangID(string langID)
		{
            IFindCityRepository repository = (IFindCityRepository)RepositoryFactory.Create(Keywords.FindCity);
            try
            {
                List<City> res = repository.FindByLangID(langID);
                return new OperationResult(true, res);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Finds all  City data with country Id containing specified keyword
        /// </summary>
		/// <param name="countryId"> Country Id</param>
		/// <returns>The result of the operation</returns>
		public OperationResult FindByCountryId(Int16 countryId)
		{
            IFindCityRepository repository = (IFindCityRepository)RepositoryFactory.Create(Keywords.FindCity);
            try
            {
                List<City> res = repository.FindByCountryId(countryId);
                return new OperationResult(true, res);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}



    }
 }