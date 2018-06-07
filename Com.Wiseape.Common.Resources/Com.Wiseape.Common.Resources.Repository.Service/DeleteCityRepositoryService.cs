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
    public class DeleteCityRepository : BaseRepository<City>, IDeleteCityRepository
    {
        class Keywords
        {
            public static string DeleteCity = "Delete.Common.Resources.City";
        }

        /// <summary>
        /// Constructor for DeleteCityRepository
        /// </summary>
        /// <param name="dataContextKey">Key for Datacontext to use</param>
        public DeleteCityRepository(string dataContextKey) : base(dataContextKey)
        {
        }
        
        
        public DeleteCityRepository()
        {
            this.DataContextKey = Keywords.DeleteCity;
        }

//------------------- Delete by keywords --------------------------------------------------------

        /// <summary>
        /// Delete all  City data with city Name containing specified keyword
        /// </summary>
		/// <param name="cityName"> City Name</param>
		/// <returns>List of  City</returns>
        public void DeleteByCityName(string cityName)
        {
            CommonDataContext dataContext = (CommonDataContext)this.DataContext;
            var list = from o in dataContext.Cities
                       where
							o.CityName.Contains(cityName) 						
						select o;
			dataContext.Cities.RemoveRange(list);
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Delete all  City data with city Location Lon containing specified keyword
        /// </summary>
		/// <param name="cityLocationLon"> City Location Lon</param>
		/// <returns>List of  City</returns>
        public void DeleteByCityLocationLon(float cityLocationLon)
        {
            CommonDataContext dataContext = (CommonDataContext)this.DataContext;
            var list = from o in dataContext.Cities
                       where
							o.CityLocationLon.Equals(cityLocationLon) 						
						select o;
			dataContext.Cities.RemoveRange(list);
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Delete all  City data with city Location Lat containing specified keyword
        /// </summary>
		/// <param name="cityLocationLat"> City Location Lat</param>
		/// <returns>List of  City</returns>
        public void DeleteByCityLocationLat(float cityLocationLat)
        {
            CommonDataContext dataContext = (CommonDataContext)this.DataContext;
            var list = from o in dataContext.Cities
                       where
							o.CityLocationLat.Equals(cityLocationLat) 						
						select o;
			dataContext.Cities.RemoveRange(list);
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Delete all  City data with lang I D containing specified keyword
        /// </summary>
		/// <param name="langID"> Lang I D</param>
		/// <returns>List of  City</returns>
        public void DeleteByLangID(string langID)
        {
            CommonDataContext dataContext = (CommonDataContext)this.DataContext;
            var list = from o in dataContext.Cities
                       where
							o.LangID.Contains(langID) 						
						select o;
			dataContext.Cities.RemoveRange(list);
            dataContext.SaveChanges();
        }


//-----------------------  Delete by Foreign keys ---------------------------------------

        /// <summary>
        /// Delete all  City data with specified country Id 
        /// </summary>
		/// <param name="countryId"> Country Id</param>
		/// <returns>List of  City</returns>
        public void DeleteByCountryId(Int16 countryId)
        {
            CommonDataContext dataContext = (CommonDataContext)this.DataContext;
            var list = from o in dataContext.Cities
                       where
							o.CountryId == countryId  						
						select o;
            dataContext.Cities.RemoveRange(list);
            dataContext.SaveChanges();
        }


    }
}
