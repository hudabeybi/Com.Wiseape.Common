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
    /// Repository for UpdateUserInfo data.
    /// </summary>
    public class UpdateUserInfoRepository : BaseRepository<UserInfo>, IUpdateUserInfoRepository
    {
        class Keywords
        {
            public static string UpdateUserInfo = "Update.Common.Resources.UserInfo";
        }

        /// <summary>
        /// Constructor for UserInfoRepository
        /// </summary>
        /// <param name="dataContextKey">Key for Datacontext to use</param>
        public UpdateUserInfoRepository(string dataContextKey) : base(dataContextKey)
        {
        }
        
        
        public UpdateUserInfoRepository()
        {
            this.DataContextKey = Keywords.UpdateUserInfo;
        }


//-------------------------- Update columns by Primary key -----------------------------------------

        /// <summary>
        /// Updates  User Info's id User Info, first Name by idUserInfo
        /// </summary>
		/// <param name="idUserInfo">id User Info</param>
		/// <param name="firstName">first Name</param>
		/// <returns>List of  User Info</returns>
        public void UpdateFirstName(Int64 idUserInfo, string firstName)
        {
            CommonDataContext dataContext = (CommonDataContext)this.DataContext;
            var list = from o in dataContext.UserInfoes
                       where
                       		o.IdUserInfo == idUserInfo
                       	select o;
           	list.ToList().ForEach(o => {
      			o.FirstName = firstName;	
            });
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Updates  User Info's id User Info, last Name by idUserInfo
        /// </summary>
		/// <param name="idUserInfo">id User Info</param>
		/// <param name="lastName">last Name</param>
		/// <returns>List of  User Info</returns>
        public void UpdateLastName(Int64 idUserInfo, string lastName)
        {
            CommonDataContext dataContext = (CommonDataContext)this.DataContext;
            var list = from o in dataContext.UserInfoes
                       where
                       		o.IdUserInfo == idUserInfo
                       	select o;
           	list.ToList().ForEach(o => {
      			o.LastName = lastName;	
            });
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Updates  User Info's id User Info, mobile Phone by idUserInfo
        /// </summary>
		/// <param name="idUserInfo">id User Info</param>
		/// <param name="mobilePhone">mobile Phone</param>
		/// <returns>List of  User Info</returns>
        public void UpdateMobilePhone(Int64 idUserInfo, string mobilePhone)
        {
            CommonDataContext dataContext = (CommonDataContext)this.DataContext;
            var list = from o in dataContext.UserInfoes
                       where
                       		o.IdUserInfo == idUserInfo
                       	select o;
           	list.ToList().ForEach(o => {
      			o.MobilePhone = mobilePhone;	
            });
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Updates  User Info's id User Info, phone by idUserInfo
        /// </summary>
		/// <param name="idUserInfo">id User Info</param>
		/// <param name="phone">phone</param>
		/// <returns>List of  User Info</returns>
        public void UpdatePhone(Int64 idUserInfo, string phone)
        {
            CommonDataContext dataContext = (CommonDataContext)this.DataContext;
            var list = from o in dataContext.UserInfoes
                       where
                       		o.IdUserInfo == idUserInfo
                       	select o;
           	list.ToList().ForEach(o => {
      			o.Phone = phone;	
            });
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Updates  User Info's id User Info, address by idUserInfo
        /// </summary>
		/// <param name="idUserInfo">id User Info</param>
		/// <param name="address">address</param>
		/// <returns>List of  User Info</returns>
        public void UpdateAddress(Int64 idUserInfo, string address)
        {
            CommonDataContext dataContext = (CommonDataContext)this.DataContext;
            var list = from o in dataContext.UserInfoes
                       where
                       		o.IdUserInfo == idUserInfo
                       	select o;
           	list.ToList().ForEach(o => {
      			o.Address = address;	
            });
            dataContext.SaveChanges();
        }


//-------------------------- Update foreign keys -----------------------------------------

        /// <summary>
        /// Updates  User Info's id User Info, user Id by idUserInfo
        /// </summary>
		/// <param name="idUserInfo">id User Info</param>
		/// <param name="userId">user Id</param>
		/// <returns>List of  User Info</returns>
        public void UpdateUserId(Int64 idUserInfo, Int64 userId)
        {
            CommonDataContext dataContext = (CommonDataContext)this.DataContext;
            var list = from o in dataContext.UserInfoes
                       where
                       		o.IdUserInfo == idUserInfo
                       	select o;
           	list.ToList().ForEach(o => {
      			o.UserId = userId;
	
            });
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Updates  User Info's id User Info, user Id, gender Id by idUserInfo
        /// </summary>
		/// <param name="idUserInfo">id User Info</param>
		/// <param name="userId">user Id</param>
		/// <param name="genderId">gender Id</param>
		/// <returns>List of  User Info</returns>
        public void UpdateUserIdAndGenderId(Int64 idUserInfo, Int64 userId, Int16 genderId)
        {
            CommonDataContext dataContext = (CommonDataContext)this.DataContext;
            var list = from o in dataContext.UserInfoes
                       where
                       		o.IdUserInfo == idUserInfo
                       	select o;
           	list.ToList().ForEach(o => {
      			o.UserId = userId;
     			o.GenderId = genderId;
	
            });
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Updates  User Info's id User Info, user Id, gender Id, city Id by idUserInfo
        /// </summary>
		/// <param name="idUserInfo">id User Info</param>
		/// <param name="userId">user Id</param>
		/// <param name="genderId">gender Id</param>
		/// <param name="cityId">city Id</param>
		/// <returns>List of  User Info</returns>
        public void UpdateUserIdAndGenderIdAndCityId(Int64 idUserInfo, Int64 userId, Int16 genderId, Int16 cityId)
        {
            CommonDataContext dataContext = (CommonDataContext)this.DataContext;
            var list = from o in dataContext.UserInfoes
                       where
                       		o.IdUserInfo == idUserInfo
                       	select o;
           	list.ToList().ForEach(o => {
      			o.UserId = userId;
     			o.GenderId = genderId;
     			o.CityId = cityId;
	
            });
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Updates  User Info's id User Info, user Id, city Id by idUserInfo
        /// </summary>
		/// <param name="idUserInfo">id User Info</param>
		/// <param name="userId">user Id</param>
		/// <param name="cityId">city Id</param>
		/// <returns>List of  User Info</returns>
        public void UpdateUserIdAndCityId(Int64 idUserInfo, Int64 userId, Int16 cityId)
        {
            CommonDataContext dataContext = (CommonDataContext)this.DataContext;
            var list = from o in dataContext.UserInfoes
                       where
                       		o.IdUserInfo == idUserInfo
                       	select o;
           	list.ToList().ForEach(o => {
      			o.UserId = userId;
     			o.CityId = cityId;
	
            });
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Updates  User Info's id User Info, gender Id by idUserInfo
        /// </summary>
		/// <param name="idUserInfo">id User Info</param>
		/// <param name="genderId">gender Id</param>
		/// <returns>List of  User Info</returns>
        public void UpdateGenderId(Int64 idUserInfo, Int16 genderId)
        {
            CommonDataContext dataContext = (CommonDataContext)this.DataContext;
            var list = from o in dataContext.UserInfoes
                       where
                       		o.IdUserInfo == idUserInfo
                       	select o;
           	list.ToList().ForEach(o => {
      			o.GenderId = genderId;
	
            });
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Updates  User Info's id User Info, gender Id, city Id by idUserInfo
        /// </summary>
		/// <param name="idUserInfo">id User Info</param>
		/// <param name="genderId">gender Id</param>
		/// <param name="cityId">city Id</param>
		/// <returns>List of  User Info</returns>
        public void UpdateGenderIdAndCityId(Int64 idUserInfo, Int16 genderId, Int16 cityId)
        {
            CommonDataContext dataContext = (CommonDataContext)this.DataContext;
            var list = from o in dataContext.UserInfoes
                       where
                       		o.IdUserInfo == idUserInfo
                       	select o;
           	list.ToList().ForEach(o => {
      			o.GenderId = genderId;
     			o.CityId = cityId;
	
            });
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Updates  User Info's id User Info, city Id by idUserInfo
        /// </summary>
		/// <param name="idUserInfo">id User Info</param>
		/// <param name="cityId">city Id</param>
		/// <returns>List of  User Info</returns>
        public void UpdateCityId(Int64 idUserInfo, Int16 cityId)
        {
            CommonDataContext dataContext = (CommonDataContext)this.DataContext;
            var list = from o in dataContext.UserInfoes
                       where
                       		o.IdUserInfo == idUserInfo
                       	select o;
           	list.ToList().ForEach(o => {
      			o.CityId = cityId;
	
            });
            dataContext.SaveChanges();
        }


    }
}
