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
    /// Interface for City Service
    /// </summary>
    [ServiceContract]
    public interface ICityService
    {
    
        /// <summary>
        /// Service to add City data to data store.
        /// This is a POST request.
        /// </summary>
        /// <param name="CityForm">City data from POST request</param>
        /// <return>JSON string representation of operation result</return>
        [OperationContract]
        Stream AddCity(City cityForm);

        /// <summary>
        /// Service to update City data to data store.
        /// This is a POST request.
        /// </summary>
        /// <param name="cityForm">City data from POST request</param>
        /// <return>JSON string representation of operation result</return>
        [OperationContract]
        Stream UpdateCity(City cityForm);

        /// <summary>
        /// Service to delete City data from data store. 
        /// The data deleted is defined by idCity.
        /// This is a GET request.
        /// </summary>
        /// <param name="idCity">the key value of the data</param>
        /// <return>JSON string representation of operation result</return>  
        [OperationContract]
        Stream DeleteCity(string idCity);

        /// <summary>
        /// Service to get a City data from data store. 
        /// The data retrieved is defined by idCity.
        /// This is a GET request.
        /// </summary>
        /// <param name="idCity">the key value of the data</param>
        /// <return>JSON string representation of operation result</return>    
        [OperationContract]
       	Stream GetCity(string idCity);

        /// <summary>
        /// Service to get all the City data from data store. 
        /// The data items retrieved are those who contain the keyword given. 
        /// This is a GET request.
        /// </summary>
        /// <param name="keyword">the keyword to search</param>
        /// <param name="page">the page of the data navigation</param>
        /// <param name="max">the maximum amount of data to retrieve</param>
        /// <return>JSON string representation of operation result</return>    
		[OperationContract]
        Stream FindCity(string keyword, string page, string max);	
        

        /// <summary>
        /// Finds all  City data with city Name containing specified keyword
        /// </summary>
		/// <param name="cityName"> City Name</param>
		/// <returns>List of  City</returns>
		[OperationContract]
		Stream FindByCityName(string cityName);

        /// <summary>
        /// Updates  City's city Name which has specified idCity
        /// </summary>
		/// <param name="idCity">id City</param>
		/// <param name="cityName">city Name</param>
		/// <returns>List of  City</returns>
		[OperationContract]
		Stream UpdateCityName(string idCity,string cityName);

        /// <summary>
        /// Delete all  City data with city Name containing specified keyword
        /// </summary>
		/// <param name="cityName"> City Name</param>
		/// <returns>List of  City</returns>
		[OperationContract]
		Stream DeleteByCityName(string cityName);

        /// <summary>
        /// Finds all  City data with city Location Lon containing specified keyword
        /// </summary>
		/// <param name="cityLocationLon"> City Location Lon</param>
		/// <returns>List of  City</returns>
		[OperationContract]
		Stream FindByCityLocationLon(string cityLocationLon);

        /// <summary>
        /// Updates  City's city Location Lon which has specified idCity
        /// </summary>
		/// <param name="idCity">id City</param>
		/// <param name="cityLocationLon">city Location Lon</param>
		/// <returns>List of  City</returns>
		[OperationContract]
		Stream UpdateCityLocationLon(string idCity,string cityLocationLon);

        /// <summary>
        /// Delete all  City data with city Location Lon containing specified keyword
        /// </summary>
		/// <param name="cityLocationLon"> City Location Lon</param>
		/// <returns>List of  City</returns>
		[OperationContract]
		Stream DeleteByCityLocationLon(string cityLocationLon);

        /// <summary>
        /// Finds all  City data with city Location Lat containing specified keyword
        /// </summary>
		/// <param name="cityLocationLat"> City Location Lat</param>
		/// <returns>List of  City</returns>
		[OperationContract]
		Stream FindByCityLocationLat(string cityLocationLat);

        /// <summary>
        /// Updates  City's city Location Lat which has specified idCity
        /// </summary>
		/// <param name="idCity">id City</param>
		/// <param name="cityLocationLat">city Location Lat</param>
		/// <returns>List of  City</returns>
		[OperationContract]
		Stream UpdateCityLocationLat(string idCity,string cityLocationLat);

        /// <summary>
        /// Delete all  City data with city Location Lat containing specified keyword
        /// </summary>
		/// <param name="cityLocationLat"> City Location Lat</param>
		/// <returns>List of  City</returns>
		[OperationContract]
		Stream DeleteByCityLocationLat(string cityLocationLat);

        /// <summary>
        /// Finds all  City data with lang I D containing specified keyword
        /// </summary>
		/// <param name="langID"> Lang I D</param>
		/// <returns>List of  City</returns>
		[OperationContract]
		Stream FindByLangID(string langID);

        /// <summary>
        /// Updates  City's lang I D which has specified idCity
        /// </summary>
		/// <param name="idCity">id City</param>
		/// <param name="langID">lang I D</param>
		/// <returns>List of  City</returns>
		[OperationContract]
		Stream UpdateLangID(string idCity,string langID);

        /// <summary>
        /// Delete all  City data with lang I D containing specified keyword
        /// </summary>
		/// <param name="langID"> Lang I D</param>
		/// <returns>List of  City</returns>
		[OperationContract]
		Stream DeleteByLangID(string langID);

        /// <summary>
        /// Finds all  City data with specified country Id 
        /// </summary>
		/// <param name="countryId"> Country Id</param>
		/// <returns>List of  City</returns>
		[OperationContract]
		Stream FindByCountryId(string countryId);

        /// <summary>
        /// Updates  City's country Id which has specified idCity
        /// </summary>
		/// <param name="idCity">id City</param>
		/// <param name="countryId">country Id</param>
		/// <returns>List of  City</returns>
		[OperationContract]
		Stream UpdateCountryId(string idCity,string countryId);

        /// <summary>
        /// Delete all  City data with specified country Id 
        /// </summary>
		/// <param name="countryId"> Country Id</param>
		/// <returns>List of  City</returns>
		[OperationContract]
		Stream DeleteByCountryId(string countryId);
    
    }
}