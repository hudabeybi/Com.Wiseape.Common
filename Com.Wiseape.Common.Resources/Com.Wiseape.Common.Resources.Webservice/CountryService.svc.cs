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
    public class CountryService : ICountryService
    {

        class Keywords
        {
            public static string Country = "Common.Resources.Country";
            public static string FindCountry = "Find.Common.Resources.Country";
            public static string AddCountry = "Add.Common.Resources.Country";
            public static string UpdateCountry = "Update.Common.Resources.Country";
            public static string DeleteCountry = "Delete.Common.Resources.Country";
        }

        /// <summary>
        /// Service to add Country data to data store.
        /// This is a POST request.
        /// </summary>
        /// <param name="CountryForm">Country data from POST request</param>
        /// <return>JSON string representation of operation result</return>
        [WebInvoke(Method = "POST",
                    ResponseFormat = WebMessageFormat.Json,
                    RequestFormat = WebMessageFormat.Json,
                    UriTemplate = "country/add")]
        public Stream AddCountry(Country countryForm)
        {
            BaseBusinessService<Country> businessService = (BaseBusinessService<Country>)BusinessFactory.Create(Keywords.AddCountry);
            OperationResult result = businessService.Add(countryForm);
            return result.ToJsonStream();
        }

        /// <summary>
        /// Service to update Country data to data store.
        /// This is a POST request.
        /// </summary>
        /// <param name="countryForm">Country data from POST request</param>
        /// <return>JSON string representation of operation result</return>
        [WebInvoke(Method = "POST",
                    ResponseFormat = WebMessageFormat.Json,
                    RequestFormat = WebMessageFormat.Json,
                    UriTemplate = "country/update")]
        public Stream UpdateCountry(Country countryForm)
        {
            BaseBusinessService<Country> businessService = (BaseBusinessService<Country>)BusinessFactory.Create(Keywords.UpdateCountry);
            OperationResult result = businessService.Update(countryForm);
            return result.ToJsonStream();
        }

        /// <summary>
        /// Service to delete Country data from data store. 
        /// The data deleted is defined by idCountry.
        /// This is a GET request.
        /// </summary>
        /// <param name="idCountry">the key value of the data</param>
        /// <return>JSON string representation of operation result</return>  
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "country/delete/{idCountry}")]
        public Stream DeleteCountry(string idCountry)
        {
            BaseBusinessService<Country> businessService = (BaseBusinessService<Country>)BusinessFactory.Create(Keywords.DeleteCountry);
            OperationResult result = businessService.Delete(idCountry);
            return result.ToJsonStream();
        }

        /// <summary>
        /// Service to get a Country data from data store. 
        /// The data retrieved is defined by idCountry.
        /// This is a GET request.
        /// </summary>
        /// <param name="idCountry">the key value of the data</param>
        /// <return>JSON string representation of operation result</return>    
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "country/get/{idCountry}")]
        public Stream GetCountry(string idCountry)
        {
            BaseBusinessService<Country> businessService = (BaseBusinessService<Country>)BusinessFactory.Create(Keywords.FindCountry);
            OperationResult result = businessService.Get(idCountry);
            return result.ToJsonStream();
        }

        /// <summary>
        /// Service to get all the Country data from data store. 
        /// The data items retrieved are those who contain the keyword given. 
        /// This is a GET request.
        /// </summary>
        /// <param name="keyword">the keyword to search</param>
        /// <param name="page">the page of the data navigation</param>
        /// <param name="max">the maximum amount of data to retrieve</param>
        /// <return>JSON string representation of operation result</return>    
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "country/find/{keyword}/{page}/{max}")]
        public Stream FindCountry(string keyword, string page, string max)
        {
            BaseBusinessService<Country> businessService = (BaseBusinessService<Country>)BusinessFactory.Create(Keywords.FindCountry);

            SelectParam selectParam = new SelectParam();
            selectParam.Keyword = keyword;
            if (keyword.ToLower() == "all")
                selectParam.Keyword = "";
            OperationResult result = businessService.FindAll(selectParam, Convert.ToInt16(page), Convert.ToInt16(max) );

            return result.ToJsonStream();
        }	
        

        /// <summary>
        /// Finds all  Country data with country Name containing specified keyword
        /// </summary>
		/// <param name="countryName"> Country Name</param>
		/// <returns>List of  Country</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "country/find-by-country-name/{countryName}")]
        public Stream FindByCountryName(string countryName)
        {
            IFindCountryBusinessService businessService = (IFindCountryBusinessService)BusinessFactory.Create(Keywords.FindCountry);
            OperationResult result = businessService.FindByCountryName(Convert.ToString(countryName));
            return result.ToJsonStream();
        }		
		

        /// <summary>
        /// Updates  Country's country Name which has specified idCountry
        /// </summary>
		/// <param name="idCountry">id Country</param>
		/// <param name="countryName">country Name</param>
		/// <returns>Result of the operation</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "country/update-country-name/{idCountry}/{countryName}")]
        public Stream UpdateCountryName(string idCountry,string countryName)
        {
            IUpdateCountryBusinessService businessService = (IUpdateCountryBusinessService)BusinessFactory.Create(Keywords.UpdateCountry);
            OperationResult result = businessService.UpdateCountryName(Convert.ToInt16(idCountry),Convert.ToString(countryName) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Delete all  Country data with country Name containing specified keyword
        /// </summary>
		/// <param name="countryName"> Country Name</param>
		/// <returns>List of  Country</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "country/delete-by-country-name/{countryName}")]
        public Stream DeleteByCountryName(string countryName)
        {
            IDeleteCountryBusinessService businessService = (IDeleteCountryBusinessService)BusinessFactory.Create(Keywords.DeleteCountry);
            OperationResult result = businessService.DeleteByCountryName(Convert.ToString(countryName) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Finds all  Country data with country Desc containing specified keyword
        /// </summary>
		/// <param name="countryDesc"> Country Desc</param>
		/// <returns>List of  Country</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "country/find-by-country-desc/{countryDesc}")]
        public Stream FindByCountryDesc(string countryDesc)
        {
            IFindCountryBusinessService businessService = (IFindCountryBusinessService)BusinessFactory.Create(Keywords.FindCountry);
            OperationResult result = businessService.FindByCountryDesc(Convert.ToString(countryDesc));
            return result.ToJsonStream();
        }		
		

        /// <summary>
        /// Updates  Country's country Desc which has specified idCountry
        /// </summary>
		/// <param name="idCountry">id Country</param>
		/// <param name="countryDesc">country Desc</param>
		/// <returns>Result of the operation</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "country/update-country-desc/{idCountry}/{countryDesc}")]
        public Stream UpdateCountryDesc(string idCountry,string countryDesc)
        {
            IUpdateCountryBusinessService businessService = (IUpdateCountryBusinessService)BusinessFactory.Create(Keywords.UpdateCountry);
            OperationResult result = businessService.UpdateCountryDesc(Convert.ToInt16(idCountry),Convert.ToString(countryDesc) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Delete all  Country data with country Desc containing specified keyword
        /// </summary>
		/// <param name="countryDesc"> Country Desc</param>
		/// <returns>List of  Country</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "country/delete-by-country-desc/{countryDesc}")]
        public Stream DeleteByCountryDesc(string countryDesc)
        {
            IDeleteCountryBusinessService businessService = (IDeleteCountryBusinessService)BusinessFactory.Create(Keywords.DeleteCountry);
            OperationResult result = businessService.DeleteByCountryDesc(Convert.ToString(countryDesc) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Finds all  Country data with country Flag Icon containing specified keyword
        /// </summary>
		/// <param name="countryFlagIcon"> Country Flag Icon</param>
		/// <returns>List of  Country</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "country/find-by-country-flag-icon/{countryFlagIcon}")]
        public Stream FindByCountryFlagIcon(string countryFlagIcon)
        {
            IFindCountryBusinessService businessService = (IFindCountryBusinessService)BusinessFactory.Create(Keywords.FindCountry);
            OperationResult result = businessService.FindByCountryFlagIcon(Convert.ToString(countryFlagIcon));
            return result.ToJsonStream();
        }		
		

        /// <summary>
        /// Updates  Country's country Flag Icon which has specified idCountry
        /// </summary>
		/// <param name="idCountry">id Country</param>
		/// <param name="countryFlagIcon">country Flag Icon</param>
		/// <returns>Result of the operation</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "country/update-country-flag-icon/{idCountry}/{countryFlagIcon}")]
        public Stream UpdateCountryFlagIcon(string idCountry,string countryFlagIcon)
        {
            IUpdateCountryBusinessService businessService = (IUpdateCountryBusinessService)BusinessFactory.Create(Keywords.UpdateCountry);
            OperationResult result = businessService.UpdateCountryFlagIcon(Convert.ToInt16(idCountry),Convert.ToString(countryFlagIcon) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Delete all  Country data with country Flag Icon containing specified keyword
        /// </summary>
		/// <param name="countryFlagIcon"> Country Flag Icon</param>
		/// <returns>List of  Country</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "country/delete-by-country-flag-icon/{countryFlagIcon}")]
        public Stream DeleteByCountryFlagIcon(string countryFlagIcon)
        {
            IDeleteCountryBusinessService businessService = (IDeleteCountryBusinessService)BusinessFactory.Create(Keywords.DeleteCountry);
            OperationResult result = businessService.DeleteByCountryFlagIcon(Convert.ToString(countryFlagIcon) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Finds all  Country data with specified is Active 
        /// </summary>
		/// <param name="isActive"> Is Active</param>
		/// <returns>List of  Country</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "country/find-by-is-active/{isActive}")]
        public Stream FindByIsActive(string isActive)
        {
            IFindCountryBusinessService businessService = (IFindCountryBusinessService)BusinessFactory.Create(Keywords.FindCountry);
            OperationResult result = businessService.FindByIsActive(Convert.ToInt16(isActive) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Updates  Country's is Active which has specified idCountry
        /// </summary>
		/// <param name="idCountry">id Country</param>
		/// <param name="isActive">is Active</param>
		/// <returns>List of  Country</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "country/update-is-active/{idCountry}/{isActive}")]
        public Stream UpdateIsActive(string idCountry,string isActive)
        {
            IUpdateCountryBusinessService businessService = (IUpdateCountryBusinessService)BusinessFactory.Create(Keywords.UpdateCountry);
            OperationResult result = businessService.UpdateIsActive(Convert.ToInt16(idCountry),Convert.ToInt16(isActive) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Delete all  Country data with specified is Active 
        /// </summary>
		/// <param name="isActive"> Is Active</param>
		/// <returns>List of  Country</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "country/delete-by-is-active/{isActive}")]
        public Stream DeleteByIsActive(string isActive)
        {
            IDeleteCountryBusinessService businessService = (IDeleteCountryBusinessService)BusinessFactory.Create(Keywords.DeleteCountry);
            OperationResult result = businessService.DeleteByIsActive(Convert.ToInt16(isActive) );
            return result.ToJsonStream();
        }	
		
 
	}
}