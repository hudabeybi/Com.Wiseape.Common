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
    public class LanguageKeywordService : ILanguageKeywordService
    {

        class Keywords
        {
            public static string LanguageKeyword = "Common.Resources.LanguageKeyword";
            public static string FindLanguageKeyword = "Find.Common.Resources.LanguageKeyword";
            public static string AddLanguageKeyword = "Add.Common.Resources.LanguageKeyword";
            public static string UpdateLanguageKeyword = "Update.Common.Resources.LanguageKeyword";
            public static string DeleteLanguageKeyword = "Delete.Common.Resources.LanguageKeyword";
        }

        /// <summary>
        /// Service to add LanguageKeyword data to data store.
        /// This is a POST request.
        /// </summary>
        /// <param name="LanguageKeywordForm">LanguageKeyword data from POST request</param>
        /// <return>JSON string representation of operation result</return>
        [WebInvoke(Method = "POST",
                    ResponseFormat = WebMessageFormat.Json,
                    RequestFormat = WebMessageFormat.Json,
                    UriTemplate = "languagekeyword/add")]
        public Stream AddLanguageKeyword(LanguageKeyword languageKeywordForm)
        {
            BaseBusinessService<LanguageKeyword> businessService = (BaseBusinessService<LanguageKeyword>)BusinessFactory.Create(Keywords.AddLanguageKeyword);
            OperationResult result = businessService.Add(languageKeywordForm);
            return result.ToJsonStream();
        }

        /// <summary>
        /// Service to update LanguageKeyword data to data store.
        /// This is a POST request.
        /// </summary>
        /// <param name="languageKeywordForm">LanguageKeyword data from POST request</param>
        /// <return>JSON string representation of operation result</return>
        [WebInvoke(Method = "POST",
                    ResponseFormat = WebMessageFormat.Json,
                    RequestFormat = WebMessageFormat.Json,
                    UriTemplate = "languagekeyword/update")]
        public Stream UpdateLanguageKeyword(LanguageKeyword languageKeywordForm)
        {
            BaseBusinessService<LanguageKeyword> businessService = (BaseBusinessService<LanguageKeyword>)BusinessFactory.Create(Keywords.UpdateLanguageKeyword);
            OperationResult result = businessService.Update(languageKeywordForm);
            return result.ToJsonStream();
        }

        /// <summary>
        /// Service to delete LanguageKeyword data from data store. 
        /// The data deleted is defined by idKeyword.
        /// This is a GET request.
        /// </summary>
        /// <param name="idKeyword">the key value of the data</param>
        /// <return>JSON string representation of operation result</return>  
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "languagekeyword/delete/{idKeyword}")]
        public Stream DeleteLanguageKeyword(string idKeyword)
        {
            BaseBusinessService<LanguageKeyword> businessService = (BaseBusinessService<LanguageKeyword>)BusinessFactory.Create(Keywords.DeleteLanguageKeyword);
            OperationResult result = businessService.Delete(idKeyword);
            return result.ToJsonStream();
        }

        /// <summary>
        /// Service to get a LanguageKeyword data from data store. 
        /// The data retrieved is defined by idKeyword.
        /// This is a GET request.
        /// </summary>
        /// <param name="idKeyword">the key value of the data</param>
        /// <return>JSON string representation of operation result</return>    
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "languagekeyword/get/{idKeyword}")]
        public Stream GetLanguageKeyword(string idKeyword)
        {
            BaseBusinessService<LanguageKeyword> businessService = (BaseBusinessService<LanguageKeyword>)BusinessFactory.Create(Keywords.FindLanguageKeyword);
            OperationResult result = businessService.Get(idKeyword);
            return result.ToJsonStream();
        }

        /// <summary>
        /// Service to get all the LanguageKeyword data from data store. 
        /// The data items retrieved are those who contain the keyword given. 
        /// This is a GET request.
        /// </summary>
        /// <param name="keyword">the keyword to search</param>
        /// <param name="page">the page of the data navigation</param>
        /// <param name="max">the maximum amount of data to retrieve</param>
        /// <return>JSON string representation of operation result</return>    
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "languagekeyword/find/{keyword}/{page}/{max}")]
        public Stream FindLanguageKeyword(string keyword, string page, string max)
        {
            BaseBusinessService<LanguageKeyword> businessService = (BaseBusinessService<LanguageKeyword>)BusinessFactory.Create(Keywords.FindLanguageKeyword);

            SelectParam selectParam = new SelectParam();
            selectParam.Keyword = keyword;
            if (keyword.ToLower() == "all")
                selectParam.Keyword = "";
            OperationResult result = businessService.FindAll(selectParam, Convert.ToInt16(page), Convert.ToInt16(max) );

            return result.ToJsonStream();
        }	
        

        /// <summary>
        /// Finds all  Language Keyword data with keyword containing specified keyword
        /// </summary>
		/// <param name="keyword"> Keyword</param>
		/// <returns>List of  Language Keyword</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "languagekeyword/find-by-keyword/{keyword}")]
        public Stream FindByKeyword(string keyword)
        {
            IFindLanguageKeywordBusinessService businessService = (IFindLanguageKeywordBusinessService)BusinessFactory.Create(Keywords.FindLanguageKeyword);
            OperationResult result = businessService.FindByKeyword(Convert.ToString(keyword));
            return result.ToJsonStream();
        }		
		

        /// <summary>
        /// Updates  Language Keyword's keyword which has specified idKeyword
        /// </summary>
		/// <param name="idKeyword">id Keyword</param>
		/// <param name="keyword">keyword</param>
		/// <returns>Result of the operation</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "languagekeyword/update-keyword/{idKeyword}/{keyword}")]
        public Stream UpdateKeyword(string idKeyword,string keyword)
        {
            IUpdateLanguageKeywordBusinessService businessService = (IUpdateLanguageKeywordBusinessService)BusinessFactory.Create(Keywords.UpdateLanguageKeyword);
            OperationResult result = businessService.UpdateKeyword(Convert.ToInt64(idKeyword),Convert.ToString(keyword) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Delete all  Language Keyword data with keyword containing specified keyword
        /// </summary>
		/// <param name="keyword"> Keyword</param>
		/// <returns>List of  Language Keyword</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "languagekeyword/delete-by-keyword/{keyword}")]
        public Stream DeleteByKeyword(string keyword)
        {
            IDeleteLanguageKeywordBusinessService businessService = (IDeleteLanguageKeywordBusinessService)BusinessFactory.Create(Keywords.DeleteLanguageKeyword);
            OperationResult result = businessService.DeleteByKeyword(Convert.ToString(keyword) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Finds all  Language Keyword data with keyword Text containing specified keyword
        /// </summary>
		/// <param name="keywordText"> Keyword Text</param>
		/// <returns>List of  Language Keyword</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "languagekeyword/find-by-keyword-text/{keywordText}")]
        public Stream FindByKeywordText(string keywordText)
        {
            IFindLanguageKeywordBusinessService businessService = (IFindLanguageKeywordBusinessService)BusinessFactory.Create(Keywords.FindLanguageKeyword);
            OperationResult result = businessService.FindByKeywordText(Convert.ToString(keywordText));
            return result.ToJsonStream();
        }		
		

        /// <summary>
        /// Updates  Language Keyword's keyword Text which has specified idKeyword
        /// </summary>
		/// <param name="idKeyword">id Keyword</param>
		/// <param name="keywordText">keyword Text</param>
		/// <returns>Result of the operation</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "languagekeyword/update-keyword-text/{idKeyword}/{keywordText}")]
        public Stream UpdateKeywordText(string idKeyword,string keywordText)
        {
            IUpdateLanguageKeywordBusinessService businessService = (IUpdateLanguageKeywordBusinessService)BusinessFactory.Create(Keywords.UpdateLanguageKeyword);
            OperationResult result = businessService.UpdateKeywordText(Convert.ToInt64(idKeyword),Convert.ToString(keywordText) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Delete all  Language Keyword data with keyword Text containing specified keyword
        /// </summary>
		/// <param name="keywordText"> Keyword Text</param>
		/// <returns>List of  Language Keyword</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "languagekeyword/delete-by-keyword-text/{keywordText}")]
        public Stream DeleteByKeywordText(string keywordText)
        {
            IDeleteLanguageKeywordBusinessService businessService = (IDeleteLanguageKeywordBusinessService)BusinessFactory.Create(Keywords.DeleteLanguageKeyword);
            OperationResult result = businessService.DeleteByKeywordText(Convert.ToString(keywordText) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Finds all  Language Keyword data with language I D containing specified keyword
        /// </summary>
		/// <param name="languageID"> Language I D</param>
		/// <returns>List of  Language Keyword</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "languagekeyword/find-by-language-i-d/{languageID}")]
        public Stream FindByLanguageID(string languageID)
        {
            IFindLanguageKeywordBusinessService businessService = (IFindLanguageKeywordBusinessService)BusinessFactory.Create(Keywords.FindLanguageKeyword);
            OperationResult result = businessService.FindByLanguageID(Convert.ToString(languageID));
            return result.ToJsonStream();
        }		
		

        /// <summary>
        /// Updates  Language Keyword's language I D which has specified idKeyword
        /// </summary>
		/// <param name="idKeyword">id Keyword</param>
		/// <param name="languageID">language I D</param>
		/// <returns>Result of the operation</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "languagekeyword/update-language-i-d/{idKeyword}/{languageID}")]
        public Stream UpdateLanguageID(string idKeyword,string languageID)
        {
            IUpdateLanguageKeywordBusinessService businessService = (IUpdateLanguageKeywordBusinessService)BusinessFactory.Create(Keywords.UpdateLanguageKeyword);
            OperationResult result = businessService.UpdateLanguageID(Convert.ToInt64(idKeyword),Convert.ToString(languageID) );
            return result.ToJsonStream();
        }	
		

        /// <summary>
        /// Delete all  Language Keyword data with language I D containing specified keyword
        /// </summary>
		/// <param name="languageID"> Language I D</param>
		/// <returns>List of  Language Keyword</returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "languagekeyword/delete-by-language-i-d/{languageID}")]
        public Stream DeleteByLanguageID(string languageID)
        {
            IDeleteLanguageKeywordBusinessService businessService = (IDeleteLanguageKeywordBusinessService)BusinessFactory.Create(Keywords.DeleteLanguageKeyword);
            OperationResult result = businessService.DeleteByLanguageID(Convert.ToString(languageID) );
            return result.ToJsonStream();
        }	
		
 
	}
}