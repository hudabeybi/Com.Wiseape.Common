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
    public class FindCountryRepository : BaseRepository<Country>, IFindCountryRepository
    {
        class Keywords
        {
            public static string FindCountry = "Find.Common.Resources.Country";
        }

        /// <summary>
        /// Constructor for CountryRepository
        /// </summary>
        /// <param name="dataContextKey">Key for Datacontext to use</param>
        public FindCountryRepository(string dataContextKey) : base(dataContextKey)
        {
        }
        
        
        public FindCountryRepository()
        {
            this.DataContextKey = Keywords.FindCountry;
        }

//------------------- Find by keywords --------------------------------------------------------

        /// <summary>
        /// Finds all  Country data with country Name containing specified keyword
        /// </summary>
		/// <param name="countryName"> Country Name</param>
		/// <returns>List of  Country</returns>
        public List<Country> FindByCountryName(string countryName)
        {
            CommonDataContext dataContext = (CommonDataContext)this.DataContext;
            var list = from o in dataContext.Countries
                       where
							o.CountryName.Contains(countryName) 						
						select o;
            return list.ToList();
        }

        /// <summary>
        /// Finds all  Country data with country Desc containing specified keyword
        /// </summary>
		/// <param name="countryDesc"> Country Desc</param>
		/// <returns>List of  Country</returns>
        public List<Country> FindByCountryDesc(string countryDesc)
        {
            CommonDataContext dataContext = (CommonDataContext)this.DataContext;
            var list = from o in dataContext.Countries
                       where
							o.CountryDesc.Contains(countryDesc) 						
						select o;
            return list.ToList();
        }

        /// <summary>
        /// Finds all  Country data with country Flag Icon containing specified keyword
        /// </summary>
		/// <param name="countryFlagIcon"> Country Flag Icon</param>
		/// <returns>List of  Country</returns>
        public List<Country> FindByCountryFlagIcon(string countryFlagIcon)
        {
            CommonDataContext dataContext = (CommonDataContext)this.DataContext;
            var list = from o in dataContext.Countries
                       where
							o.CountryFlagIcon.Contains(countryFlagIcon) 						
						select o;
            return list.ToList();
        }


//----------------------  find by dates -----------------------------------------------


//-----------------------  Find by Foreign keys ---------------------------------------

        /// <summary>
        /// Finds all  Country data with specified is Active 
        /// </summary>
		/// <param name="isActive"> Is Active</param>
		/// <returns>List of  Country</returns>
        public List<Country> FindByIsActive(Int16 isActive)
        {
            CommonDataContext dataContext = (CommonDataContext)this.DataContext;
            var list = from o in dataContext.Countries
                       where
							o.IsActive == isActive  						
						select o;
            return list.ToList();
        }




    }
}
