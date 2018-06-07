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
    public class LanguageService : ILanguageService
    {

        class Keywords
        {
            public static string Language = "Common.Resources.Language";
            public static string FindLanguage = "Find.Common.Resources.Language";
            public static string AddLanguage = "Add.Common.Resources.Language";
            public static string UpdateLanguage = "Update.Common.Resources.Language";
            public static string DeleteLanguage = "Delete.Common.Resources.Language";
        }

        /// <summary>
        /// Service to add Language data to data store.
        /// This is a POST request.
        /// </summary>
        /// <param name="LanguageForm">Language data from POST request</param>
        /// <return>JSON string representation of operation result</return>
        [WebInvoke(Method = "POST",
                    ResponseFormat = WebMessageFormat.Json,
                    RequestFormat = WebMessageFormat.Json,
                    UriTemplate = "language/add")]
        public Stream AddLanguage(Language languageForm)
        {
            BaseBusinessService<Language> businessService = (BaseBusinessService<Language>)BusinessFactory.Create(Keywords.AddLanguage);
            OperationResult result = businessService.Add(languageForm);
            return result.ToJsonStream();
        }

        /// <summary>
        /// Service to update Language data to data store.
        /// This is a POST request.
        /// </summary>
        /// <param name="languageForm">Language data from POST request</param>
        /// <return>JSON string representation of operation result</return>
        [WebInvoke(Method = "POST",
                    ResponseFormat = WebMessageFormat.Json,
                    RequestFormat = WebMessageFormat.Json,
                    UriTemplate = "language/update")]
        public Stream UpdateLanguage(Language languageForm)
        {
            BaseBusinessService<Language> businessService = (BaseBusinessService<Language>)BusinessFactory.Create(Keywords.UpdateLanguage);
            OperationResult result = businessService.Update(languageForm);
            return result.ToJsonStream();
        }

        /// <summary>
        /// Service to delete Language data from data store. 
        /// The data deleted is defined by idLanguage.
        /// This is a GET request.
        /// </summary>
        /// <param name="idLanguage">the key value of the data</param>
        /// <return>JSON string representation of operation result</return>  
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "language/delete/{idLanguage}")]
        public Stream DeleteLanguage(string idLanguage)
        {
            BaseBusinessService<Language> businessService = (BaseBusinessService<Language>)BusinessFactory.Create(Keywords.DeleteLanguage);
            OperationResult result = businessService.Delete(idLanguage);
            return result.ToJsonStream();
        }

        /// <summary>
        /// Service to get a Language data from data store. 
        /// The data retrieved is defined by idLanguage.
        /// This is a GET request.
        /// </summary>
        /// <param name="idLanguage">the key value of the data</param>
        /// <return>JSON string representation of operation result</return>    
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "language/get/{idLanguage}")]
        public Stream GetLanguage(string idLanguage)
        {
            BaseBusinessService<Language> businessService = (BaseBusinessService<Language>)BusinessFactory.Create(Keywords.FindLanguage);
            OperationResult result = businessService.Get(idLanguage);
            return result.ToJsonStream();
        }

        /// <summary>
        /// Service to get all the Language data from data store. 
        /// The data items retrieved are those who contain the keyword given. 
        /// This is a GET request.
        /// </summary>
        /// <param name="keyword">the keyword to search</param>
        /// <param name="page">the page of the data navigation</param>
        /// <param name="max">the maximum amount of data to retrieve</param>
        /// <return>JSON string representation of operation result</return>    
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "language/find/{keyword}/{page}/{max}")]
        public Stream FindLanguage(string keyword, string page, string max)
        {
            BaseBusinessService<Language> businessService = (BaseBusinessService<Language>)BusinessFactory.Create(Keywords.FindLanguage);

            SelectParam selectParam = new SelectParam();
            selectParam.Keyword = keyword;
            if (keyword.ToLower() == "all")
                selectParam.Keyword = "";
            OperationResult result = businessService.FindAll(selectParam, Convert.ToInt16(page), Convert.ToInt16(max) );

            return result.ToJsonStream();
        }	
        

        /// <summary>
        /// Finds all  Language data with language I D containing specified keyword
        /// </summary>
		/// <param name="languageID"> Language I D</param>
		/// <returns>List of  Language</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "language/find-by-language-i-d/{languageID}")]
        public Stream FindByLanguageID(string languageID)
        {
            IFindLanguageBusinessService businessService = (IFindLanguageBusinessService)BusinessFactory.Create(Keywords.FindLanguage);
            OperationResult result = businessService.FindByLanguageID(Convert.ToString(languageID));
            return result.ToJsonStream();
        }		
		

        /// <summary>
        /// Updates  Language's language I D which has specified idLanguage
        /// </summary>
		/// <param name="idLanguage">id Language</param>
		/// <param name="languageID">language I D</param>
		/// <returns>Result of the operation</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "language/update-language-i-d/{idLanguage}/{languageID}")]
        public Stream UpdateLanguageID(string idLanguage,string languageID)
        {
            IUpdateLanguageBusinessService businessService = (IUpdateLanguageBusinessService)BusinessFactory.Create(Keywords.UpdateLanguage);
            OperationResult result = businessService.UpdateLanguageID(Convert.ToInt16(idLanguage),Convert.ToString(languageID) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Delete all  Language data with language I D containing specified keyword
        /// </summary>
		/// <param name="languageID"> Language I D</param>
		/// <returns>List of  Language</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "language/delete-by-language-i-d/{languageID}")]
        public Stream DeleteByLanguageID(string languageID)
        {
            IDeleteLanguageBusinessService businessService = (IDeleteLanguageBusinessService)BusinessFactory.Create(Keywords.DeleteLanguage);
            OperationResult result = businessService.DeleteByLanguageID(Convert.ToString(languageID) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Finds all  Language data with language Name containing specified keyword
        /// </summary>
		/// <param name="languageName"> Language Name</param>
		/// <returns>List of  Language</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "language/find-by-language-name/{languageName}")]
        public Stream FindByLanguageName(string languageName)
        {
            IFindLanguageBusinessService businessService = (IFindLanguageBusinessService)BusinessFactory.Create(Keywords.FindLanguage);
            OperationResult result = businessService.FindByLanguageName(Convert.ToString(languageName));
            return result.ToJsonStream();
        }		
		

        /// <summary>
        /// Updates  Language's language Name which has specified idLanguage
        /// </summary>
		/// <param name="idLanguage">id Language</param>
		/// <param name="languageName">language Name</param>
		/// <returns>Result of the operation</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "language/update-language-name/{idLanguage}/{languageName}")]
        public Stream UpdateLanguageName(string idLanguage,string languageName)
        {
            IUpdateLanguageBusinessService businessService = (IUpdateLanguageBusinessService)BusinessFactory.Create(Keywords.UpdateLanguage);
            OperationResult result = businessService.UpdateLanguageName(Convert.ToInt16(idLanguage),Convert.ToString(languageName) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Delete all  Language data with language Name containing specified keyword
        /// </summary>
		/// <param name="languageName"> Language Name</param>
		/// <returns>List of  Language</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "language/delete-by-language-name/{languageName}")]
        public Stream DeleteByLanguageName(string languageName)
        {
            IDeleteLanguageBusinessService businessService = (IDeleteLanguageBusinessService)BusinessFactory.Create(Keywords.DeleteLanguage);
            OperationResult result = businessService.DeleteByLanguageName(Convert.ToString(languageName) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Finds all  Language data with language Desc containing specified keyword
        /// </summary>
		/// <param name="languageDesc"> Language Desc</param>
		/// <returns>List of  Language</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "language/find-by-language-desc/{languageDesc}")]
        public Stream FindByLanguageDesc(string languageDesc)
        {
            IFindLanguageBusinessService businessService = (IFindLanguageBusinessService)BusinessFactory.Create(Keywords.FindLanguage);
            OperationResult result = businessService.FindByLanguageDesc(Convert.ToString(languageDesc));
            return result.ToJsonStream();
        }		
		

        /// <summary>
        /// Updates  Language's language Desc which has specified idLanguage
        /// </summary>
		/// <param name="idLanguage">id Language</param>
		/// <param name="languageDesc">language Desc</param>
		/// <returns>Result of the operation</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "language/update-language-desc/{idLanguage}/{languageDesc}")]
        public Stream UpdateLanguageDesc(string idLanguage,string languageDesc)
        {
            IUpdateLanguageBusinessService businessService = (IUpdateLanguageBusinessService)BusinessFactory.Create(Keywords.UpdateLanguage);
            OperationResult result = businessService.UpdateLanguageDesc(Convert.ToInt16(idLanguage),Convert.ToString(languageDesc) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Delete all  Language data with language Desc containing specified keyword
        /// </summary>
		/// <param name="languageDesc"> Language Desc</param>
		/// <returns>List of  Language</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "language/delete-by-language-desc/{languageDesc}")]
        public Stream DeleteByLanguageDesc(string languageDesc)
        {
            IDeleteLanguageBusinessService businessService = (IDeleteLanguageBusinessService)BusinessFactory.Create(Keywords.DeleteLanguage);
            OperationResult result = businessService.DeleteByLanguageDesc(Convert.ToString(languageDesc) );
            return result.ToJsonStream();
        }	
		
 
	}
}