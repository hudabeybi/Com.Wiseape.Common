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
    /// Repository for UpdateGender data.
    /// </summary>
    public class UpdateGenderRepository : BaseRepository<Gender>, IUpdateGenderRepository
    {
        class Keywords
        {
            public static string UpdateGender = "Update.Common.Resources.Gender";
        }

        /// <summary>
        /// Constructor for GenderRepository
        /// </summary>
        /// <param name="dataContextKey">Key for Datacontext to use</param>
        public UpdateGenderRepository(string dataContextKey) : base(dataContextKey)
        {
        }
        
        
        public UpdateGenderRepository()
        {
            this.DataContextKey = Keywords.UpdateGender;
        }


//-------------------------- Update columns by Primary key -----------------------------------------

        /// <summary>
        /// Updates  Gender's id Gender, gender Name by idGender
        /// </summary>
		/// <param name="idGender">id Gender</param>
		/// <param name="genderName">gender Name</param>
		/// <returns>List of  Gender</returns>
        public void UpdateGenderName(Int16 idGender, string genderName)
        {
            CommonDataContext dataContext = (CommonDataContext)this.DataContext;
            var list = from o in dataContext.Genders
                       where
                       		o.IdGender == idGender
                       	select o;
           	list.ToList().ForEach(o => {
      			o.GenderName = genderName;	
            });
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Updates  Gender's id Gender, gender Icon by idGender
        /// </summary>
		/// <param name="idGender">id Gender</param>
		/// <param name="genderIcon">gender Icon</param>
		/// <returns>List of  Gender</returns>
        public void UpdateGenderIcon(Int16 idGender, string genderIcon)
        {
            CommonDataContext dataContext = (CommonDataContext)this.DataContext;
            var list = from o in dataContext.Genders
                       where
                       		o.IdGender == idGender
                       	select o;
           	list.ToList().ForEach(o => {
      			o.GenderIcon = genderIcon;	
            });
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Updates  Gender's id Gender, language I D by idGender
        /// </summary>
		/// <param name="idGender">id Gender</param>
		/// <param name="languageID">language I D</param>
		/// <returns>List of  Gender</returns>
        public void UpdateLanguageID(Int16 idGender, string languageID)
        {
            CommonDataContext dataContext = (CommonDataContext)this.DataContext;
            var list = from o in dataContext.Genders
                       where
                       		o.IdGender == idGender
                       	select o;
           	list.ToList().ForEach(o => {
      			o.LanguageID = languageID;	
            });
            dataContext.SaveChanges();
        }


//-------------------------- Update foreign keys -----------------------------------------


    }
}
