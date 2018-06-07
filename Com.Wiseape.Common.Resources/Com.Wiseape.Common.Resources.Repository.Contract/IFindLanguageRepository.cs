using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Wiseape.Common.Data.Model;



namespace Com.Wiseape.Common.Resources.Repository.Contract
{
    public interface IFindLanguageRepository
    {

        /// <summary>
        /// Finds all  Language data with language I D containing specified keyword
        /// </summary>
		/// <param name="languageID"> Language I D</param>
		/// <returns>List of  Language</returns>
		List<Language> FindByLanguageID(string languageID);

        /// <summary>
        /// Finds all  Language data with language Name containing specified keyword
        /// </summary>
		/// <param name="languageName"> Language Name</param>
		/// <returns>List of  Language</returns>
		List<Language> FindByLanguageName(string languageName);

        /// <summary>
        /// Finds all  Language data with language Desc containing specified keyword
        /// </summary>
		/// <param name="languageDesc"> Language Desc</param>
		/// <returns>List of  Language</returns>
		List<Language> FindByLanguageDesc(string languageDesc);

    }
}

