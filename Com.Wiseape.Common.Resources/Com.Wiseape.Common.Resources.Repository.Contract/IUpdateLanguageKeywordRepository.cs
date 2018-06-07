using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Wiseape.Common.Data.Model;



namespace Com.Wiseape.Common.Resources.Repository.Contract
{
    public interface IUpdateLanguageKeywordRepository
    {

	    /// <summary>
	    /// Updates  Language Keyword's id Keyword, keyword by idKeyword
	    /// </summary>
		/// <param name="idKeyword">id Keyword</param>
		/// <param name="keyword">keyword</param>
		/// <returns>List of  Language Keyword</returns>
		void UpdateKeyword(Int64 idKeyword, string keyword);
	
	    /// <summary>
	    /// Updates  Language Keyword's id Keyword, keyword Text by idKeyword
	    /// </summary>
		/// <param name="idKeyword">id Keyword</param>
		/// <param name="keywordText">keyword Text</param>
		/// <returns>List of  Language Keyword</returns>
		void UpdateKeywordText(Int64 idKeyword, string keywordText);
	
	    /// <summary>
	    /// Updates  Language Keyword's id Keyword, language I D by idKeyword
	    /// </summary>
		/// <param name="idKeyword">id Keyword</param>
		/// <param name="languageID">language I D</param>
		/// <returns>List of  Language Keyword</returns>
		void UpdateLanguageID(Int64 idKeyword, string languageID);
	
    }
}

