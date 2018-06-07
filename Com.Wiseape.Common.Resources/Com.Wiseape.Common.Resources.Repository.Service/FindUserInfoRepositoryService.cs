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
    public class FindUserInfoRepository : BaseRepository<UserInfo>, IFindUserInfoRepository
    {
        class Keywords
        {
            public static string FindUserInfo = "Find.Common.Resources.UserInfo";
        }

        /// <summary>
        /// Constructor for UserInfoRepository
        /// </summary>
        /// <param name="dataContextKey">Key for Datacontext to use</param>
        public FindUserInfoRepository(string dataContextKey) : base(dataContextKey)
        {
        }
        
        
        public FindUserInfoRepository()
        {
            this.DataContextKey = Keywords.FindUserInfo;
        }

//------------------- Find by keywords --------------------------------------------------------

        /// <summary>
        /// Finds all  User Info data with first Name containing specified keyword
        /// </summary>
		/// <param name="firstName"> First Name</param>
		/// <returns>List of  User Info</returns>
        public List<UserInfo> FindByFirstName(string firstName)
        {
            CommonDataContext dataContext = (CommonDataContext)this.DataContext;
            var list = from o in dataContext.UserInfoes
                       where
							o.FirstName.Contains(firstName) 						
						select o;
            return list.ToList();
        }

        /// <summary>
        /// Finds all  User Info data with last Name containing specified keyword
        /// </summary>
		/// <param name="lastName"> Last Name</param>
		/// <returns>List of  User Info</returns>
        public List<UserInfo> FindByLastName(string lastName)
        {
            CommonDataContext dataContext = (CommonDataContext)this.DataContext;
            var list = from o in dataContext.UserInfoes
                       where
							o.LastName.Contains(lastName) 						
						select o;
            return list.ToList();
        }

        /// <summary>
        /// Finds all  User Info data with mobile Phone containing specified keyword
        /// </summary>
		/// <param name="mobilePhone"> Mobile Phone</param>
		/// <returns>List of  User Info</returns>
        public List<UserInfo> FindByMobilePhone(string mobilePhone)
        {
            CommonDataContext dataContext = (CommonDataContext)this.DataContext;
            var list = from o in dataContext.UserInfoes
                       where
							o.MobilePhone.Contains(mobilePhone) 						
						select o;
            return list.ToList();
        }

        /// <summary>
        /// Finds all  User Info data with phone containing specified keyword
        /// </summary>
		/// <param name="phone"> Phone</param>
		/// <returns>List of  User Info</returns>
        public List<UserInfo> FindByPhone(string phone)
        {
            CommonDataContext dataContext = (CommonDataContext)this.DataContext;
            var list = from o in dataContext.UserInfoes
                       where
							o.Phone.Contains(phone) 						
						select o;
            return list.ToList();
        }

        /// <summary>
        /// Finds all  User Info data with address containing specified keyword
        /// </summary>
		/// <param name="address"> Address</param>
		/// <returns>List of  User Info</returns>
        public List<UserInfo> FindByAddress(string address)
        {
            CommonDataContext dataContext = (CommonDataContext)this.DataContext;
            var list = from o in dataContext.UserInfoes
                       where
							o.Address.Contains(address) 						
						select o;
            return list.ToList();
        }


//----------------------  find by dates -----------------------------------------------


//-----------------------  Find by Foreign keys ---------------------------------------

        /// <summary>
        /// Finds all  User Info data with specified user Id 
        /// </summary>
		/// <param name="userId"> User Id</param>
		/// <returns>List of  User Info</returns>
        public List<UserInfo> FindByUserId(Int64 userId)
        {
            CommonDataContext dataContext = (CommonDataContext)this.DataContext;
            var list = from o in dataContext.UserInfoes
                       where
							o.UserId == userId  						
						select o;
            return list.ToList();
        }

        /// <summary>
        /// Finds all  User Info data with specified user Id, gender Id 
        /// </summary>
		/// <param name="userId"> User Id</param>
		/// <param name="genderId"> Gender Id</param>
		/// <returns>List of  User Info</returns>
        public List<UserInfo> FindByUserIdAndGenderId(Int64 userId, Int16 genderId)
        {
            CommonDataContext dataContext = (CommonDataContext)this.DataContext;
            var list = from o in dataContext.UserInfoes
                       where
							o.UserId == userId && 
							o.GenderId == genderId  						
						select o;
            return list.ToList();
        }

        /// <summary>
        /// Finds all  User Info data with specified user Id, gender Id, city Id 
        /// </summary>
		/// <param name="userId"> User Id</param>
		/// <param name="genderId"> Gender Id</param>
		/// <param name="cityId"> City Id</param>
		/// <returns>List of  User Info</returns>
        public List<UserInfo> FindByUserIdAndGenderIdAndCityId(Int64 userId, Int16 genderId, Int16 cityId)
        {
            CommonDataContext dataContext = (CommonDataContext)this.DataContext;
            var list = from o in dataContext.UserInfoes
                       where
							o.UserId == userId && 
							o.GenderId == genderId && 
							o.CityId == cityId  						
						select o;
            return list.ToList();
        }

        /// <summary>
        /// Finds all  User Info data with specified user Id, city Id 
        /// </summary>
		/// <param name="userId"> User Id</param>
		/// <param name="cityId"> City Id</param>
		/// <returns>List of  User Info</returns>
        public List<UserInfo> FindByUserIdAndCityId(Int64 userId, Int16 cityId)
        {
            CommonDataContext dataContext = (CommonDataContext)this.DataContext;
            var list = from o in dataContext.UserInfoes
                       where
							o.UserId == userId && 
							o.CityId == cityId  						
						select o;
            return list.ToList();
        }

        /// <summary>
        /// Finds all  User Info data with specified gender Id 
        /// </summary>
		/// <param name="genderId"> Gender Id</param>
		/// <returns>List of  User Info</returns>
        public List<UserInfo> FindByGenderId(Int16 genderId)
        {
            CommonDataContext dataContext = (CommonDataContext)this.DataContext;
            var list = from o in dataContext.UserInfoes
                       where
							o.GenderId == genderId  						
						select o;
            return list.ToList();
        }

        /// <summary>
        /// Finds all  User Info data with specified gender Id, city Id 
        /// </summary>
		/// <param name="genderId"> Gender Id</param>
		/// <param name="cityId"> City Id</param>
		/// <returns>List of  User Info</returns>
        public List<UserInfo> FindByGenderIdAndCityId(Int16 genderId, Int16 cityId)
        {
            CommonDataContext dataContext = (CommonDataContext)this.DataContext;
            var list = from o in dataContext.UserInfoes
                       where
							o.GenderId == genderId && 
							o.CityId == cityId  						
						select o;
            return list.ToList();
        }

        /// <summary>
        /// Finds all  User Info data with specified city Id 
        /// </summary>
		/// <param name="cityId"> City Id</param>
		/// <returns>List of  User Info</returns>
        public List<UserInfo> FindByCityId(Int16 cityId)
        {
            CommonDataContext dataContext = (CommonDataContext)this.DataContext;
            var list = from o in dataContext.UserInfoes
                       where
							o.CityId == cityId  						
						select o;
            return list.ToList();
        }




    }
}
