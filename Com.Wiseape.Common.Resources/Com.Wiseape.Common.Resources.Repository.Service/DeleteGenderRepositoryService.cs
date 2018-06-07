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
    public class DeleteGenderRepository : BaseRepository<Gender>, IDeleteGenderRepository
    {
        class Keywords
        {
            public static string DeleteGender = "Delete.Common.Resources.Gender";
        }

        /// <summary>
        /// Constructor for DeleteGenderRepository
        /// </summary>
        /// <param name="dataContextKey">Key for Datacontext to use</param>
        public DeleteGenderRepository(string dataContextKey) : base(dataContextKey)
        {
        }
        
        
        public DeleteGenderRepository()
        {
            this.DataContextKey = Keywords.DeleteGender;
        }

//------------------- Delete by keywords --------------------------------------------------------

        /// <summary>
        /// Delete all  Gender data with gender Name containing specified keyword
        /// </summary>
		/// <param name="genderName"> Gender Name</param>
		/// <returns>List of  Gender</returns>
        public void DeleteByGenderName(string genderName)
        {
            CommonDataContext dataContext = (CommonDataContext)this.DataContext;
            var list = from o in dataContext.Genders
                       where
							o.GenderName.Contains(genderName) 						
						select o;
			dataContext.Genders.RemoveRange(list);
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Delete all  Gender data with gender Icon containing specified keyword
        /// </summary>
		/// <param name="genderIcon"> Gender Icon</param>
		/// <returns>List of  Gender</returns>
        public void DeleteByGenderIcon(string genderIcon)
        {
            CommonDataContext dataContext = (CommonDataContext)this.DataContext;
            var list = from o in dataContext.Genders
                       where
							o.GenderIcon.Contains(genderIcon) 						
						select o;
			dataContext.Genders.RemoveRange(list);
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Delete all  Gender data with language I D containing specified keyword
        /// </summary>
		/// <param name="languageID"> Language I D</param>
		/// <returns>List of  Gender</returns>
        public void DeleteByLanguageID(string languageID)
        {
            CommonDataContext dataContext = (CommonDataContext)this.DataContext;
            var list = from o in dataContext.Genders
                       where
							o.LanguageID.Contains(languageID) 						
						select o;
			dataContext.Genders.RemoveRange(list);
            dataContext.SaveChanges();
        }


//-----------------------  Delete by Foreign keys ---------------------------------------


    }
}
