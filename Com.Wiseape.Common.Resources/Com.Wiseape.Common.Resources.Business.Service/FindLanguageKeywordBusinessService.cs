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
    /// Business Service for LanguageKeyword module.
    /// </summary>
    public class FindLanguageKeywordBusinessService : BaseBusinessService<LanguageKeyword>, IFindLanguageKeywordBusinessService
    {
        class Keywords
        {
            public static string FindLanguageKeyword = "Find.Common.Resources.LanguageKeyword";
        }
        
        public FindLanguageKeywordBusinessService(string repoKey) : base(repoKey)
        {
        }
        
        public FindLanguageKeywordBusinessService()
        {
            this.RepoKey = Keywords.FindLanguageKeyword;
        }


        /// <summary>
        /// Finds all  Language Keyword data with keyword containing specified keyword
        /// </summary>
		/// <param name="keyword"> Keyword</param>
		/// <returns>The result of the operation</returns>
		public OperationResult FindByKeyword(string keyword)
		{
            IFindLanguageKeywordRepository repository = (IFindLanguageKeywordRepository)RepositoryFactory.Create(Keywords.FindLanguageKeyword);
            try
            {
                List<LanguageKeyword> res = repository.FindByKeyword(keyword);
                return new OperationResult(true, res);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Finds all  Language Keyword data with keyword Text containing specified keyword
        /// </summary>
		/// <param name="keywordText"> Keyword Text</param>
		/// <returns>The result of the operation</returns>
		public OperationResult FindByKeywordText(string keywordText)
		{
            IFindLanguageKeywordRepository repository = (IFindLanguageKeywordRepository)RepositoryFactory.Create(Keywords.FindLanguageKeyword);
            try
            {
                List<LanguageKeyword> res = repository.FindByKeywordText(keywordText);
                return new OperationResult(true, res);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Finds all  Language Keyword data with language I D containing specified keyword
        /// </summary>
		/// <param name="languageID"> Language I D</param>
		/// <returns>The result of the operation</returns>
		public OperationResult FindByLanguageID(string languageID)
		{
            IFindLanguageKeywordRepository repository = (IFindLanguageKeywordRepository)RepositoryFactory.Create(Keywords.FindLanguageKeyword);
            try
            {
                List<LanguageKeyword> res = repository.FindByLanguageID(languageID);
                return new OperationResult(true, res);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}



    }
 }