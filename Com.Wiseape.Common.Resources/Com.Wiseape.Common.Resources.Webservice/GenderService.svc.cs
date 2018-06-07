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
    public class GenderService : IGenderService
    {

        class Keywords
        {
            public static string Gender = "Common.Resources.Gender";
            public static string FindGender = "Find.Common.Resources.Gender";
            public static string AddGender = "Add.Common.Resources.Gender";
            public static string UpdateGender = "Update.Common.Resources.Gender";
            public static string DeleteGender = "Delete.Common.Resources.Gender";
        }

        /// <summary>
        /// Service to add Gender data to data store.
        /// This is a POST request.
        /// </summary>
        /// <param name="GenderForm">Gender data from POST request</param>
        /// <return>JSON string representation of operation result</return>
        [WebInvoke(Method = "POST",
                    ResponseFormat = WebMessageFormat.Json,
                    RequestFormat = WebMessageFormat.Json,
                    UriTemplate = "gender/add")]
        public Stream AddGender(Gender genderForm)
        {
            BaseBusinessService<Gender> businessService = (BaseBusinessService<Gender>)BusinessFactory.Create(Keywords.AddGender);
            OperationResult result = businessService.Add(genderForm);
            return result.ToJsonStream();
        }

        /// <summary>
        /// Service to update Gender data to data store.
        /// This is a POST request.
        /// </summary>
        /// <param name="genderForm">Gender data from POST request</param>
        /// <return>JSON string representation of operation result</return>
        [WebInvoke(Method = "POST",
                    ResponseFormat = WebMessageFormat.Json,
                    RequestFormat = WebMessageFormat.Json,
                    UriTemplate = "gender/update")]
        public Stream UpdateGender(Gender genderForm)
        {
            BaseBusinessService<Gender> businessService = (BaseBusinessService<Gender>)BusinessFactory.Create(Keywords.UpdateGender);
            OperationResult result = businessService.Update(genderForm);
            return result.ToJsonStream();
        }

        /// <summary>
        /// Service to delete Gender data from data store. 
        /// The data deleted is defined by idGender.
        /// This is a GET request.
        /// </summary>
        /// <param name="idGender">the key value of the data</param>
        /// <return>JSON string representation of operation result</return>  
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "gender/delete/{idGender}")]
        public Stream DeleteGender(string idGender)
        {
            BaseBusinessService<Gender> businessService = (BaseBusinessService<Gender>)BusinessFactory.Create(Keywords.DeleteGender);
            OperationResult result = businessService.Delete(idGender);
            return result.ToJsonStream();
        }

        /// <summary>
        /// Service to get a Gender data from data store. 
        /// The data retrieved is defined by idGender.
        /// This is a GET request.
        /// </summary>
        /// <param name="idGender">the key value of the data</param>
        /// <return>JSON string representation of operation result</return>    
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "gender/get/{idGender}")]
        public Stream GetGender(string idGender)
        {
            BaseBusinessService<Gender> businessService = (BaseBusinessService<Gender>)BusinessFactory.Create(Keywords.FindGender);
            OperationResult result = businessService.Get(idGender);
            return result.ToJsonStream();
        }

        /// <summary>
        /// Service to get all the Gender data from data store. 
        /// The data items retrieved are those who contain the keyword given. 
        /// This is a GET request.
        /// </summary>
        /// <param name="keyword">the keyword to search</param>
        /// <param name="page">the page of the data navigation</param>
        /// <param name="max">the maximum amount of data to retrieve</param>
        /// <return>JSON string representation of operation result</return>    
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "gender/find/{keyword}/{page}/{max}")]
        public Stream FindGender(string keyword, string page, string max)
        {
            BaseBusinessService<Gender> businessService = (BaseBusinessService<Gender>)BusinessFactory.Create(Keywords.FindGender);

            SelectParam selectParam = new SelectParam();
            selectParam.Keyword = keyword;
            if (keyword.ToLower() == "all")
                selectParam.Keyword = "";
            OperationResult result = businessService.FindAll(selectParam, Convert.ToInt16(page), Convert.ToInt16(max) );

            return result.ToJsonStream();
        }	
        

        /// <summary>
        /// Finds all  Gender data with gender Name containing specified keyword
        /// </summary>
		/// <param name="genderName"> Gender Name</param>
		/// <returns>List of  Gender</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "gender/find-by-gender-name/{genderName}")]
        public Stream FindByGenderName(string genderName)
        {
            IFindGenderBusinessService businessService = (IFindGenderBusinessService)BusinessFactory.Create(Keywords.FindGender);
            OperationResult result = businessService.FindByGenderName(Convert.ToString(genderName));
            return result.ToJsonStream();
        }		
		

        /// <summary>
        /// Updates  Gender's gender Name which has specified idGender
        /// </summary>
		/// <param name="idGender">id Gender</param>
		/// <param name="genderName">gender Name</param>
		/// <returns>Result of the operation</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "gender/update-gender-name/{idGender}/{genderName}")]
        public Stream UpdateGenderName(string idGender,string genderName)
        {
            IUpdateGenderBusinessService businessService = (IUpdateGenderBusinessService)BusinessFactory.Create(Keywords.UpdateGender);
            OperationResult result = businessService.UpdateGenderName(Convert.ToInt16(idGender),Convert.ToString(genderName) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Delete all  Gender data with gender Name containing specified keyword
        /// </summary>
		/// <param name="genderName"> Gender Name</param>
		/// <returns>List of  Gender</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "gender/delete-by-gender-name/{genderName}")]
        public Stream DeleteByGenderName(string genderName)
        {
            IDeleteGenderBusinessService businessService = (IDeleteGenderBusinessService)BusinessFactory.Create(Keywords.DeleteGender);
            OperationResult result = businessService.DeleteByGenderName(Convert.ToString(genderName) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Finds all  Gender data with gender Icon containing specified keyword
        /// </summary>
		/// <param name="genderIcon"> Gender Icon</param>
		/// <returns>List of  Gender</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "gender/find-by-gender-icon/{genderIcon}")]
        public Stream FindByGenderIcon(string genderIcon)
        {
            IFindGenderBusinessService businessService = (IFindGenderBusinessService)BusinessFactory.Create(Keywords.FindGender);
            OperationResult result = businessService.FindByGenderIcon(Convert.ToString(genderIcon));
            return result.ToJsonStream();
        }		
		

        /// <summary>
        /// Updates  Gender's gender Icon which has specified idGender
        /// </summary>
		/// <param name="idGender">id Gender</param>
		/// <param name="genderIcon">gender Icon</param>
		/// <returns>Result of the operation</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "gender/update-gender-icon/{idGender}/{genderIcon}")]
        public Stream UpdateGenderIcon(string idGender,string genderIcon)
        {
            IUpdateGenderBusinessService businessService = (IUpdateGenderBusinessService)BusinessFactory.Create(Keywords.UpdateGender);
            OperationResult result = businessService.UpdateGenderIcon(Convert.ToInt16(idGender),Convert.ToString(genderIcon) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Delete all  Gender data with gender Icon containing specified keyword
        /// </summary>
		/// <param name="genderIcon"> Gender Icon</param>
		/// <returns>List of  Gender</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "gender/delete-by-gender-icon/{genderIcon}")]
        public Stream DeleteByGenderIcon(string genderIcon)
        {
            IDeleteGenderBusinessService businessService = (IDeleteGenderBusinessService)BusinessFactory.Create(Keywords.DeleteGender);
            OperationResult result = businessService.DeleteByGenderIcon(Convert.ToString(genderIcon) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Finds all  Gender data with language I D containing specified keyword
        /// </summary>
		/// <param name="languageID"> Language I D</param>
		/// <returns>List of  Gender</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "gender/find-by-language-i-d/{languageID}")]
        public Stream FindByLanguageID(string languageID)
        {
            IFindGenderBusinessService businessService = (IFindGenderBusinessService)BusinessFactory.Create(Keywords.FindGender);
            OperationResult result = businessService.FindByLanguageID(Convert.ToString(languageID));
            return result.ToJsonStream();
        }		
		

        /// <summary>
        /// Updates  Gender's language I D which has specified idGender
        /// </summary>
		/// <param name="idGender">id Gender</param>
		/// <param name="languageID">language I D</param>
		/// <returns>Result of the operation</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "gender/update-language-i-d/{idGender}/{languageID}")]
        public Stream UpdateLanguageID(string idGender,string languageID)
        {
            IUpdateGenderBusinessService businessService = (IUpdateGenderBusinessService)BusinessFactory.Create(Keywords.UpdateGender);
            OperationResult result = businessService.UpdateLanguageID(Convert.ToInt16(idGender),Convert.ToString(languageID) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Delete all  Gender data with language I D containing specified keyword
        /// </summary>
		/// <param name="languageID"> Language I D</param>
		/// <returns>List of  Gender</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "gender/delete-by-language-i-d/{languageID}")]
        public Stream DeleteByLanguageID(string languageID)
        {
            IDeleteGenderBusinessService businessService = (IDeleteGenderBusinessService)BusinessFactory.Create(Keywords.DeleteGender);
            OperationResult result = businessService.DeleteByLanguageID(Convert.ToString(languageID) );
            return result.ToJsonStream();
        }	
		
 
	}
}