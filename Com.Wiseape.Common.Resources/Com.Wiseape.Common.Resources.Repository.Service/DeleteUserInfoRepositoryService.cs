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
    /// Repository for UserInfo data.
    /// </summary>
    public class DeleteUserInfoRepository : BaseRepository<UserInfo>, IDeleteUserInfoRepository
    {
        class Keywords
        {
            public static string DeleteUserInfo = "Delete.Common.Resources.UserInfo";
        }

        /// <summary>
        /// Constructor for DeleteUserInfoRepository
        /// </summary>
        /// <param name="dataContextKey">Key for Datacontext to use</param>
        public DeleteUserInfoRepository(string dataContextKey) : base(dataContextKey)
        {
        }
        
        
        public DeleteUserInfoRepository()
        {
            this.DataContextKey = Keywords.DeleteUserInfo;
        }

//------------------- Delete by keywords --------------------------------------------------------

        /// <summary>
        /// Delete all  User Info data with first Name containing specified keyword
        /// </summary>
		/// <param name="firstName"> First Name</param>
		/// <returns>List of  User Info</returns>
        public void DeleteByFirstName(string firstName)
        {
            CommonDataContext dataContext = (CommonDataContext)this.DataContext;
            var list = from o in dataContext.UserInfoes
                       where
							o.FirstName.Contains(firstName) 						
						select o;
			dataContext.UserInfoes.RemoveRange(list);
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Delete all  User Info data with last Name containing specified keyword
        /// </summary>
		/// <param name="lastName"> Last Name</param>
		/// <returns>List of  User Info</returns>
        public void DeleteByLastName(string lastName)
        {
            CommonDataContext dataContext = (CommonDataContext)this.DataContext;
            var list = from o in dataContext.UserInfoes
                       where
							o.LastName.Contains(lastName) 						
						select o;
			dataContext.UserInfoes.RemoveRange(list);
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Delete all  User Info data with mobile Phone containing specified keyword
        /// </summary>
		/// <param name="mobilePhone"> Mobile Phone</param>
		/// <returns>List of  User Info</returns>
        public void DeleteByMobilePhone(string mobilePhone)
        {
            CommonDataContext dataContext = (CommonDataContext)this.DataContext;
            var list = from o in dataContext.UserInfoes
                       where
							o.MobilePhone.Contains(mobilePhone) 						
						select o;
			dataContext.UserInfoes.RemoveRange(list);
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Delete all  User Info data with phone containing specified keyword
        /// </summary>
		/// <param name="phone"> Phone</param>
		/// <returns>List of  User Info</returns>
        public void DeleteByPhone(string phone)
        {
            CommonDataContext dataContext = (CommonDataContext)this.DataContext;
            var list = from o in dataContext.UserInfoes
                       where
							o.Phone.Contains(phone) 						
						select o;
			dataContext.UserInfoes.RemoveRange(list);
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Delete all  User Info data with address containing specified keyword
        /// </summary>
		/// <param name="address"> Address</param>
		/// <returns>List of  User Info</returns>
        public void DeleteByAddress(string address)
        {
            CommonDataContext dataContext = (CommonDataContext)this.DataContext;
            var list = from o in dataContext.UserInfoes
                       where
							o.Address.Contains(address) 						
						select o;
			dataContext.UserInfoes.RemoveRange(list);
            dataContext.SaveChanges();
        }


//-----------------------  Delete by Foreign keys ---------------------------------------

        /// <summary>
        /// Delete all  User Info data with specified user Id 
        /// </summary>
		/// <param name="userId"> User Id</param>
		/// <returns>List of  User Info</returns>
        public void DeleteByUserId(Int64 userId)
        {
            CommonDataContext dataContext = (CommonDataContext)this.DataContext;
            var list = from o in dataContext.UserInfoes
                       where
							o.UserId == userId  						
						select o;
            dataContext.UserInfoes.RemoveRange(list);
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Delete all  User Info data with specified user Id, gender Id 
        /// </summary>
		/// <param name="userId"> User Id</param>
		/// <param name="genderId"> Gender Id</param>
		/// <returns>List of  User Info</returns>
        public void DeleteByUserIdAndGenderId(Int64 userId, Int16 genderId)
        {
            CommonDataContext dataContext = (CommonDataContext)this.DataContext;
            var list = from o in dataContext.UserInfoes
                       where
							o.UserId == userId && 
							o.GenderId == genderId  						
						select o;
            dataContext.UserInfoes.RemoveRange(list);
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Delete all  User Info data with specified user Id, gender Id, city Id 
        /// </summary>
		/// <param name="userId"> User Id</param>
		/// <param name="genderId"> Gender Id</param>
		/// <param name="cityId"> City Id</param>
		/// <returns>List of  User Info</returns>
        public void DeleteByUserIdAndGenderIdAndCityId(Int64 userId, Int16 genderId, Int16 cityId)
        {
            CommonDataContext dataContext = (CommonDataContext)this.DataContext;
            var list = from o in dataContext.UserInfoes
                       where
							o.UserId == userId && 
							o.GenderId == genderId && 
							o.CityId == cityId  						
						select o;
            dataContext.UserInfoes.RemoveRange(list);
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Delete all  User Info data with specified user Id, city Id 
        /// </summary>
		/// <param name="userId"> User Id</param>
		/// <param name="cityId"> City Id</param>
		/// <returns>List of  User Info</returns>
        public void DeleteByUserIdAndCityId(Int64 userId, Int16 cityId)
        {
            CommonDataContext dataContext = (CommonDataContext)this.DataContext;
            var list = from o in dataContext.UserInfoes
                       where
							o.UserId == userId && 
							o.CityId == cityId  						
						select o;
            dataContext.UserInfoes.RemoveRange(list);
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Delete all  User Info data with specified gender Id 
        /// </summary>
		/// <param name="genderId"> Gender Id</param>
		/// <returns>List of  User Info</returns>
        public void DeleteByGenderId(Int16 genderId)
        {
            CommonDataContext dataContext = (CommonDataContext)this.DataContext;
            var list = from o in dataContext.UserInfoes
                       where
							o.GenderId == genderId  						
						select o;
            dataContext.UserInfoes.RemoveRange(list);
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Delete all  User Info data with specified gender Id, city Id 
        /// </summary>
		/// <param name="genderId"> Gender Id</param>
		/// <param name="cityId"> City Id</param>
		/// <returns>List of  User Info</returns>
        public void DeleteByGenderIdAndCityId(Int16 genderId, Int16 cityId)
        {
            CommonDataContext dataContext = (CommonDataContext)this.DataContext;
            var list = from o in dataContext.UserInfoes
                       where
							o.GenderId == genderId && 
							o.CityId == cityId  						
						select o;
            dataContext.UserInfoes.RemoveRange(list);
            dataContext.SaveChanges();
        }

        /// <summary>
        /// Delete all  User Info data with specified city Id 
        /// </summary>
		/// <param name="cityId"> City Id</param>
		/// <returns>List of  User Info</returns>
        public void DeleteByCityId(Int16 cityId)
        {
            CommonDataContext dataContext = (CommonDataContext)this.DataContext;
            var list = from o in dataContext.UserInfoes
                       where
							o.CityId == cityId  						
						select o;
            dataContext.UserInfoes.RemoveRange(list);
            dataContext.SaveChanges();
        }


    }
}
