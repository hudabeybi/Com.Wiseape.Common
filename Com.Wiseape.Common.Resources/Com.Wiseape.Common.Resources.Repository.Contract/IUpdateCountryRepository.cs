using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Wiseape.Common.Data.Model;



namespace Com.Wiseape.Common.Resources.Repository.Contract
{
    public interface IUpdateCountryRepository
    {

	    /// <summary>
	    /// Updates  Country's id Country, country Name by idCountry
	    /// </summary>
		/// <param name="idCountry">id Country</param>
		/// <param name="countryName">country Name</param>
		/// <returns>List of  Country</returns>
		void UpdateCountryName(Int16 idCountry, string countryName);
	
	    /// <summary>
	    /// Updates  Country's id Country, country Desc by idCountry
	    /// </summary>
		/// <param name="idCountry">id Country</param>
		/// <param name="countryDesc">country Desc</param>
		/// <returns>List of  Country</returns>
		void UpdateCountryDesc(Int16 idCountry, string countryDesc);
	
	    /// <summary>
	    /// Updates  Country's id Country, country Flag Icon by idCountry
	    /// </summary>
		/// <param name="idCountry">id Country</param>
		/// <param name="countryFlagIcon">country Flag Icon</param>
		/// <returns>List of  Country</returns>
		void UpdateCountryFlagIcon(Int16 idCountry, string countryFlagIcon);
	
	    /// <summary>
	    /// Updates  Country's id Country, is Active by idCountry
	    /// </summary>
		/// <param name="idCountry">id Country</param>
		/// <param name="isActive">is Active</param>
		/// <returns>List of  Country</returns>
		void UpdateIsActive(Int16 idCountry, Int16 isActive);
	
    }
}

