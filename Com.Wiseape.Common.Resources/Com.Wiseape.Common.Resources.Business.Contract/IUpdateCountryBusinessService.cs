using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Wiseape.Utility;
using Com.Wiseape.Common.Data.Model;


namespace Com.Wiseape.Common.Resources.Business.Contract
{
    public interface IUpdateCountryBusinessService
    {

        /// <summary>
        /// Updates  Country's country Name which has specified idCountry
        /// </summary>
		/// <param name="idCountry">id Country</param>
		/// <param name="countryName">country Name</param>
		/// <returns>List of  Country</returns>
		OperationResult UpdateCountryName(Int16 idCountry, string countryName);

        /// <summary>
        /// Updates  Country's country Desc which has specified idCountry
        /// </summary>
		/// <param name="idCountry">id Country</param>
		/// <param name="countryDesc">country Desc</param>
		/// <returns>List of  Country</returns>
		OperationResult UpdateCountryDesc(Int16 idCountry, string countryDesc);

        /// <summary>
        /// Updates  Country's country Flag Icon which has specified idCountry
        /// </summary>
		/// <param name="idCountry">id Country</param>
		/// <param name="countryFlagIcon">country Flag Icon</param>
		/// <returns>List of  Country</returns>
		OperationResult UpdateCountryFlagIcon(Int16 idCountry, string countryFlagIcon);

        /// <summary>
        /// Updates  Country's is Active which has specified idCountry
        /// </summary>
		/// <param name="idCountry">id Country</param>
		/// <param name="isActive">is Active</param>
		/// <returns>List of  Country</returns>
		OperationResult UpdateIsActive(Int16 idCountry, Int16 isActive);

	}
}