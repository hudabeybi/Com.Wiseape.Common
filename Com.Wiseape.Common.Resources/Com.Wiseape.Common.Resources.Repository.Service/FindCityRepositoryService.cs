using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Wiseape.Framework;
using Com.Wiseape.Common.Data.Model;
using Com.Wiseape.Common.Data.Context;
using Com.Wiseape.Common.Resources.Repository.Contract;

namespace Com.Wiseape.Common.Resources.Repository.Service
{
    /// <summary>
    /// Repository for City data.
    /// </summary>
    public class FindCityRepository : BaseRepository<City>, IFindCityRepository
    {
        class Keywords
        {
            public static string FindCity = "Find.Common.Resources.City";
        }

        /// <summary>
        /// Constructor for CityRepository
        /// </summary>
        /// <param name="dataContextKey">Key for Datacontext to use</param>
        public FindCityRepository(string dataContextKey) : base(dataContextKey)
        {
        }
        
        
        public FindCityRepository()
        {
            this.DataContextKey = Keywords.FindCity;
        }

//------------------- Find by keywords --------------------------------------------------------

        /// <summary>
        /// Finds all  City data with city Name containing specified keyword
        /// </summary>
		/// <param name="cityName"> City Name</param>
		/// <returns>List of  City</returns>
        public List<City> FindByCityName(string cityName)
        {
            CommonDataContext dataContext = (CommonDataContext)this.DataContext;
            var list = from o in dataContext.Cities
                       where
							o.CityName.Contains(cityName) 						
						select o;
            return list.ToList();
        }

        /// <summary>
        /// Finds all  City data with city Location Lon containing specified keyword
        /// </summary>
		/// <param name="cityLocationLon"> City Location Lon</param>
		/// <returns>List of  City</returns>
        public List<City> FindByCityLocationLon(float cityLocationLon)
        {
            CommonDataContext dataContext = (CommonDataContext)this.DataContext;
            var list = from o in dataContext.Cities
                       where
							o.CityLocationLon.Equals(cityLocationLon) 						
						select o;
            return list.ToList();
        }

        /// <summary>
        /// Finds all  City data with city Location Lat containing specified keyword
        /// </summary>
		/// <param name="cityLocationLat"> City Location Lat</param>
		/// <returns>List of  City</returns>
        public List<City> FindByCityLocationLat(float cityLocationLat)
        {
            CommonDataContext dataContext = (CommonDataContext)this.DataContext;
            var list = from o in dataContext.Cities
                       where
							o.CityLocationLat.Equals(cityLocationLat) 						
						select o;
            return list.ToList();
        }

        /// <summary>
        /// Finds all  City data with lang I D containing specified keyword
        /// </summary>
		/// <param name="langID"> Lang I D</param>
		/// <returns>List of  City</returns>
        public List<City> FindByLangID(string langID)
        {
            CommonDataContext dataContext = (CommonDataContext)this.DataContext;
            var list = from o in dataContext.Cities
                       where
							o.LangID.Contains(langID) 						
						select o;
            return list.ToList();
        }


//----------------------  find by dates -----------------------------------------------


//-----------------------  Find by Foreign keys ---------------------------------------

        /// <summary>
        /// Finds all  City data with specified country Id 
        /// </summary>
		/// <param name="countryId"> Country Id</param>
		/// <returns>List of  City</returns>
        public List<City> FindByCountryId(Int16 countryId)
        {
            CommonDataContext dataContext = (CommonDataContext)this.DataContext;
            var list = from o in dataContext.Cities
                       where
							o.CountryId == countryId  						
						select o;
            return list.ToList();
        }




    }
}
