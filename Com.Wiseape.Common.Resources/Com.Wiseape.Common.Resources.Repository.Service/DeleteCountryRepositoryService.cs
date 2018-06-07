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
    /// Repository for Country data.
    /// </summary>
    public class DeleteCountryRepository : BaseRepository<Country>, IDeleteCountryRepository
    {
        class Keywords
        {
            public static string DeleteCountry = "Delete.Common.Resources.Country";
        }

        /// <summary>
        /// Constructor for DeleteCountryRepository
        /// </summary>
        /// <param name="dataContextKey">Key for Datacontext to use</param>
        public DeleteCountryRepository(string dataContextKey) : base(dataContextKey)
        {
        }
        
        
        public DeleteCountryRepository()
        {
            this.DataContextKey = Keywords.DeleteCountry;
        }

//------------------- Delete by keywords --------------------------------------------------------

        /// <summary>
        /// Delete all  Country data with country Name containing specified keyword
        /// </summary>
		/// <param name="countryName"> Country Name</param>
		/// <returns>List of  Country</returns>
        public void DeleteByCountryName(string countryName)
        {
            CommonDataContext dataContext = (CommonDataContext)this.DataContext;
            var list = from o in dataContext.Countries
                       where
							o.CountryName.Contains(countryName) 						
						select o;
			dataContext.Countries.RemoveRange(list);
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Delete all  Country data with country Desc containing specified keyword
        /// </summary>
		/// <param name="countryDesc"> Country Desc</param>
		/// <returns>List of  Country</returns>
        public void DeleteByCountryDesc(string countryDesc)
        {
            CommonDataContext dataContext = (CommonDataContext)this.DataContext;
            var list = from o in dataContext.Countries
                       where
							o.CountryDesc.Contains(countryDesc) 						
						select o;
			dataContext.Countries.RemoveRange(list);
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Delete all  Country data with country Flag Icon containing specified keyword
        /// </summary>
		/// <param name="countryFlagIcon"> Country Flag Icon</param>
		/// <returns>List of  Country</returns>
        public void DeleteByCountryFlagIcon(string countryFlagIcon)
        {
            CommonDataContext dataContext = (CommonDataContext)this.DataContext;
            var list = from o in dataContext.Countries
                       where
							o.CountryFlagIcon.Contains(countryFlagIcon) 						
						select o;
			dataContext.Countries.RemoveRange(list);
            dataContext.SaveChanges();
        }


//-----------------------  Delete by Foreign keys ---------------------------------------

        /// <summary>
        /// Delete all  Country data with specified is Active 
        /// </summary>
		/// <param name="isActive"> Is Active</param>
		/// <returns>List of  Country</returns>
        public void DeleteByIsActive(Int16 isActive)
        {
            CommonDataContext dataContext = (CommonDataContext)this.DataContext;
            var list = from o in dataContext.Countries
                       where
							o.IsActive == isActive  						
						select o;
            dataContext.Countries.RemoveRange(list);
            dataContext.SaveChanges();
        }


    }
}
