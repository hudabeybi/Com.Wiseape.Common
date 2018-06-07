using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Wiseape.Common.Data.Model;



namespace Com.Wiseape.Common.Resources.Repository.Contract
{
    public interface IUpdateGenderRepository
    {

	    /// <summary>
	    /// Updates  Gender's id Gender, gender Name by idGender
	    /// </summary>
		/// <param name="idGender">id Gender</param>
		/// <param name="genderName">gender Name</param>
		/// <returns>List of  Gender</returns>
		void UpdateGenderName(Int16 idGender, string genderName);
	
	    /// <summary>
	    /// Updates  Gender's id Gender, gender Icon by idGender
	    /// </summary>
		/// <param name="idGender">id Gender</param>
		/// <param name="genderIcon">gender Icon</param>
		/// <returns>List of  Gender</returns>
		void UpdateGenderIcon(Int16 idGender, string genderIcon);
	
	    /// <summary>
	    /// Updates  Gender's id Gender, language I D by idGender
	    /// </summary>
		/// <param name="idGender">id Gender</param>
		/// <param name="languageID">language I D</param>
		/// <returns>List of  Gender</returns>
		void UpdateLanguageID(Int16 idGender, string languageID);
	
    }
}

