using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Wiseape.Utility;
using Com.Wiseape.Common.Data.Model;


namespace Com.Wiseape.Common.Resources.Business.Contract
{
    public interface IDeleteLanguageBusinessService
    {

        /// <summary>
        /// Delete all  Language data with language I D containing specified keyword
        /// </summary>
		/// <param name="languageID"> Language I D</param>
		/// <returns>List of  Language</returns>
		OperationResult DeleteByLanguageID(string languageID);

        /// <summary>
        /// Delete all  Language data with language Name containing specified keyword
        /// </summary>
		/// <param name="languageName"> Language Name</param>
		/// <returns>List of  Language</returns>
		OperationResult DeleteByLanguageName(string languageName);

        /// <summary>
        /// Delete all  Language data with language Desc containing specified keyword
        /// </summary>
		/// <param name="languageDesc"> Language Desc</param>
		/// <returns>List of  Language</returns>
		OperationResult DeleteByLanguageDesc(string languageDesc);

	}
}