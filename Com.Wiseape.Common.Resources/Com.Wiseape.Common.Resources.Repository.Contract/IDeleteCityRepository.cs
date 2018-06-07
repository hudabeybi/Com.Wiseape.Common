using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Wiseape.Common.Data.Model;

namespace Com.Wiseape.Common.Resources.Repository.Contract
{
    public interface IDeleteCityRepository
    {

	   	/// <summary>
	   	/// Delete all  City data with city Name containing specified keyword
	    /// </summary>
		/// <param name="cityName"> City Name</param>
		/// <returns>List of  City</returns>
		void DeleteByCityName(string cityName);
	
	   	/// <summary>
	   	/// Delete all  City data with city Location Lon containing specified keyword
	    /// </summary>
		/// <param name="cityLocationLon"> City Location Lon</param>
		/// <returns>List of  City</returns>
		void DeleteByCityLocationLon(float cityLocationLon);
	
	   	/// <summary>
	   	/// Delete all  City data with city Location Lat containing specified keyword
	    /// </summary>
		/// <param name="cityLocationLat"> City Location Lat</param>
		/// <returns>List of  City</returns>
		void DeleteByCityLocationLat(float cityLocationLat);
	
	   	/// <summary>
	   	/// Delete all  City data with lang I D containing specified keyword
	    /// </summary>
		/// <param name="langID"> Lang I D</param>
		/// <returns>List of  City</returns>
		void DeleteByLangID(string langID);
	
	   	/// <summary>
	    /// Delete all  City data with specified country Id 
	    /// </summary>
		/// <param name="countryId"> Country Id</param>
		/// <returns>List of  City</returns>
		void DeleteByCountryId(Int16 countryId);
	
    }
}

