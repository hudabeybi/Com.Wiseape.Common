using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Wiseape.Utility;
using Com.Wiseape.Common.Data.Model;


namespace Com.Wiseape.Common.Resources.Business.Contract
{
    public interface IUpdateCityBusinessService
    {

        /// <summary>
        /// Updates  City's city Name which has specified idCity
        /// </summary>
		/// <param name="idCity">id City</param>
		/// <param name="cityName">city Name</param>
		/// <returns>List of  City</returns>
		OperationResult UpdateCityName(Int64 idCity, string cityName);

        /// <summary>
        /// Updates  City's city Location Lon which has specified idCity
        /// </summary>
		/// <param name="idCity">id City</param>
		/// <param name="cityLocationLon">city Location Lon</param>
		/// <returns>List of  City</returns>
		OperationResult UpdateCityLocationLon(Int64 idCity, float cityLocationLon);

        /// <summary>
        /// Updates  City's city Location Lat which has specified idCity
        /// </summary>
		/// <param name="idCity">id City</param>
		/// <param name="cityLocationLat">city Location Lat</param>
		/// <returns>List of  City</returns>
		OperationResult UpdateCityLocationLat(Int64 idCity, float cityLocationLat);

        /// <summary>
        /// Updates  City's lang I D which has specified idCity
        /// </summary>
		/// <param name="idCity">id City</param>
		/// <param name="langID">lang I D</param>
		/// <returns>List of  City</returns>
		OperationResult UpdateLangID(Int64 idCity, string langID);

        /// <summary>
        /// Updates  City's country Id which has specified idCity
        /// </summary>
		/// <param name="idCity">id City</param>
		/// <param name="countryId">country Id</param>
		/// <returns>List of  City</returns>
		OperationResult UpdateCountryId(Int64 idCity, Int16 countryId);

	}
}