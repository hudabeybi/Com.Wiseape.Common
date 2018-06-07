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
    /// Interface for Language Service
    /// </summary>
    [ServiceContract]
    public interface ILanguageService
    {
    
        /// <summary>
        /// Service to add Language data to data store.
        /// This is a POST request.
        /// </summary>
        /// <param name="LanguageForm">Language data from POST request</param>
        /// <return>JSON string representation of operation result</return>
        [OperationContract]
        Stream AddLanguage(Language languageForm);

        /// <summary>
        /// Service to update Language data to data store.
        /// This is a POST request.
        /// </summary>
        /// <param name="languageForm">Language data from POST request</param>
        /// <return>JSON string representation of operation result</return>
        [OperationContract]
        Stream UpdateLanguage(Language languageForm);

        /// <summary>
        /// Service to delete Language data from data store. 
        /// The data deleted is defined by idLanguage.
        /// This is a GET request.
        /// </summary>
        /// <param name="idLanguage">the key value of the data</param>
        /// <return>JSON string representation of operation result</return>  
        [OperationContract]
        Stream DeleteLanguage(string idLanguage);

        /// <summary>
        /// Service to get a Language data from data store. 
        /// The data retrieved is defined by idLanguage.
        /// This is a GET request.
        /// </summary>
        /// <param name="idLanguage">the key value of the data</param>
        /// <return>JSON string representation of operation result</return>    
        [OperationContract]
       	Stream GetLanguage(string idLanguage);

        /// <summary>
        /// Service to get all the Language data from data store. 
        /// The data items retrieved are those who contain the keyword given. 
        /// This is a GET request.
        /// </summary>
        /// <param name="keyword">the keyword to search</param>
        /// <param name="page">the page of the data navigation</param>
        /// <param name="max">the maximum amount of data to retrieve</param>
        /// <return>JSON string representation of operation result</return>    
		[OperationContract]
        Stream FindLanguage(string keyword, string page, string max);	
        

        /// <summary>
        /// Finds all  Language data with language I D containing specified keyword
        /// </summary>
		/// <param name="languageID"> Language I D</param>
		/// <returns>List of  Language</returns>
		[OperationContract]
		Stream FindByLanguageID(string languageID);

        /// <summary>
        /// Updates  Language's language I D which has specified idLanguage
        /// </summary>
		/// <param name="idLanguage">id Language</param>
		/// <param name="languageID">language I D</param>
		/// <returns>List of  Language</returns>
		[OperationContract]
		Stream UpdateLanguageID(string idLanguage,string languageID);

        /// <summary>
        /// Delete all  Language data with language I D containing specified keyword
        /// </summary>
		/// <param name="languageID"> Language I D</param>
		/// <returns>List of  Language</returns>
		[OperationContract]
		Stream DeleteByLanguageID(string languageID);

        /// <summary>
        /// Finds all  Language data with language Name containing specified keyword
        /// </summary>
		/// <param name="languageName"> Language Name</param>
		/// <returns>List of  Language</returns>
		[OperationContract]
		Stream FindByLanguageName(string languageName);

        /// <summary>
        /// Updates  Language's language Name which has specified idLanguage
        /// </summary>
		/// <param name="idLanguage">id Language</param>
		/// <param name="languageName">language Name</param>
		/// <returns>List of  Language</returns>
		[OperationContract]
		Stream UpdateLanguageName(string idLanguage,string languageName);

        /// <summary>
        /// Delete all  Language data with language Name containing specified keyword
        /// </summary>
		/// <param name="languageName"> Language Name</param>
		/// <returns>List of  Language</returns>
		[OperationContract]
		Stream DeleteByLanguageName(string languageName);

        /// <summary>
        /// Finds all  Language data with language Desc containing specified keyword
        /// </summary>
		/// <param name="languageDesc"> Language Desc</param>
		/// <returns>List of  Language</returns>
		[OperationContract]
		Stream FindByLanguageDesc(string languageDesc);

        /// <summary>
        /// Updates  Language's language Desc which has specified idLanguage
        /// </summary>
		/// <param name="idLanguage">id Language</param>
		/// <param name="languageDesc">language Desc</param>
		/// <returns>List of  Language</returns>
		[OperationContract]
		Stream UpdateLanguageDesc(string idLanguage,string languageDesc);

        /// <summary>
        /// Delete all  Language data with language Desc containing specified keyword
        /// </summary>
		/// <param name="languageDesc"> Language Desc</param>
		/// <returns>List of  Language</returns>
		[OperationContract]
		Stream DeleteByLanguageDesc(string languageDesc);
    
    }
}