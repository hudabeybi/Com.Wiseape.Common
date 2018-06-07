using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Wiseape.Utility;
using Com.Wiseape.Common.Data.Model;


namespace Com.Wiseape.Common.Resources.Business.Contract
{
    public interface IDeleteCityBusinessService
    {

        /// <summary>
        /// Delete all  City data with city Name containing specified keyword
        /// </summary>
		/// <param name="cityName"> City Name</param>
		/// <returns>List of  City</returns>
		OperationResult DeleteByCityName(string cityName);

        /// <summary>
        /// Delete all  City data with city Location Lon containing specified keyword
        /// </summary>
		/// <param name="cityLocationLon"> City Location Lon</param>
		/// <returns>List of  City</returns>
		OperationResult DeleteByCityLocationLon(float cityLocationLon);

        /// <summary>
        /// Delete all  City data with city Location Lat containing specified keyword
        /// </summary>
		/// <param name="cityLocationLat"> City Location Lat</param>
		/// <returns>List of  City</returns>
		OperationResult DeleteByCityLocationLat(float cityLocationLat);

        /// <summary>
        /// Delete all  City data with lang I D containing specified keyword
        /// </summary>
		/// <param name="langID"> Lang I D</param>
		/// <returns>List of  City</returns>
		OperationResult DeleteByLangID(string langID);

        /// <summary>
        /// Delete all  City data with specified country Id 
        /// </summary>
		/// <param name="countryId"> Country Id</param>
		/// <returns>List of  City</returns>
		OperationResult DeleteByCountryId(Int16 countryId);

	}
}