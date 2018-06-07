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
    /// Interface for Gender Service
    /// </summary>
    [ServiceContract]
    public interface IGenderService
    {
    
        /// <summary>
        /// Service to add Gender data to data store.
        /// This is a POST request.
        /// </summary>
        /// <param name="GenderForm">Gender data from POST request</param>
        /// <return>JSON string representation of operation result</return>
        [OperationContract]
        Stream AddGender(Gender genderForm);

        /// <summary>
        /// Service to update Gender data to data store.
        /// This is a POST request.
        /// </summary>
        /// <param name="genderForm">Gender data from POST request</param>
        /// <return>JSON string representation of operation result</return>
        [OperationContract]
        Stream UpdateGender(Gender genderForm);

        /// <summary>
        /// Service to delete Gender data from data store. 
        /// The data deleted is defined by idGender.
        /// This is a GET request.
        /// </summary>
        /// <param name="idGender">the key value of the data</param>
        /// <return>JSON string representation of operation result</return>  
        [OperationContract]
        Stream DeleteGender(string idGender);

        /// <summary>
        /// Service to get a Gender data from data store. 
        /// The data retrieved is defined by idGender.
        /// This is a GET request.
        /// </summary>
        /// <param name="idGender">the key value of the data</param>
        /// <return>JSON string representation of operation result</return>    
        [OperationContract]
       	Stream GetGender(string idGender);

        /// <summary>
        /// Service to get all the Gender data from data store. 
        /// The data items retrieved are those who contain the keyword given. 
        /// This is a GET request.
        /// </summary>
        /// <param name="keyword">the keyword to search</param>
        /// <param name="page">the page of the data navigation</param>
        /// <param name="max">the maximum amount of data to retrieve</param>
        /// <return>JSON string representation of operation result</return>    
		[OperationContract]
        Stream FindGender(string keyword, string page, string max);	
        

        /// <summary>
        /// Finds all  Gender data with gender Name containing specified keyword
        /// </summary>
		/// <param name="genderName"> Gender Name</param>
		/// <returns>List of  Gender</returns>
		[OperationContract]
		Stream FindByGenderName(string genderName);

        /// <summary>
        /// Updates  Gender's gender Name which has specified idGender
        /// </summary>
		/// <param name="idGender">id Gender</param>
		/// <param name="genderName">gender Name</param>
		/// <returns>List of  Gender</returns>
		[OperationContract]
		Stream UpdateGenderName(string idGender,string genderName);

        /// <summary>
        /// Delete all  Gender data with gender Name containing specified keyword
        /// </summary>
		/// <param name="genderName"> Gender Name</param>
		/// <returns>List of  Gender</returns>
		[OperationContract]
		Stream DeleteByGenderName(string genderName);

        /// <summary>
        /// Finds all  Gender data with gender Icon containing specified keyword
        /// </summary>
		/// <param name="genderIcon"> Gender Icon</param>
		/// <returns>List of  Gender</returns>
		[OperationContract]
		Stream FindByGenderIcon(string genderIcon);

        /// <summary>
        /// Updates  Gender's gender Icon which has specified idGender
        /// </summary>
		/// <param name="idGender">id Gender</param>
		/// <param name="genderIcon">gender Icon</param>
		/// <returns>List of  Gender</returns>
		[OperationContract]
		Stream UpdateGenderIcon(string idGender,string genderIcon);

        /// <summary>
        /// Delete all  Gender data with gender Icon containing specified keyword
        /// </summary>
		/// <param name="genderIcon"> Gender Icon</param>
		/// <returns>List of  Gender</returns>
		[OperationContract]
		Stream DeleteByGenderIcon(string genderIcon);

        /// <summary>
        /// Finds all  Gender data with language I D containing specified keyword
        /// </summary>
		/// <param name="languageID"> Language I D</param>
		/// <returns>List of  Gender</returns>
		[OperationContract]
		Stream FindByLanguageID(string languageID);

        /// <summary>
        /// Updates  Gender's language I D which has specified idGender
        /// </summary>
		/// <param name="idGender">id Gender</param>
		/// <param name="languageID">language I D</param>
		/// <returns>List of  Gender</returns>
		[OperationContract]
		Stream UpdateLanguageID(string idGender,string languageID);

        /// <summary>
        /// Delete all  Gender data with language I D containing specified keyword
        /// </summary>
		/// <param name="languageID"> Language I D</param>
		/// <returns>List of  Gender</returns>
		[OperationContract]
		Stream DeleteByLanguageID(string languageID);
    
    }
}