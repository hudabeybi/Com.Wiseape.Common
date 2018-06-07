using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Wiseape.Utility;
using Com.Wiseape.Common.Data.Model;


namespace Com.Wiseape.Common.Resources.Business.Contract
{
    public interface IUpdateLanguageKeywordBusinessService
    {

        /// <summary>
        /// Updates  Language Keyword's keyword which has specified idKeyword
        /// </summary>
		/// <param name="idKeyword">id Keyword</param>
		/// <param name="keyword">keyword</param>
		/// <returns>List of  Language Keyword</returns>
		OperationResult UpdateKeyword(Int64 idKeyword, string keyword);

        /// <summary>
        /// Updates  Language Keyword's keyword Text which has specified idKeyword
        /// </summary>
		/// <param name="idKeyword">id Keyword</param>
		/// <param name="keywordText">keyword Text</param>
		/// <returns>List of  Language Keyword</returns>
		OperationResult UpdateKeywordText(Int64 idKeyword, string keywordText);

        /// <summary>
        /// Updates  Language Keyword's language I D which has specified idKeyword
        /// </summary>
		/// <param name="idKeyword">id Keyword</param>
		/// <param name="languageID">language I D</param>
		/// <returns>List of  Language Keyword</returns>
		OperationResult UpdateLanguageID(Int64 idKeyword, string languageID);

	}
}