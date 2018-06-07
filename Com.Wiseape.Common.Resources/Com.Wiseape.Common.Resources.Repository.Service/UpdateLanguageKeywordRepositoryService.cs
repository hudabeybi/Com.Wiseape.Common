using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Wiseape.Framework;
using Com.Wiseape.Common.Data.Model;
using Com.Wiseape.Common.Data.Context;
using Com.Wiseape.Common.Resources.Repository.Contract;

namespace Com.Wiseape.Common.Resources.Repository.Service
{
    /// <summary>
    /// Repository for UpdateLanguageKeyword data.
    /// </summary>
    public class UpdateLanguageKeywordRepository : BaseRepository<LanguageKeyword>, IUpdateLanguageKeywordRepository
    {
        class Keywords
        {
            public static string UpdateLanguageKeyword = "Update.Common.Resources.LanguageKeyword";
        }

        /// <summary>
        /// Constructor for LanguageKeywordRepository
        /// </summary>
        /// <param name="dataContextKey">Key for Datacontext to use</param>
        public UpdateLanguageKeywordRepository(string dataContextKey) : base(dataContextKey)
        {
        }
        
        
        public UpdateLanguageKeywordRepository()
        {
            this.DataContextKey = Keywords.UpdateLanguageKeyword;
        }


//-------------------------- Update columns by Primary key -----------------------------------------

        /// <summary>
        /// Updates  Language Keyword's id Keyword, keyword by idKeyword
        /// </summary>
		/// <param name="idKeyword">id Keyword</param>
		/// <param name="keyword">keyword</param>
		/// <returns>List of  Language Keyword</returns>
        public void UpdateKeyword(Int64 idKeyword, string keyword)
        {
            CommonDataContext dataContext = (CommonDataContext)this.DataContext;
            var list = from o in dataContext.LanguageKeywords
                       where
                       		o.IdKeyword == idKeyword
                       	select o;
           	list.ToList().ForEach(o => {
      			o.Keyword = keyword;	
            });
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Updates  Language Keyword's id Keyword, keyword Text by idKeyword
        /// </summary>
		/// <param name="idKeyword">id Keyword</param>
		/// <param name="keywordText">keyword Text</param>
		/// <returns>List of  Language Keyword</returns>
        public void UpdateKeywordText(Int64 idKeyword, string keywordText)
        {
            CommonDataContext dataContext = (CommonDataContext)this.DataContext;
            var list = from o in dataContext.LanguageKeywords
                       where
                       		o.IdKeyword == idKeyword
                       	select o;
           	list.ToList().ForEach(o => {
      			o.KeywordText = keywordText;	
            });
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Updates  Language Keyword's id Keyword, language I D by idKeyword
        /// </summary>
		/// <param name="idKeyword">id Keyword</param>
		/// <param name="languageID">language I D</param>
		/// <returns>List of  Language Keyword</returns>
        public void UpdateLanguageID(Int64 idKeyword, string languageID)
        {
            CommonDataContext dataContext = (CommonDataContext)this.DataContext;
            var list = from o in dataContext.LanguageKeywords
                       where
                       		o.IdKeyword == idKeyword
                       	select o;
           	list.ToList().ForEach(o => {
      			o.LanguageID = languageID;	
            });
            dataContext.SaveChanges();
        }


//-------------------------- Update foreign keys -----------------------------------------


    }
}
