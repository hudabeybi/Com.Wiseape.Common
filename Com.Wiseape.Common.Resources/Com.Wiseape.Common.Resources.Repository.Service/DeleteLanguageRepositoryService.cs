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
    /// Repository for Language data.
    /// </summary>
    public class DeleteLanguageRepository : BaseRepository<Language>, IDeleteLanguageRepository
    {
        class Keywords
        {
            public static string DeleteLanguage = "Delete.Common.Resources.Language";
        }

        /// <summary>
        /// Constructor for DeleteLanguageRepository
        /// </summary>
        /// <param name="dataContextKey">Key for Datacontext to use</param>
        public DeleteLanguageRepository(string dataContextKey) : base(dataContextKey)
        {
        }
        
        
        public DeleteLanguageRepository()
        {
            this.DataContextKey = Keywords.DeleteLanguage;
        }

//------------------- Delete by keywords --------------------------------------------------------

        /// <summary>
        /// Delete all  Language data with language I D containing specified keyword
        /// </summary>
		/// <param name="languageID"> Language I D</param>
		/// <returns>List of  Language</returns>
        public void DeleteByLanguageID(string languageID)
        {
            CommonDataContext dataContext = (CommonDataContext)this.DataContext;
            var list = from o in dataContext.Languages
                       where
							o.LanguageID.Contains(languageID) 						
						select o;
			dataContext.Languages.RemoveRange(list);
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Delete all  Language data with language Name containing specified keyword
        /// </summary>
		/// <param name="languageName"> Language Name</param>
		/// <returns>List of  Language</returns>
        public void DeleteByLanguageName(string languageName)
        {
            CommonDataContext dataContext = (CommonDataContext)this.DataContext;
            var list = from o in dataContext.Languages
                       where
							o.LanguageName.Contains(languageName) 						
						select o;
			dataContext.Languages.RemoveRange(list);
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Delete all  Language data with language Desc containing specified keyword
        /// </summary>
		/// <param name="languageDesc"> Language Desc</param>
		/// <returns>List of  Language</returns>
        public void DeleteByLanguageDesc(string languageDesc)
        {
            CommonDataContext dataContext = (CommonDataContext)this.DataContext;
            var list = from o in dataContext.Languages
                       where
							o.LanguageDesc.Contains(languageDesc) 						
						select o;
			dataContext.Languages.RemoveRange(list);
            dataContext.SaveChanges();
        }


//-----------------------  Delete by Foreign keys ---------------------------------------


    }
}
