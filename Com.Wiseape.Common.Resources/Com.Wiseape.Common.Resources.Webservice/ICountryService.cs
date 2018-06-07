using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Wiseape.Common.Data.Model;
using Com.Wiseape.Common.Resources.Business.Contract;

using System.ServiceModel;

namespace Com.Wiseape.Common.Resources.Webservice
{
    /// <summary>
    /// Interface for Country Service
    /// </summary>
    [ServiceContract]
    public interface ICountryService
    {
    
        /// <summary>
        /// Service to add Country data to data store.
        /// This is a POST request.
        /// </summary>
        /// <param name="CountryForm">Country data from POST request</param>
        /// <return>JSON string representation of operation result</return>
        [OperationContract]
        Stream AddCountry(Country countryForm);

        /// <summary>
        /// Service to update Country data to data store.
        /// This is a POST request.
        /// </summary>
        /// <param name="countryForm">Country data from POST request</param>
        /// <return>JSON string representation of operation result</return>
        [OperationContract]
        Stream UpdateCountry(Country countryForm);

        /// <summary>
        /// Service to delete Country data from data store. 
        /// The data deleted is defined by idCountry.
        /// This is a GET request.
        /// </summary>
        /// <param name="idCountry">the key value of the data</param>
        /// <return>JSON string representation of operation result</return>  
        [OperationContract]
        Stream DeleteCountry(string idCountry);

        /// <summary>
        /// Service to get a Country data from data store. 
        /// The data retrieved is defined by idCountry.
        /// This is a GET request.
        /// </summary>
        /// <param name="idCountry">the key value of the data</param>
        /// <return>JSON string representation of operation result</return>    
        [OperationContract]
       	Stream GetCountry(string idCountry);

        /// <summary>
        /// Service to get all the Country data from data store. 
        /// The data items retrieved are those who contain the keyword given. 
        /// This is a GET request.
        /// </summary>
        /// <param name="keyword">the keyword to search</param>
        /// <param name="page">the page of the data navigation</param>
        /// <param name="max">the maximum amount of data to retrieve</param>
        /// <return>JSON string representation of operation result</return>    
		[OperationContract]
        Stream FindCountry(string keyword, string page, string max);	
        

        /// <summary>
        /// Finds all  Country data with country Name containing specified keyword
        /// </summary>
		/// <param name="countryName"> Country Name</param>
		/// <returns>List of  Country</returns>
		[OperationContract]
		Stream FindByCountryName(string countryName);

        /// <summary>
        /// Updates  Country's country Name which has specified idCountry
        /// </summary>
		/// <param name="idCountry">id Country</param>
		/// <param name="countryName">country Name</param>
		/// <returns>List of  Country</returns>
		[OperationContract]
		Stream UpdateCountryName(string idCountry,string countryName);

        /// <summary>
        /// Delete all  Country data with country Name containing specified keyword
        /// </summary>
		/// <param name="countryName"> Country Name</param>
		/// <returns>List of  Country</returns>
		[OperationContract]
		Stream DeleteByCountryName(string countryName);

        /// <summary>
        /// Finds all  Country data with country Desc containing specified keyword
        /// </summary>
		/// <param name="countryDesc"> Country Desc</param>
		/// <returns>List of  Country</returns>
		[OperationContract]
		Stream FindByCountryDesc(string countryDesc);

        /// <summary>
        /// Updates  Country's country Desc which has specified idCountry
        /// </summary>
		/// <param name="idCountry">id Country</param>
		/// <param name="countryDesc">country Desc</param>
		/// <returns>List of  Country</returns>
		[OperationContract]
		Stream UpdateCountryDesc(string idCountry,string countryDesc);

        /// <summary>
        /// Delete all  Country data with country Desc containing specified keyword
        /// </summary>
		/// <param name="countryDesc"> Country Desc</param>
		/// <returns>List of  Country</returns>
		[OperationContract]
		Stream DeleteByCountryDesc(string countryDesc);

        /// <summary>
        /// Finds all  Country data with country Flag Icon containing specified keyword
        /// </summary>
		/// <param name="countryFlagIcon"> Country Flag Icon</param>
		/// <returns>List of  Country</returns>
		[OperationContract]
		Stream FindByCountryFlagIcon(string countryFlagIcon);

        /// <summary>
        /// Updates  Country's country Flag Icon which has specified idCountry
        /// </summary>
		/// <param name="idCountry">id Country</param>
		/// <param name="countryFlagIcon">country Flag Icon</param>
		/// <returns>List of  Country</returns>
		[OperationContract]
		Stream UpdateCountryFlagIcon(string idCountry,string countryFlagIcon);

        /// <summary>
        /// Delete all  Country data with country Flag Icon containing specified keyword
        /// </summary>
		/// <param name="countryFlagIcon"> Country Flag Icon</param>
		/// <returns>List of  Country</returns>
		[OperationContract]
		Stream DeleteByCountryFlagIcon(string countryFlagIcon);

        /// <summary>
        /// Finds all  Country data with specified is Active 
        /// </summary>
		/// <param name="isActive"> Is Active</param>
		/// <returns>List of  Country</returns>
		[OperationContract]
		Stream FindByIsActive(string isActive);

        /// <summary>
        /// Updates  Country's is Active which has specified idCountry
        /// </summary>
		/// <param name="idCountry">id Country</param>
		/// <param name="isActive">is Active</param>
		/// <returns>List of  Country</returns>
		[OperationContract]
		Stream UpdateIsActive(string idCountry,string isActive);

        /// <summary>
        /// Delete all  Country data with specified is Active 
        /// </summary>
		/// <param name="isActive"> Is Active</param>
		/// <returns>List of  Country</returns>
		[OperationContract]
		Stream DeleteByIsActive(string isActive);
    
    }
}