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
    /// Business Service for Gender module.
    /// </summary>
    public class FindGenderBusinessService : BaseBusinessService<Gender>, IFindGenderBusinessService
    {
        class Keywords
        {
            public static string FindGender = "Find.Common.Resources.Gender";
        }
        
        public FindGenderBusinessService(string repoKey) : base(repoKey)
        {
        }
        
        public FindGenderBusinessService()
        {
            this.RepoKey = Keywords.FindGender;
        }


        /// <summary>
        /// Finds all  Gender data with gender Name containing specified keyword
        /// </summary>
		/// <param name="genderName"> Gender Name</param>
		/// <returns>The result of the operation</returns>
		public OperationResult FindByGenderName(string genderName)
		{
            IFindGenderRepository repository = (IFindGenderRepository)RepositoryFactory.Create(Keywords.FindGender);
            try
            {
                List<Gender> res = repository.FindByGenderName(genderName);
                return new OperationResult(true, res);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Finds all  Gender data with gender Icon containing specified keyword
        /// </summary>
		/// <param name="genderIcon"> Gender Icon</param>
		/// <returns>The result of the operation</returns>
		public OperationResult FindByGenderIcon(string genderIcon)
		{
            IFindGenderRepository repository = (IFindGenderRepository)RepositoryFactory.Create(Keywords.FindGender);
            try
            {
                List<Gender> res = repository.FindByGenderIcon(genderIcon);
                return new OperationResult(true, res);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Finds all  Gender data with language I D containing specified keyword
        /// </summary>
		/// <param name="languageID"> Language I D</param>
		/// <returns>The result of the operation</returns>
		public OperationResult FindByLanguageID(string languageID)
		{
            IFindGenderRepository repository = (IFindGenderRepository)RepositoryFactory.Create(Keywords.FindGender);
            try
            {
                List<Gender> res = repository.FindByLanguageID(languageID);
                return new OperationResult(true, res);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}



    }
 }