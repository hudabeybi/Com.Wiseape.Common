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
    /// Interface for LanguageKeyword Service
    /// </summary>
    [ServiceContract]
    public interface ILanguageKeywordService
    {
    
        /// <summary>
        /// Service to add LanguageKeyword data to data store.
        /// This is a POST request.
        /// </summary>
        /// <param name="LanguageKeywordForm">LanguageKeyword data from POST request</param>
        /// <return>JSON string representation of operation result</return>
        [OperationContract]
        Stream AddLanguageKeyword(LanguageKeyword languageKeywordForm);

        /// <summary>
        /// Service to update LanguageKeyword data to data store.
        /// This is a POST request.
        /// </summary>
        /// <param name="languageKeywordForm">LanguageKeyword data from POST request</param>
        /// <return>JSON string representation of operation result</return>
        [OperationContract]
        Stream UpdateLanguageKeyword(LanguageKeyword languageKeywordForm);

        /// <summary>
        /// Service to delete LanguageKeyword data from data store. 
        /// The data deleted is defined by idKeyword.
        /// This is a GET request.
        /// </summary>
        /// <param name="idKeyword">the key value of the data</param>
        /// <return>JSON string representation of operation result</return>  
        [OperationContract]
        Stream DeleteLanguageKeyword(string idKeyword);

        /// <summary>
        /// Service to get a LanguageKeyword data from data store. 
        /// The data retrieved is defined by idKeyword.
        /// This is a GET request.
        /// </summary>
        /// <param name="idKeyword">the key value of the data</param>
        /// <return>JSON string representation of operation result</return>    
        [OperationContract]
       	Stream GetLanguageKeyword(string idKeyword);

        /// <summary>
        /// Service to get all the LanguageKeyword data from data store. 
        /// The data items retrieved are those who contain the keyword given. 
        /// This is a GET request.
        /// </summary>
        /// <param name="keyword">the keyword to search</param>
        /// <param name="page">the page of the data navigation</param>
        /// <param name="max">the maximum amount of data to retrieve</param>
        /// <return>JSON string representation of operation result</return>    
		[OperationContract]
        Stream FindLanguageKeyword(string keyword, string page, string max);	
        

        /// <summary>
        /// Finds all  Language Keyword data with keyword containing specified keyword
        /// </summary>
		/// <param name="keyword"> Keyword</param>
		/// <returns>List of  Language Keyword</returns>
		[OperationContract]
		Stream FindByKeyword(string keyword);

        /// <summary>
        /// Updates  Language Keyword's keyword which has specified idKeyword
        /// </summary>
		/// <param name="idKeyword">id Keyword</param>
		/// <param name="keyword">keyword</param>
		/// <returns>List of  Language Keyword</returns>
		[OperationContract]
		Stream UpdateKeyword(string idKeyword,string keyword);

        /// <summary>
        /// Delete all  Language Keyword data with keyword containing specified keyword
        /// </summary>
		/// <param name="keyword"> Keyword</param>
		/// <returns>List of  Language Keyword</returns>
		[OperationContract]
		Stream DeleteByKeyword(string keyword);

        /// <summary>
        /// Finds all  Language Keyword data with keyword Text containing specified keyword
        /// </summary>
		/// <param name="keywordText"> Keyword Text</param>
		/// <returns>List of  Language Keyword</returns>
		[OperationContract]
		Stream FindByKeywordText(string keywordText);

        /// <summary>
        /// Updates  Language Keyword's keyword Text which has specified idKeyword
        /// </summary>
		/// <param name="idKeyword">id Keyword</param>
		/// <param name="keywordText">keyword Text</param>
		/// <returns>List of  Language Keyword</returns>
		[OperationContract]
		Stream UpdateKeywordText(string idKeyword,string keywordText);

        /// <summary>
        /// Delete all  Language Keyword data with keyword Text containing specified keyword
        /// </summary>
		/// <param name="keywordText"> Keyword Text</param>
		/// <returns>List of  Language Keyword</returns>
		[OperationContract]
		Stream DeleteByKeywordText(string keywordText);

        /// <summary>
        /// Finds all  Language Keyword data with language I D containing specified keyword
        /// </summary>
		/// <param name="languageID"> Language I D</param>
		/// <returns>List of  Language Keyword</returns>
		[OperationContract]
		Stream FindByLanguageID(string languageID);

        /// <summary>
        /// Updates  Language Keyword's language I D which has specified idKeyword
        /// </summary>
		/// <param name="idKeyword">id Keyword</param>
		/// <param name="languageID">language I D</param>
		/// <returns>List of  Language Keyword</returns>
		[OperationContract]
		Stream UpdateLanguageID(string idKeyword,string languageID);

        /// <summary>
        /// Delete all  Language Keyword data with language I D containing specified keyword
        /// </summary>
		/// <param name="languageID"> Language I D</param>
		/// <returns>List of  Language Keyword</returns>
		[OperationContract]
		Stream DeleteByLanguageID(string languageID);
    
    }
}