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
using Com.Wiseape.Common.Resources.View.Contract.Validator;

namespace Com.Wiseape.Common.Resources.Business.Service
{
    /// <summary>
    /// Business Service for UserInfo module.
    /// </summary>
    public class DeleteUserInfoBusinessService : BaseBusinessService<UserInfo>, IDeleteUserInfoBusinessService
    {
        class Keywords
        {
            public static string DeleteUserInfo = "Delete.Common.Resources.UserInfo";
        }
        
        public DeleteUserInfoBusinessService(string repoKey) : base(repoKey)
        {
        }
        
        public DeleteUserInfoBusinessService()
        {
            this.RepoKey = Keywords.DeleteUserInfo;
        }

        /// <summary>
        /// Delete  User Info data by first Name
        /// </summary>
		/// <param name="firstName"> First Name</param>
		/// <returns>The result of the operation</returns>
		public OperationResult DeleteByFirstName(string firstName)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate FirstName
			ValidationResult validationResult = this.ValidateFirstName( firstName );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute delete
				operationResult = this._DeleteByFirstName(firstName);
			}
			else
			{
				//Don't execute update, return validation result
				operationResult.Result = false;
				operationResult.Data = validationResult;
			}
			
			//Return result
			return operationResult;		
		}
		
		//Validate FirstName
		protected virtual ValidationResult ValidateFirstName(string firstName)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateUserInfo'. 
				//The validator factory will create the validator object based on its key.
				IUserInfoValidator validator = (IUserInfoValidator)ValidatorFactory.Create(Keywords.DeleteUserInfo);
				
				//Execute validation process
				validationResult = validator.ValidateFirstName(firstName);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to delete FirstName
		protected virtual OperationResult _DeleteByFirstName(string firstName)
		{
			//Create repository based on its Key name : 'Keywords.DeleteUserInfo'. 
			//The repository factory will create the repository object based on its key. 
            IDeleteUserInfoRepository repository = (IDeleteUserInfoRepository)RepositoryFactory.Create(Keywords.DeleteUserInfo);
            try
            {
            	//Execute DeleteByFirstName
                repository.DeleteByFirstName(firstName);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Delete  User Info data by last Name
        /// </summary>
		/// <param name="lastName"> Last Name</param>
		/// <returns>The result of the operation</returns>
		public OperationResult DeleteByLastName(string lastName)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate LastName
			ValidationResult validationResult = this.ValidateLastName( lastName );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute delete
				operationResult = this._DeleteByLastName(lastName);
			}
			else
			{
				//Don't execute update, return validation result
				operationResult.Result = false;
				operationResult.Data = validationResult;
			}
			
			//Return result
			return operationResult;		
		}
		
		//Validate LastName
		protected virtual ValidationResult ValidateLastName(string lastName)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateUserInfo'. 
				//The validator factory will create the validator object based on its key.
				IUserInfoValidator validator = (IUserInfoValidator)ValidatorFactory.Create(Keywords.DeleteUserInfo);
				
				//Execute validation process
				validationResult = validator.ValidateLastName(lastName);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to delete LastName
		protected virtual OperationResult _DeleteByLastName(string lastName)
		{
			//Create repository based on its Key name : 'Keywords.DeleteUserInfo'. 
			//The repository factory will create the repository object based on its key. 
            IDeleteUserInfoRepository repository = (IDeleteUserInfoRepository)RepositoryFactory.Create(Keywords.DeleteUserInfo);
            try
            {
            	//Execute DeleteByLastName
                repository.DeleteByLastName(lastName);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Delete  User Info data by mobile Phone
        /// </summary>
		/// <param name="mobilePhone"> Mobile Phone</param>
		/// <returns>The result of the operation</returns>
		public OperationResult DeleteByMobilePhone(string mobilePhone)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate MobilePhone
			ValidationResult validationResult = this.ValidateMobilePhone( mobilePhone );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute delete
				operationResult = this._DeleteByMobilePhone(mobilePhone);
			}
			else
			{
				//Don't execute update, return validation result
				operationResult.Result = false;
				operationResult.Data = validationResult;
			}
			
			//Return result
			return operationResult;		
		}
		
		//Validate MobilePhone
		protected virtual ValidationResult ValidateMobilePhone(string mobilePhone)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateUserInfo'. 
				//The validator factory will create the validator object based on its key.
				IUserInfoValidator validator = (IUserInfoValidator)ValidatorFactory.Create(Keywords.DeleteUserInfo);
				
				//Execute validation process
				validationResult = validator.ValidateMobilePhone(mobilePhone);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to delete MobilePhone
		protected virtual OperationResult _DeleteByMobilePhone(string mobilePhone)
		{
			//Create repository based on its Key name : 'Keywords.DeleteUserInfo'. 
			//The repository factory will create the repository object based on its key. 
            IDeleteUserInfoRepository repository = (IDeleteUserInfoRepository)RepositoryFactory.Create(Keywords.DeleteUserInfo);
            try
            {
            	//Execute DeleteByMobilePhone
                repository.DeleteByMobilePhone(mobilePhone);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Delete  User Info data by phone
        /// </summary>
		/// <param name="phone"> Phone</param>
		/// <returns>The result of the operation</returns>
		public OperationResult DeleteByPhone(string phone)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate Phone
			ValidationResult validationResult = this.ValidatePhone( phone );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute delete
				operationResult = this._DeleteByPhone(phone);
			}
			else
			{
				//Don't execute update, return validation result
				operationResult.Result = false;
				operationResult.Data = validationResult;
			}
			
			//Return result
			return operationResult;		
		}
		
		//Validate Phone
		protected virtual ValidationResult ValidatePhone(string phone)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateUserInfo'. 
				//The validator factory will create the validator object based on its key.
				IUserInfoValidator validator = (IUserInfoValidator)ValidatorFactory.Create(Keywords.DeleteUserInfo);
				
				//Execute validation process
				validationResult = validator.ValidatePhone(phone);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to delete Phone
		protected virtual OperationResult _DeleteByPhone(string phone)
		{
			//Create repository based on its Key name : 'Keywords.DeleteUserInfo'. 
			//The repository factory will create the repository object based on its key. 
            IDeleteUserInfoRepository repository = (IDeleteUserInfoRepository)RepositoryFactory.Create(Keywords.DeleteUserInfo);
            try
            {
            	//Execute DeleteByPhone
                repository.DeleteByPhone(phone);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Delete  User Info data by address
        /// </summary>
		/// <param name="address"> Address</param>
		/// <returns>The result of the operation</returns>
		public OperationResult DeleteByAddress(string address)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate Address
			ValidationResult validationResult = this.ValidateAddress( address );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute delete
				operationResult = this._DeleteByAddress(address);
			}
			else
			{
				//Don't execute update, return validation result
				operationResult.Result = false;
				operationResult.Data = validationResult;
			}
			
			//Return result
			return operationResult;		
		}
		
		//Validate Address
		protected virtual ValidationResult ValidateAddress(string address)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateUserInfo'. 
				//The validator factory will create the validator object based on its key.
				IUserInfoValidator validator = (IUserInfoValidator)ValidatorFactory.Create(Keywords.DeleteUserInfo);
				
				//Execute validation process
				validationResult = validator.ValidateAddress(address);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to delete Address
		protected virtual OperationResult _DeleteByAddress(string address)
		{
			//Create repository based on its Key name : 'Keywords.DeleteUserInfo'. 
			//The repository factory will create the repository object based on its key. 
            IDeleteUserInfoRepository repository = (IDeleteUserInfoRepository)RepositoryFactory.Create(Keywords.DeleteUserInfo);
            try
            {
            	//Execute DeleteByAddress
                repository.DeleteByAddress(address);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Delete  User Info data by user Id
        /// </summary>
		/// <param name="userId"> User Id</param>
		/// <returns>The result of the operation</returns>
		public OperationResult DeleteByUserId(Int64 userId)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate 
			ValidationResult validationResult = this.ValidateUserId( userId );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute delete
				operationResult = this._DeleteByUserId(userId);
			}
			else
			{
				//Don't execute update, return validation result
				operationResult.Result = false;
				operationResult.Data = validationResult;
			}
			
			//Return result
			return operationResult;		
		}
		
		//Validate 
		protected virtual ValidationResult ValidateUserId(Int64 userId)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateUserInfo'. 
				//The validator factory will create the validator object based on its key.
				IUserInfoValidator validator = (IUserInfoValidator)ValidatorFactory.Create(Keywords.DeleteUserInfo);
				
				//Execute validation process
				validationResult = validator.ValidateUserId(userId);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to delete 
		protected virtual OperationResult _DeleteByUserId(Int64 userId)
		{
			//Create repository based on its Key name : 'Keywords.DeleteUserInfo'. 
			//The repository factory will create the repository object based on its key. 
            IDeleteUserInfoRepository repository = (IDeleteUserInfoRepository)RepositoryFactory.Create(Keywords.DeleteUserInfo);
            try
            {
            	//Execute DeleteByUserId
                repository.DeleteByUserId(userId);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Delete  User Info data by user Id, gender Id
        /// </summary>
		/// <param name="userId"> User Id</param>
		/// <param name="genderId"> Gender Id</param>
		/// <returns>The result of the operation</returns>
		public OperationResult DeleteByUserIdAndGenderId(Int64 userId, Int16 genderId)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate 
			ValidationResult validationResult = this.ValidateUserIdAndGenderId( userId, genderId );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute delete
				operationResult = this._DeleteByUserIdAndGenderId(userId, genderId);
			}
			else
			{
				//Don't execute update, return validation result
				operationResult.Result = false;
				operationResult.Data = validationResult;
			}
			
			//Return result
			return operationResult;		
		}
		
		//Validate 
		protected virtual ValidationResult ValidateUserIdAndGenderId(Int64 userId, Int16 genderId)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateUserInfo'. 
				//The validator factory will create the validator object based on its key.
				IUserInfoValidator validator = (IUserInfoValidator)ValidatorFactory.Create(Keywords.DeleteUserInfo);
				
				//Execute validation process
				validationResult = validator.ValidateUserIdAndGenderId(userId, genderId);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to delete 
		protected virtual OperationResult _DeleteByUserIdAndGenderId(Int64 userId, Int16 genderId)
		{
			//Create repository based on its Key name : 'Keywords.DeleteUserInfo'. 
			//The repository factory will create the repository object based on its key. 
            IDeleteUserInfoRepository repository = (IDeleteUserInfoRepository)RepositoryFactory.Create(Keywords.DeleteUserInfo);
            try
            {
            	//Execute DeleteByUserIdAndGenderId
                repository.DeleteByUserIdAndGenderId(userId, genderId);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Delete  User Info data by user Id, gender Id, city Id
        /// </summary>
		/// <param name="userId"> User Id</param>
		/// <param name="genderId"> Gender Id</param>
		/// <param name="cityId"> City Id</param>
		/// <returns>The result of the operation</returns>
		public OperationResult DeleteByUserIdAndGenderIdAndCityId(Int64 userId, Int16 genderId, Int16 cityId)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate 
			ValidationResult validationResult = this.ValidateUserIdAndGenderIdAndCityId( userId, genderId, cityId );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute delete
				operationResult = this._DeleteByUserIdAndGenderIdAndCityId(userId, genderId, cityId);
			}
			else
			{
				//Don't execute update, return validation result
				operationResult.Result = false;
				operationResult.Data = validationResult;
			}
			
			//Return result
			return operationResult;		
		}
		
		//Validate 
		protected virtual ValidationResult ValidateUserIdAndGenderIdAndCityId(Int64 userId, Int16 genderId, Int16 cityId)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateUserInfo'. 
				//The validator factory will create the validator object based on its key.
				IUserInfoValidator validator = (IUserInfoValidator)ValidatorFactory.Create(Keywords.DeleteUserInfo);
				
				//Execute validation process
				validationResult = validator.ValidateUserIdAndGenderIdAndCityId(userId, genderId, cityId);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to delete 
		protected virtual OperationResult _DeleteByUserIdAndGenderIdAndCityId(Int64 userId, Int16 genderId, Int16 cityId)
		{
			//Create repository based on its Key name : 'Keywords.DeleteUserInfo'. 
			//The repository factory will create the repository object based on its key. 
            IDeleteUserInfoRepository repository = (IDeleteUserInfoRepository)RepositoryFactory.Create(Keywords.DeleteUserInfo);
            try
            {
            	//Execute DeleteByUserIdAndGenderIdAndCityId
                repository.DeleteByUserIdAndGenderIdAndCityId(userId, genderId, cityId);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Delete  User Info data by user Id, city Id
        /// </summary>
		/// <param name="userId"> User Id</param>
		/// <param name="cityId"> City Id</param>
		/// <returns>The result of the operation</returns>
		public OperationResult DeleteByUserIdAndCityId(Int64 userId, Int16 cityId)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate 
			ValidationResult validationResult = this.ValidateUserIdAndCityId( userId, cityId );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute delete
				operationResult = this._DeleteByUserIdAndCityId(userId, cityId);
			}
			else
			{
				//Don't execute update, return validation result
				operationResult.Result = false;
				operationResult.Data = validationResult;
			}
			
			//Return result
			return operationResult;		
		}
		
		//Validate 
		protected virtual ValidationResult ValidateUserIdAndCityId(Int64 userId, Int16 cityId)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateUserInfo'. 
				//The validator factory will create the validator object based on its key.
				IUserInfoValidator validator = (IUserInfoValidator)ValidatorFactory.Create(Keywords.DeleteUserInfo);
				
				//Execute validation process
				validationResult = validator.ValidateUserIdAndCityId(userId, cityId);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to delete 
		protected virtual OperationResult _DeleteByUserIdAndCityId(Int64 userId, Int16 cityId)
		{
			//Create repository based on its Key name : 'Keywords.DeleteUserInfo'. 
			//The repository factory will create the repository object based on its key. 
            IDeleteUserInfoRepository repository = (IDeleteUserInfoRepository)RepositoryFactory.Create(Keywords.DeleteUserInfo);
            try
            {
            	//Execute DeleteByUserIdAndCityId
                repository.DeleteByUserIdAndCityId(userId, cityId);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Delete  User Info data by gender Id
        /// </summary>
		/// <param name="genderId"> Gender Id</param>
		/// <returns>The result of the operation</returns>
		public OperationResult DeleteByGenderId(Int16 genderId)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate 
			ValidationResult validationResult = this.ValidateGenderId( genderId );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute delete
				operationResult = this._DeleteByGenderId(genderId);
			}
			else
			{
				//Don't execute update, return validation result
				operationResult.Result = false;
				operationResult.Data = validationResult;
			}
			
			//Return result
			return operationResult;		
		}
		
		//Validate 
		protected virtual ValidationResult ValidateGenderId(Int16 genderId)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateUserInfo'. 
				//The validator factory will create the validator object based on its key.
				IUserInfoValidator validator = (IUserInfoValidator)ValidatorFactory.Create(Keywords.DeleteUserInfo);
				
				//Execute validation process
				validationResult = validator.ValidateGenderId(genderId);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to delete 
		protected virtual OperationResult _DeleteByGenderId(Int16 genderId)
		{
			//Create repository based on its Key name : 'Keywords.DeleteUserInfo'. 
			//The repository factory will create the repository object based on its key. 
            IDeleteUserInfoRepository repository = (IDeleteUserInfoRepository)RepositoryFactory.Create(Keywords.DeleteUserInfo);
            try
            {
            	//Execute DeleteByGenderId
                repository.DeleteByGenderId(genderId);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Delete  User Info data by gender Id, city Id
        /// </summary>
		/// <param name="genderId"> Gender Id</param>
		/// <param name="cityId"> City Id</param>
		/// <returns>The result of the operation</returns>
		public OperationResult DeleteByGenderIdAndCityId(Int16 genderId, Int16 cityId)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate 
			ValidationResult validationResult = this.ValidateGenderIdAndCityId( genderId, cityId );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute delete
				operationResult = this._DeleteByGenderIdAndCityId(genderId, cityId);
			}
			else
			{
				//Don't execute update, return validation result
				operationResult.Result = false;
				operationResult.Data = validationResult;
			}
			
			//Return result
			return operationResult;		
		}
		
		//Validate 
		protected virtual ValidationResult ValidateGenderIdAndCityId(Int16 genderId, Int16 cityId)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateUserInfo'. 
				//The validator factory will create the validator object based on its key.
				IUserInfoValidator validator = (IUserInfoValidator)ValidatorFactory.Create(Keywords.DeleteUserInfo);
				
				//Execute validation process
				validationResult = validator.ValidateGenderIdAndCityId(genderId, cityId);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to delete 
		protected virtual OperationResult _DeleteByGenderIdAndCityId(Int16 genderId, Int16 cityId)
		{
			//Create repository based on its Key name : 'Keywords.DeleteUserInfo'. 
			//The repository factory will create the repository object based on its key. 
            IDeleteUserInfoRepository repository = (IDeleteUserInfoRepository)RepositoryFactory.Create(Keywords.DeleteUserInfo);
            try
            {
            	//Execute DeleteByGenderIdAndCityId
                repository.DeleteByGenderIdAndCityId(genderId, cityId);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Delete  User Info data by city Id
        /// </summary>
		/// <param name="cityId"> City Id</param>
		/// <returns>The result of the operation</returns>
		public OperationResult DeleteByCityId(Int16 cityId)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate 
			ValidationResult validationResult = this.ValidateCityId( cityId );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute delete
				operationResult = this._DeleteByCityId(cityId);
			}
			else
			{
				//Don't execute update, return validation result
				operationResult.Result = false;
				operationResult.Data = validationResult;
			}
			
			//Return result
			return operationResult;		
		}
		
		//Validate 
		protected virtual ValidationResult ValidateCityId(Int16 cityId)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateUserInfo'. 
				//The validator factory will create the validator object based on its key.
				IUserInfoValidator validator = (IUserInfoValidator)ValidatorFactory.Create(Keywords.DeleteUserInfo);
				
				//Execute validation process
				validationResult = validator.ValidateCityId(cityId);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to delete 
		protected virtual OperationResult _DeleteByCityId(Int16 cityId)
		{
			//Create repository based on its Key name : 'Keywords.DeleteUserInfo'. 
			//The repository factory will create the repository object based on its key. 
            IDeleteUserInfoRepository repository = (IDeleteUserInfoRepository)RepositoryFactory.Create(Keywords.DeleteUserInfo);
            try
            {
            	//Execute DeleteByCityId
                repository.DeleteByCityId(cityId);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}


    }
 }