using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Wiseape.Framework;
using Com.Wiseape.Utility;
using Com.Wiseape.Factory;
using Com.Wiseape.Common.Data.Model;
using Com.Wiseape.Common.Resources.Repository.Contract;
using Com.Wiseape.Common.Resources.Business.Contract;

namespace Com.Wiseape.Common.Resources.Business.Service
{
    /// <summary>
    /// Business Service for Language module.
    /// </summary>
    public class FindLanguageBusinessService : BaseBusinessService<Language>, IFindLanguageBusinessService
    {
        class Keywords
        {
            public static string FindLanguage = "Find.Common.Resources.Language";
        }
        
        public FindLanguageBusinessService(string repoKey) : base(repoKey)
        {
        }
        
        public FindLanguageBusinessService()
        {
            this.RepoKey = Keywords.FindLanguage;
        }


        /// <summary>
        /// Finds all  Language data with language I D containing specified keyword
        /// </summary>
		/// <param name="languageID"> Language I D</param>
		/// <returns>The result of the operation</returns>
		public OperationResult FindByLanguageID(string languageID)
		{
            IFindLanguageRepository repository = (IFindLanguageRepository)RepositoryFactory.Create(Keywords.FindLanguage);
            try
            {
                List<Language> res = repository.FindByLanguageID(languageID);
                return new OperationResult(true, res);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Finds all  Language data with language Name containing specified keyword
        /// </summary>
		/// <param name="languageName"> Language Name</param>
		/// <returns>The result of the operation</returns>
		public OperationResult FindByLanguageName(string languageName)
		{
            IFindLanguageRepository repository = (IFindLanguageRepository)RepositoryFactory.Create(Keywords.FindLanguage);
            try
            {
                List<Language> res = repository.FindByLanguageName(languageName);
                return new OperationResult(true, res);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Finds all  Language data with language Desc containing specified keyword
        /// </summary>
		/// <param name="languageDesc"> Language Desc</param>
		/// <returns>The result of the operation</returns>
		public OperationResult FindByLanguageDesc(string languageDesc)
		{
            IFindLanguageRepository repository = (IFindLanguageRepository)RepositoryFactory.Create(Keywords.FindLanguage);
            try
            {
                List<Language> res = repository.FindByLanguageDesc(languageDesc);
                return new OperationResult(true, res);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}



    }
 }