using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Wiseape.Utility;
using Com.Wiseape.Common.Data.Model;


namespace Com.Wiseape.Common.Resources.Business.Contract
{
    public interface IDeleteCountryBusinessService
    {

        /// <summary>
        /// Delete all  Country data with country Name containing specified keyword
        /// </summary>
		/// <param name="countryName"> Country Name</param>
		/// <returns>List of  Country</returns>
		OperationResult DeleteByCountryName(string countryName);

        /// <summary>
        /// Delete all  Country data with country Desc containing specified keyword
        /// </summary>
		/// <param name="countryDesc"> Country Desc</param>
		/// <returns>List of  Country</returns>
		OperationResult DeleteByCountryDesc(string countryDesc);

        /// <summary>
        /// Delete all  Country data with country Flag Icon containing specified keyword
        /// </summary>
		/// <param name="countryFlagIcon"> Country Flag Icon</param>
		/// <returns>List of  Country</returns>
		OperationResult DeleteByCountryFlagIcon(string countryFlagIcon);

        /// <summary>
        /// Delete all  Country data with specified is Active 
        /// </summary>
		/// <param name="isActive"> Is Active</param>
		/// <returns>List of  Country</returns>
		OperationResult DeleteByIsActive(Int16 isActive);

	}
}