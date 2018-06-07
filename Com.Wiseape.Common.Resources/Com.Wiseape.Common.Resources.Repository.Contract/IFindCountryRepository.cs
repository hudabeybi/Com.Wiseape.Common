using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Wiseape.Common.Data.Model;



namespace Com.Wiseape.Common.Resources.Repository.Contract
{
    public interface IFindCountryRepository
    {

        /// <summary>
        /// Finds all  Country data with country Name containing specified keyword
        /// </summary>
		/// <param name="countryName"> Country Name</param>
		/// <returns>List of  Country</returns>
		List<Country> FindByCountryName(string countryName);

        /// <summary>
        /// Finds all  Country data with country Desc containing specified keyword
        /// </summary>
		/// <param name="countryDesc"> Country Desc</param>
		/// <returns>List of  Country</returns>
		List<Country> FindByCountryDesc(string countryDesc);

        /// <summary>
        /// Finds all  Country data with country Flag Icon containing specified keyword
        /// </summary>
		/// <param name="countryFlagIcon"> Country Flag Icon</param>
		/// <returns>List of  Country</returns>
		List<Country> FindByCountryFlagIcon(string countryFlagIcon);

        /// <summary>
        /// Finds all  Country data with is Active containing specified keyword
        /// </summary>
		/// <param name="isActive"> Is Active</param>
		/// <returns>List of  Country</returns>
		List<Country> FindByIsActive(Int16 isActive);

    }
}

