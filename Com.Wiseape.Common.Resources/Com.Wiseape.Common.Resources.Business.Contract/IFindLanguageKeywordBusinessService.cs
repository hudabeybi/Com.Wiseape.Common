using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Wiseape.Utility;
using Com.Wiseape.Common.Data.Model;


namespace Com.Wiseape.Common.Resources.Business.Contract
{
    public interface IFindLanguageKeywordBusinessService
    {

        /// <summary>
        /// Finds all  Language Keyword data with keyword containing specified keyword
        /// </summary>
		/// <param name="keyword"> Keyword</param>
		/// <returns>List of  Language Keyword</returns>
		OperationResult FindByKeyword(string keyword);

        /// <summary>
        /// Finds all  Language Keyword data with keyword Text containing specified keyword
        /// </summary>
		/// <param name="keywordText"> Keyword Text</param>
		/// <returns>List of  Language Keyword</returns>
		OperationResult FindByKeywordText(string keywordText);

        /// <summary>
        /// Finds all  Language Keyword data with language I D containing specified keyword
        /// </summary>
		/// <param name="languageID"> Language I D</param>
		/// <returns>List of  Language Keyword</returns>
		OperationResult FindByLanguageID(string languageID);

	}
}