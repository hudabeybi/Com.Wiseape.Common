using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Wiseape.Common.Data.Model;



namespace Com.Wiseape.Common.Resources.Repository.Contract
{
    public interface IUpdateCityRepository
    {

	    /// <summary>
	    /// Updates  City's id City, city Name by idCity
	    /// </summary>
		/// <param name="idCity">id City</param>
		/// <param name="cityName">city Name</param>
		/// <returns>List of  City</returns>
		void UpdateCityName(Int64 idCity, string cityName);
	
	    /// <summary>
	    /// Updates  City's id City, city Location Lon by idCity
	    /// </summary>
		/// <param name="idCity">id City</param>
		/// <param name="cityLocationLon">city Location Lon</param>
		/// <returns>List of  City</returns>
		void UpdateCityLocationLon(Int64 idCity, float cityLocationLon);
	
	    /// <summary>
	    /// Updates  City's id City, city Location Lat by idCity
	    /// </summary>
		/// <param name="idCity">id City</param>
		/// <param name="cityLocationLat">city Location Lat</param>
		/// <returns>List of  City</returns>
		void UpdateCityLocationLat(Int64 idCity, float cityLocationLat);
	
	    /// <summary>
	    /// Updates  City's id City, lang I D by idCity
	    /// </summary>
		/// <param name="idCity">id City</param>
		/// <param name="langID">lang I D</param>
		/// <returns>List of  City</returns>
		void UpdateLangID(Int64 idCity, string langID);
	
	    /// <summary>
	    /// Updates  City's id City, country Id by idCity
	    /// </summary>
		/// <param name="idCity">id City</param>
		/// <param name="countryId">country Id</param>
		/// <returns>List of  City</returns>
		void UpdateCountryId(Int64 idCity, Int16 countryId);
	
    }
}

