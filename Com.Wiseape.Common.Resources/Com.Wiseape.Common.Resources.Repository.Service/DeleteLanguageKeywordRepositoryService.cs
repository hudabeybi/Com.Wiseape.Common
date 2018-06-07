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
    /// Repository for LanguageKeyword data.
    /// </summary>
    public class DeleteLanguageKeywordRepository : BaseRepository<LanguageKeyword>, IDeleteLanguageKeywordRepository
    {
        class Keywords
        {
            public static string DeleteLanguageKeyword = "Delete.Common.Resources.LanguageKeyword";
        }

        /// <summary>
        /// Constructor for DeleteLanguageKeywordRepository
        /// </summary>
        /// <param name="dataContextKey">Key for Datacontext to use</param>
        public DeleteLanguageKeywordRepository(string dataContextKey) : base(dataContextKey)
        {
        }
        
        
        public DeleteLanguageKeywordRepository()
        {
            this.DataContextKey = Keywords.DeleteLanguageKeyword;
        }

//------------------- Delete by keywords --------------------------------------------------------

        /// <summary>
        /// Delete all  Language Keyword data with keyword containing specified keyword
        /// </summary>
		/// <param name="keyword"> Keyword</param>
		/// <returns>List of  Language Keyword</returns>
        public void DeleteByKeyword(string keyword)
        {
            CommonDataContext dataContext = (CommonDataContext)this.DataContext;
            var list = from o in dataContext.LanguageKeywords
                       where
							o.Keyword.Contains(keyword) 						
						select o;
			dataContext.LanguageKeywords.RemoveRange(list);
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Delete all  Language Keyword data with keyword Text containing specified keyword
        /// </summary>
		/// <param name="keywordText"> Keyword Text</param>
		/// <returns>List of  Language Keyword</returns>
        public void DeleteByKeywordText(string keywordText)
        {
            CommonDataContext dataContext = (CommonDataContext)this.DataContext;
            var list = from o in dataContext.LanguageKeywords
                       where
							o.KeywordText.Contains(keywordText) 						
						select o;
			dataContext.LanguageKeywords.RemoveRange(list);
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Delete all  Language Keyword data with language I D containing specified keyword
        /// </summary>
		/// <param name="languageID"> Language I D</param>
		/// <returns>List of  Language Keyword</returns>
        public void DeleteByLanguageID(string languageID)
        {
            CommonDataContext dataContext = (CommonDataContext)this.DataContext;
            var list = from o in dataContext.LanguageKeywords
                       where
							o.LanguageID.Contains(languageID) 						
						select o;
			dataContext.LanguageKeywords.RemoveRange(list);
            dataContext.SaveChanges();
        }


//-----------------------  Delete by Foreign keys ---------------------------------------


    }
}
