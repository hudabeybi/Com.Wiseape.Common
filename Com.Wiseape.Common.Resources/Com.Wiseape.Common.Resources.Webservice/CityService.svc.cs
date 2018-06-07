using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel.Web;
using Com.Wiseape.Framework;
using Com.Wiseape.Utility;
using Com.Wiseape.Factory;
using Com.Wiseape.Common.Data.Model;
using Com.Wiseape.Common.Resources.Business.Contract;


namespace Com.Wiseape.Common.Resources.Webservice
{
    public class CityService : ICityService
    {

        class Keywords
        {
            public static string City = "Common.Resources.City";
            public static string FindCity = "Find.Common.Resources.City";
            public static string AddCity = "Add.Common.Resources.City";
            public static string UpdateCity = "Update.Common.Resources.City";
            public static string DeleteCity = "Delete.Common.Resources.City";
        }

        /// <summary>
        /// Service to add City data to data store.
        /// This is a POST request.
        /// </summary>
        /// <param name="CityForm">City data from POST request</param>
        /// <return>JSON string representation of operation result</return>
        [WebInvoke(Method = "POST",
                    ResponseFormat = WebMessageFormat.Json,
                    RequestFormat = WebMessageFormat.Json,
                    UriTemplate = "city/add")]
        public Stream AddCity(City cityForm)
        {
            BaseBusinessService<City> businessService = (BaseBusinessService<City>)BusinessFactory.Create(Keywords.AddCity);
            OperationResult result = businessService.Add(cityForm);
            return result.ToJsonStream();
        }

        /// <summary>
        /// Service to update City data to data store.
        /// This is a POST request.
        /// </summary>
        /// <param name="cityForm">City data from POST request</param>
        /// <return>JSON string representation of operation result</return>
        [WebInvoke(Method = "POST",
                    ResponseFormat = WebMessageFormat.Json,
                    RequestFormat = WebMessageFormat.Json,
                    UriTemplate = "city/update")]
        public Stream UpdateCity(City cityForm)
        {
            BaseBusinessService<City> businessService = (BaseBusinessService<City>)BusinessFactory.Create(Keywords.UpdateCity);
            OperationResult result = businessService.Update(cityForm);
            return result.ToJsonStream();
        }

        /// <summary>
        /// Service to delete City data from data store. 
        /// The data deleted is defined by idCity.
        /// This is a GET request.
        /// </summary>
        /// <param name="idCity">the key value of the data</param>
        /// <return>JSON string representation of operation result</return>  
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "city/delete/{idCity}")]
        public Stream DeleteCity(string idCity)
        {
            BaseBusinessService<City> businessService = (BaseBusinessService<City>)BusinessFactory.Create(Keywords.DeleteCity);
            OperationResult result = businessService.Delete(idCity);
            return result.ToJsonStream();
        }

        /// <summary>
        /// Service to get a City data from data store. 
        /// The data retrieved is defined by idCity.
        /// This is a GET request.
        /// </summary>
        /// <param name="idCity">the key value of the data</param>
        /// <return>JSON string representation of operation result</return>    
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "city/get/{idCity}")]
        public Stream GetCity(string idCity)
        {
            BaseBusinessService<City> businessService = (BaseBusinessService<City>)BusinessFactory.Create(Keywords.FindCity);
            OperationResult result = businessService.Get(idCity);
            return result.ToJsonStream();
        }

        /// <summary>
        /// Service to get all the City data from data store. 
        /// The data items retrieved are those who contain the keyword given. 
        /// This is a GET request.
        /// </summary>
        /// <param name="keyword">the keyword to search</param>
        /// <param name="page">the page of the data navigation</param>
        /// <param name="max">the maximum amount of data to retrieve</param>
        /// <return>JSON string representation of operation result</return>    
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "city/find/{keyword}/{page}/{max}")]
        public Stream FindCity(string keyword, string page, string max)
        {
            BaseBusinessService<City> businessService = (BaseBusinessService<City>)BusinessFactory.Create(Keywords.FindCity);

            SelectParam selectParam = new SelectParam();
            selectParam.Keyword = keyword;
            if (keyword.ToLower() == "all")
                selectParam.Keyword = "";
            OperationResult result = businessService.FindAll(selectParam, Convert.ToInt16(page), Convert.ToInt16(max) );

            return result.ToJsonStream();
        }	
        

        /// <summary>
        /// Finds all  City data with city Name containing specified keyword
        /// </summary>
		/// <param name="cityName"> City Name</param>
		/// <returns>List of  City</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "city/find-by-city-name/{cityName}")]
        public Stream FindByCityName(string cityName)
        {
            IFindCityBusinessService businessService = (IFindCityBusinessService)BusinessFactory.Create(Keywords.FindCity);
            OperationResult result = businessService.FindByCityName(Convert.ToString(cityName));
            return result.ToJsonStream();
        }		
		

        /// <summary>
        /// Updates  City's city Name which has specified idCity
        /// </summary>
		/// <param name="idCity">id City</param>
		/// <param name="cityName">city Name</param>
		/// <returns>Result of the operation</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "city/update-city-name/{idCity}/{cityName}")]
        public Stream UpdateCityName(string idCity,string cityName)
        {
            IUpdateCityBusinessService businessService = (IUpdateCityBusinessService)BusinessFactory.Create(Keywords.UpdateCity);
            OperationResult result = businessService.UpdateCityName(Convert.ToInt64(idCity),Convert.ToString(cityName) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Delete all  City data with city Name containing specified keyword
        /// </summary>
		/// <param name="cityName"> City Name</param>
		/// <returns>List of  City</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "city/delete-by-city-name/{cityName}")]
        public Stream DeleteByCityName(string cityName)
        {
            IDeleteCityBusinessService businessService = (IDeleteCityBusinessService)BusinessFactory.Create(Keywords.DeleteCity);
            OperationResult result = businessService.DeleteByCityName(Convert.ToString(cityName) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Finds all  City data with city Location Lon containing specified keyword
        /// </summary>
		/// <param name="cityLocationLon"> City Location Lon</param>
		/// <returns>List of  City</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "city/find-by-city-location-lon/{cityLocationLon}")]
        public Stream FindByCityLocationLon(string cityLocationLon)
        {
            IFindCityBusinessService businessService = (IFindCityBusinessService)BusinessFactory.Create(Keywords.FindCity);
            OperationResult result = businessService.FindByCityLocationLon((float)Convert.ToDouble(cityLocationLon));
            return result.ToJsonStream();
        }		
		

        /// <summary>
        /// Updates  City's city Location Lon which has specified idCity
        /// </summary>
		/// <param name="idCity">id City</param>
		/// <param name="cityLocationLon">city Location Lon</param>
		/// <returns>Result of the operation</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "city/update-city-location-lon/{idCity}/{cityLocationLon}")]
        public Stream UpdateCityLocationLon(string idCity,string cityLocationLon)
        {
            IUpdateCityBusinessService businessService = (IUpdateCityBusinessService)BusinessFactory.Create(Keywords.UpdateCity);
            OperationResult result = businessService.UpdateCityLocationLon(Convert.ToInt64(idCity),(float)Convert.ToDouble(cityLocationLon) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Delete all  City data with city Location Lon containing specified keyword
        /// </summary>
		/// <param name="cityLocationLon"> City Location Lon</param>
		/// <returns>List of  City</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "city/delete-by-city-location-lon/{cityLocationLon}")]
        public Stream DeleteByCityLocationLon(string cityLocationLon)
        {
            IDeleteCityBusinessService businessService = (IDeleteCityBusinessService)BusinessFactory.Create(Keywords.DeleteCity);
            OperationResult result = businessService.DeleteByCityLocationLon((float)Convert.ToDouble(cityLocationLon) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Finds all  City data with city Location Lat containing specified keyword
        /// </summary>
		/// <param name="cityLocationLat"> City Location Lat</param>
		/// <returns>List of  City</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "city/find-by-city-location-lat/{cityLocationLat}")]
        public Stream FindByCityLocationLat(string cityLocationLat)
        {
            IFindCityBusinessService businessService = (IFindCityBusinessService)BusinessFactory.Create(Keywords.FindCity);
            OperationResult result = businessService.FindByCityLocationLat((float)Convert.ToDouble(cityLocationLat));
            return result.ToJsonStream();
        }		
		

        /// <summary>
        /// Updates  City's city Location Lat which has specified idCity
        /// </summary>
		/// <param name="idCity">id City</param>
		/// <param name="cityLocationLat">city Location Lat</param>
		/// <returns>Result of the operation</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "city/update-city-location-lat/{idCity}/{cityLocationLat}")]
        public Stream UpdateCityLocationLat(string idCity,string cityLocationLat)
        {
            IUpdateCityBusinessService businessService = (IUpdateCityBusinessService)BusinessFactory.Create(Keywords.UpdateCity);
            OperationResult result = businessService.UpdateCityLocationLat(Convert.ToInt64(idCity),(float)Convert.ToDouble(cityLocationLat) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Delete all  City data with city Location Lat containing specified keyword
        /// </summary>
		/// <param name="cityLocationLat"> City Location Lat</param>
		/// <returns>List of  City</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "city/delete-by-city-location-lat/{cityLocationLat}")]
        public Stream DeleteByCityLocationLat(string cityLocationLat)
        {
            IDeleteCityBusinessService businessService = (IDeleteCityBusinessService)BusinessFactory.Create(Keywords.DeleteCity);
            OperationResult result = businessService.DeleteByCityLocationLat((float)Convert.ToDouble(cityLocationLat) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Finds all  City data with lang I D containing specified keyword
        /// </summary>
		/// <param name="langID"> Lang I D</param>
		/// <returns>List of  City</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "city/find-by-lang-i-d/{langID}")]
        public Stream FindByLangID(string langID)
        {
            IFindCityBusinessService businessService = (IFindCityBusinessService)BusinessFactory.Create(Keywords.FindCity);
            OperationResult result = businessService.FindByLangID(Convert.ToString(langID));
            return result.ToJsonStream();
        }		
		

        /// <summary>
        /// Updates  City's lang I D which has specified idCity
        /// </summary>
		/// <param name="idCity">id City</param>
		/// <param name="langID">lang I D</param>
		/// <returns>Result of the operation</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "city/update-lang-i-d/{idCity}/{langID}")]
        public Stream UpdateLangID(string idCity,string langID)
        {
            IUpdateCityBusinessService businessService = (IUpdateCityBusinessService)BusinessFactory.Create(Keywords.UpdateCity);
            OperationResult result = businessService.UpdateLangID(Convert.ToInt64(idCity),Convert.ToString(langID) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Delete all  City data with lang I D containing specified keyword
        /// </summary>
		/// <param name="langID"> Lang I D</param>
		/// <returns>List of  City</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "city/delete-by-lang-i-d/{langID}")]
        public Stream DeleteByLangID(string langID)
        {
            IDeleteCityBusinessService businessService = (IDeleteCityBusinessService)BusinessFactory.Create(Keywords.DeleteCity);
            OperationResult result = businessService.DeleteByLangID(Convert.ToString(langID) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Finds all  City data with specified country Id 
        /// </summary>
		/// <param name="countryId"> Country Id</param>
		/// <returns>List of  City</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "city/find-by-country-id/{countryId}")]
        public Stream FindByCountryId(string countryId)
        {
            IFindCityBusinessService businessService = (IFindCityBusinessService)BusinessFactory.Create(Keywords.FindCity);
            OperationResult result = businessService.FindByCountryId(Convert.ToInt16(countryId) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Updates  City's country Id which has specified idCity
        /// </summary>
		/// <param name="idCity">id City</param>
		/// <param name="countryId">country Id</param>
		/// <returns>List of  City</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "city/update-country-id/{idCity}/{countryId}")]
        public Stream UpdateCountryId(string idCity,string countryId)
        {
            IUpdateCityBusinessService businessService = (IUpdateCityBusinessService)BusinessFactory.Create(Keywords.UpdateCity);
            OperationResult result = businessService.UpdateCountryId(Convert.ToInt64(idCity),Convert.ToInt16(countryId) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Delete all  City data with specified country Id 
        /// </summary>
		/// <param name="countryId"> Country Id</param>
		/// <returns>List of  City</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "city/delete-by-country-id/{countryId}")]
        public Stream DeleteByCountryId(string countryId)
        {
            IDeleteCityBusinessService businessService = (IDeleteCityBusinessService)BusinessFactory.Create(Keywords.DeleteCity);
            OperationResult result = businessService.DeleteByCountryId(Convert.ToInt16(countryId) );
            return result.ToJsonStream();
        }	
		
 
	}
}