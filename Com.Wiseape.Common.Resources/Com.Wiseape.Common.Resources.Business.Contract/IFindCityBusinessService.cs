using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Wiseape.Utility;
using Com.Wiseape.Common.Data.Model;


namespace Com.Wiseape.Common.Resources.Business.Contract
{
    public interface IFindCityBusinessService
    {

        /// <summary>
        /// Finds all  City data with city Name containing specified keyword
        /// </summary>
		/// <param name="cityName"> City Name</param>
		/// <returns>List of  City</returns>
		OperationResult FindByCityName(string cityName);

        /// <summary>
        /// Finds all  City data with city Location Lon containing specified keyword
        /// </summary>
		/// <param name="cityLocationLon"> City Location Lon</param>
		/// <returns>List of  City</returns>
		OperationResult FindByCityLocationLon(float cityLocationLon);

        /// <summary>
        /// Finds all  City data with city Location Lat containing specified keyword
        /// </summary>
		/// <param name="cityLocationLat"> City Location Lat</param>
		/// <returns>List of  City</returns>
		OperationResult FindByCityLocationLat(float cityLocationLat);

        /// <summary>
        /// Finds all  City data with lang I D containing specified keyword
        /// </summary>
		/// <param name="langID"> Lang I D</param>
		/// <returns>List of  City</returns>
		OperationResult FindByLangID(string langID);

        /// <summary>
        /// Finds all  City data with specified country Id 
        /// </summary>
		/// <param name="countryId"> Country Id</param>
		/// <returns>List of  City</returns>
		OperationResult FindByCountryId(Int16 countryId);

	}
}