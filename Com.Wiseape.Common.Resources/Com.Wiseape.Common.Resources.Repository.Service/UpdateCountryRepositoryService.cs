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
    /// Repository for UpdateCountry data.
    /// </summary>
    public class UpdateCountryRepository : BaseRepository<Country>, IUpdateCountryRepository
    {
        class Keywords
        {
            public static string UpdateCountry = "Update.Common.Resources.Country";
        }

        /// <summary>
        /// Constructor for CountryRepository
        /// </summary>
        /// <param name="dataContextKey">Key for Datacontext to use</param>
        public UpdateCountryRepository(string dataContextKey) : base(dataContextKey)
        {
        }
        
        
        public UpdateCountryRepository()
        {
            this.DataContextKey = Keywords.UpdateCountry;
        }


//-------------------------- Update columns by Primary key -----------------------------------------

        /// <summary>
        /// Updates  Country's id Country, country Name by idCountry
        /// </summary>
		/// <param name="idCountry">id Country</param>
		/// <param name="countryName">country Name</param>
		/// <returns>List of  Country</returns>
        public void UpdateCountryName(Int16 idCountry, string countryName)
        {
            CommonDataContext dataContext = (CommonDataContext)this.DataContext;
            var list = from o in dataContext.Countries
                       where
                       		o.IdCountry == idCountry
                       	select o;
           	list.ToList().ForEach(o => {
      			o.CountryName = countryName;	
            });
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Updates  Country's id Country, country Desc by idCountry
        /// </summary>
		/// <param name="idCountry">id Country</param>
		/// <param name="countryDesc">country Desc</param>
		/// <returns>List of  Country</returns>
        public void UpdateCountryDesc(Int16 idCountry, string countryDesc)
        {
            CommonDataContext dataContext = (CommonDataContext)this.DataContext;
            var list = from o in dataContext.Countries
                       where
                       		o.IdCountry == idCountry
                       	select o;
           	list.ToList().ForEach(o => {
      			o.CountryDesc = countryDesc;	
            });
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Updates  Country's id Country, country Flag Icon by idCountry
        /// </summary>
		/// <param name="idCountry">id Country</param>
		/// <param name="countryFlagIcon">country Flag Icon</param>
		/// <returns>List of  Country</returns>
        public void UpdateCountryFlagIcon(Int16 idCountry, string countryFlagIcon)
        {
            CommonDataContext dataContext = (CommonDataContext)this.DataContext;
            var list = from o in dataContext.Countries
                       where
                       		o.IdCountry == idCountry
                       	select o;
           	list.ToList().ForEach(o => {
      			o.CountryFlagIcon = countryFlagIcon;	
            });
            dataContext.SaveChanges();
        }


//-------------------------- Update foreign keys -----------------------------------------

        /// <summary>
        /// Updates  Country's id Country, is Active by idCountry
        /// </summary>
		/// <param name="idCountry">id Country</param>
		/// <param name="isActive">is Active</param>
		/// <returns>List of  Country</returns>
        public void UpdateIsActive(Int16 idCountry, Int16 isActive)
        {
            CommonDataContext dataContext = (CommonDataContext)this.DataContext;
            var list = from o in dataContext.Countries
                       where
                       		o.IdCountry == idCountry
                       	select o;
           	list.ToList().ForEach(o => {
      			o.IsActive = isActive;
	
            });
            dataContext.SaveChanges();
        }


    }
}
