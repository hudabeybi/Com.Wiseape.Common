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
    public class FindLanguageRepository : BaseRepository<Language>, IFindLanguageRepository
    {
        class Keywords
        {
            public static string FindLanguage = "Find.Common.Resources.Language";
        }

        /// <summary>
        /// Constructor for LanguageRepository
        /// </summary>
        /// <param name="dataContextKey">Key for Datacontext to use</param>
        public FindLanguageRepository(string dataContextKey) : base(dataContextKey)
        {
        }
        
        
        public FindLanguageRepository()
        {
            this.DataContextKey = Keywords.FindLanguage;
        }

//------------------- Find by keywords --------------------------------------------------------

        /// <summary>
        /// Finds all  Language data with language I D containing specified keyword
        /// </summary>
		/// <param name="languageID"> Language I D</param>
		/// <returns>List of  Language</returns>
        public List<Language> FindByLanguageID(string languageID)
        {
            CommonDataContext dataContext = (CommonDataContext)this.DataContext;
            var list = from o in dataContext.Languages
                       where
							o.LanguageID.Contains(languageID) 						
						select o;
            return list.ToList();
        }

        /// <summary>
        /// Finds all  Language data with language Name containing specified keyword
        /// </summary>
		/// <param name="languageName"> Language Name</param>
		/// <returns>List of  Language</returns>
        public List<Language> FindByLanguageName(string languageName)
        {
            CommonDataContext dataContext = (CommonDataContext)this.DataContext;
            var list = from o in dataContext.Languages
                       where
							o.LanguageName.Contains(languageName) 						
						select o;
            return list.ToList();
        }

        /// <summary>
        /// Finds all  Language data with language Desc containing specified keyword
        /// </summary>
		/// <param name="languageDesc"> Language Desc</param>
		/// <returns>List of  Language</returns>
        public List<Language> FindByLanguageDesc(string languageDesc)
        {
            CommonDataContext dataContext = (CommonDataContext)this.DataContext;
            var list = from o in dataContext.Languages
                       where
							o.LanguageDesc.Contains(languageDesc) 						
						select o;
            return list.ToList();
        }


//----------------------  find by dates -----------------------------------------------


//-----------------------  Find by Foreign keys ---------------------------------------




    }
}
