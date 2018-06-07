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
    /// Repository for UpdateCity data.
    /// </summary>
    public class UpdateCityRepository : BaseRepository<City>, IUpdateCityRepository
    {
        class Keywords
        {
            public static string UpdateCity = "Update.Common.Resources.City";
        }

        /// <summary>
        /// Constructor for CityRepository
        /// </summary>
        /// <param name="dataContextKey">Key for Datacontext to use</param>
        public UpdateCityRepository(string dataContextKey) : base(dataContextKey)
        {
        }
        
        
        public UpdateCityRepository()
        {
            this.DataContextKey = Keywords.UpdateCity;
        }


//-------------------------- Update columns by Primary key -----------------------------------------

        /// <summary>
        /// Updates  City's id City, city Name by idCity
        /// </summary>
		/// <param name="idCity">id City</param>
		/// <param name="cityName">city Name</param>
		/// <returns>List of  City</returns>
        public void UpdateCityName(Int64 idCity, string cityName)
        {
            CommonDataContext dataContext = (CommonDataContext)this.DataContext;
            var list = from o in dataContext.Cities
                       where
                       		o.IdCity == idCity
                       	select o;
           	list.ToList().ForEach(o => {
      			o.CityName = cityName;	
            });
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Updates  City's id City, city Location Lon by idCity
        /// </summary>
		/// <param name="idCity">id City</param>
		/// <param name="cityLocationLon">city Location Lon</param>
		/// <returns>List of  City</returns>
        public void UpdateCityLocationLon(Int64 idCity, float cityLocationLon)
        {
            CommonDataContext dataContext = (CommonDataContext)this.DataContext;
            var list = from o in dataContext.Cities
                       where
                       		o.IdCity == idCity
                       	select o;
           	list.ToList().ForEach(o => {
      			o.CityLocationLon = cityLocationLon;	
            });
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Updates  City's id City, city Location Lat by idCity
        /// </summary>
		/// <param name="idCity">id City</param>
		/// <param name="cityLocationLat">city Location Lat</param>
		/// <returns>List of  City</returns>
        public void UpdateCityLocationLat(Int64 idCity, float cityLocationLat)
        {
            CommonDataContext dataContext = (CommonDataContext)this.DataContext;
            var list = from o in dataContext.Cities
                       where
                       		o.IdCity == idCity
                       	select o;
           	list.ToList().ForEach(o => {
      			o.CityLocationLat = cityLocationLat;	
            });
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Updates  City's id City, lang I D by idCity
        /// </summary>
		/// <param name="idCity">id City</param>
		/// <param name="langID">lang I D</param>
		/// <returns>List of  City</returns>
        public void UpdateLangID(Int64 idCity, string langID)
        {
            CommonDataContext dataContext = (CommonDataContext)this.DataContext;
            var list = from o in dataContext.Cities
                       where
                       		o.IdCity == idCity
                       	select o;
           	list.ToList().ForEach(o => {
      			o.LangID = langID;	
            });
            dataContext.SaveChanges();
        }


//-------------------------- Update foreign keys -----------------------------------------

        /// <summary>
        /// Updates  City's id City, country Id by idCity
        /// </summary>
		/// <param name="idCity">id City</param>
		/// <param name="countryId">country Id</param>
		/// <returns>List of  City</returns>
        public void UpdateCountryId(Int64 idCity, Int16 countryId)
        {
            CommonDataContext dataContext = (CommonDataContext)this.DataContext;
            var list = from o in dataContext.Cities
                       where
                       		o.IdCity == idCity
                       	select o;
           	list.ToList().ForEach(o => {
      			o.CountryId = countryId;
	
            });
            dataContext.SaveChanges();
        }


    }
}
