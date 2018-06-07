using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Wiseape.Common.Data.Model;



namespace Com.Wiseape.Common.Resources.Repository.Contract
{
    public interface IUpdateLanguageRepository
    {

	    /// <summary>
	    /// Updates  Language's id Language, language I D by idLanguage
	    /// </summary>
		/// <param name="idLanguage">id Language</param>
		/// <param name="languageID">language I D</param>
		/// <returns>List of  Language</returns>
		void UpdateLanguageID(Int16 idLanguage, string languageID);
	
	    /// <summary>
	    /// Updates  Language's id Language, language Name by idLanguage
	    /// </summary>
		/// <param name="idLanguage">id Language</param>
		/// <param name="languageName">language Name</param>
		/// <returns>List of  Language</returns>
		void UpdateLanguageName(Int16 idLanguage, string languageName);
	
	    /// <summary>
	    /// Updates  Language's id Language, language Desc by idLanguage
	    /// </summary>
		/// <param name="idLanguage">id Language</param>
		/// <param name="languageDesc">language Desc</param>
		/// <returns>List of  Language</returns>
		void UpdateLanguageDesc(Int16 idLanguage, string languageDesc);
	
    }
}

