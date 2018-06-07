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
    /// Repository for Gender data.
    /// </summary>
    public class FindGenderRepository : BaseRepository<Gender>, IFindGenderRepository
    {
        class Keywords
        {
            public static string FindGender = "Find.Common.Resources.Gender";
        }

        /// <summary>
        /// Constructor for GenderRepository
        /// </summary>
        /// <param name="dataContextKey">Key for Datacontext to use</param>
        public FindGenderRepository(string dataContextKey) : base(dataContextKey)
        {
        }
        
        
        public FindGenderRepository()
        {
            this.DataContextKey = Keywords.FindGender;
        }

//------------------- Find by keywords --------------------------------------------------------

        /// <summary>
        /// Finds all  Gender data with gender Name containing specified keyword
        /// </summary>
		/// <param name="genderName"> Gender Name</param>
		/// <returns>List of  Gender</returns>
        public List<Gender> FindByGenderName(string genderName)
        {
            CommonDataContext dataContext = (CommonDataContext)this.DataContext;
            var list = from o in dataContext.Genders
                       where
							o.GenderName.Contains(genderName) 						
						select o;
            return list.ToList();
        }

        /// <summary>
        /// Finds all  Gender data with gender Icon containing specified keyword
        /// </summary>
		/// <param name="genderIcon"> Gender Icon</param>
		/// <returns>List of  Gender</returns>
        public List<Gender> FindByGenderIcon(string genderIcon)
        {
            CommonDataContext dataContext = (CommonDataContext)this.DataContext;
            var list = from o in dataContext.Genders
                       where
							o.GenderIcon.Contains(genderIcon) 						
						select o;
            return list.ToList();
        }

        /// <summary>
        /// Finds all  Gender data with language I D containing specified keyword
        /// </summary>
		/// <param name="languageID"> Language I D</param>
		/// <returns>List of  Gender</returns>
        public List<Gender> FindByLanguageID(string languageID)
        {
            CommonDataContext dataContext = (CommonDataContext)this.DataContext;
            var list = from o in dataContext.Genders
                       where
							o.LanguageID.Contains(languageID) 						
						select o;
            return list.ToList();
        }


//----------------------  find by dates -----------------------------------------------


//-----------------------  Find by Foreign keys ---------------------------------------




    }
}
