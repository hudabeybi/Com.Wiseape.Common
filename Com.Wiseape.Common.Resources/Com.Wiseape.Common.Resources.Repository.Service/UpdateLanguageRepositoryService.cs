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
    /// Repository for UpdateLanguage data.
    /// </summary>
    public class UpdateLanguageRepository : BaseRepository<Language>, IUpdateLanguageRepository
    {
        class Keywords
        {
            public static string UpdateLanguage = "Update.Common.Resources.Language";
        }

        /// <summary>
        /// Constructor for LanguageRepository
        /// </summary>
        /// <param name="dataContextKey">Key for Datacontext to use</param>
        public UpdateLanguageRepository(string dataContextKey) : base(dataContextKey)
        {
        }
        
        
        public UpdateLanguageRepository()
        {
            this.DataContextKey = Keywords.UpdateLanguage;
        }


//-------------------------- Update columns by Primary key -----------------------------------------

        /// <summary>
        /// Updates  Language's id Language, language I D by idLanguage
        /// </summary>
		/// <param name="idLanguage">id Language</param>
		/// <param name="languageID">language I D</param>
		/// <returns>List of  Language</returns>
        public void UpdateLanguageID(Int16 idLanguage, string languageID)
        {
            CommonDataContext dataContext = (CommonDataContext)this.DataContext;
            var list = from o in dataContext.Languages
                       where
                       		o.IdLanguage == idLanguage
                       	select o;
           	list.ToList().ForEach(o => {
      			o.LanguageID = languageID;	
            });
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Updates  Language's id Language, language Name by idLanguage
        /// </summary>
		/// <param name="idLanguage">id Language</param>
		/// <param name="languageName">language Name</param>
		/// <returns>List of  Language</returns>
        public void UpdateLanguageName(Int16 idLanguage, string languageName)
        {
            CommonDataContext dataContext = (CommonDataContext)this.DataContext;
            var list = from o in dataContext.Languages
                       where
                       		o.IdLanguage == idLanguage
                       	select o;
           	list.ToList().ForEach(o => {
      			o.LanguageName = languageName;	
            });
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Updates  Language's id Language, language Desc by idLanguage
        /// </summary>
		/// <param name="idLanguage">id Language</param>
		/// <param name="languageDesc">language Desc</param>
		/// <returns>List of  Language</returns>
        public void UpdateLanguageDesc(Int16 idLanguage, string languageDesc)
        {
            CommonDataContext dataContext = (CommonDataContext)this.DataContext;
            var list = from o in dataContext.Languages
                       where
                       		o.IdLanguage == idLanguage
                       	select o;
           	list.ToList().ForEach(o => {
      			o.LanguageDesc = languageDesc;	
            });
            dataContext.SaveChanges();
        }


//-------------------------- Update foreign keys -----------------------------------------


    }
}
