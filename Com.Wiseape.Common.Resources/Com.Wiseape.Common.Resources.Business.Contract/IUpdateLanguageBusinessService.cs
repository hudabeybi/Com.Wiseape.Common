using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Wiseape.Utility;
using Com.Wiseape.Common.Data.Model;


namespace Com.Wiseape.Common.Resources.Business.Contract
{
    public interface IUpdateLanguageBusinessService
    {

        /// <summary>
        /// Updates  Language's language I D which has specified idLanguage
        /// </summary>
		/// <param name="idLanguage">id Language</param>
		/// <param name="languageID">language I D</param>
		/// <returns>List of  Language</returns>
		OperationResult UpdateLanguageID(Int16 idLanguage, string languageID);

        /// <summary>
        /// Updates  Language's language Name which has specified idLanguage
        /// </summary>
		/// <param name="idLanguage">id Language</param>
		/// <param name="languageName">language Name</param>
		/// <returns>List of  Language</returns>
		OperationResult UpdateLanguageName(Int16 idLanguage, string languageName);

        /// <summary>
        /// Updates  Language's language Desc which has specified idLanguage
        /// </summary>
		/// <param name="idLanguage">id Language</param>
		/// <param name="languageDesc">language Desc</param>
		/// <returns>List of  Language</returns>
		OperationResult UpdateLanguageDesc(Int16 idLanguage, string languageDesc);

	}
}