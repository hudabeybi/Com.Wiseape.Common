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
    public class UpdateUserInfoBusinessService : BaseBusinessService<UserInfo>, IUpdateUserInfoBusinessService
    {
        class Keywords
        {
            public static string UpdateUserInfo = "Update.Common.Resources.UserInfo";
        }
        
        public UpdateUserInfoBusinessService(string repoKey) : base(repoKey)
        {
        }
        
        public UpdateUserInfoBusinessService()
        {
            this.RepoKey = Keywords.UpdateUserInfo;
        }


        /// <summary>
        /// Update  User Info data with id User Info, first Name
        /// </summary>
		/// <param name="idUserInfo"> Id User Info</param>
		/// <param name="firstName"> First Name</param>
		/// <returns>The result of the operation</returns>
		public virtual OperationResult UpdateFirstName(Int64 idUserInfo, string firstName)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate FirstName
			ValidationResult validationResult = this.ValidateFirstName( idUserInfo, firstName );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute Update
				operationResult = _UpdateFirstName(idUserInfo, firstName);
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
		protected virtual ValidationResult ValidateFirstName(Int64 idUserInfo, string firstName)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateUserInfo'. 
				//The validator factory will create the validator object based on its key.
				IUserInfoValidator validator = (IUserInfoValidator)ValidatorFactory.Create(Keywords.UpdateUserInfo);
				
				//Execute validation process
				validationResult = validator.ValidateFirstName(idUserInfo, firstName);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to update FirstName
		protected virtual OperationResult _UpdateFirstName(Int64 idUserInfo, string firstName)
		{
			//Create repository based on its Key name : 'Keywords.UpdateUserInfo'. 
			//The repository factory will create the repository object based on its key.
           	IUpdateUserInfoRepository repository = (IUpdateUserInfoRepository)RepositoryFactory.Create(Keywords.UpdateUserInfo);
            try
            {
            	//Execute UpdateFirstName
                repository.UpdateFirstName(idUserInfo, firstName);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
            	//Return false if error along with its exception
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Update  User Info data with id User Info, last Name
        /// </summary>
		/// <param name="idUserInfo"> Id User Info</param>
		/// <param name="lastName"> Last Name</param>
		/// <returns>The result of the operation</returns>
		public virtual OperationResult UpdateLastName(Int64 idUserInfo, string lastName)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate LastName
			ValidationResult validationResult = this.ValidateLastName( idUserInfo, lastName );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute Update
				operationResult = _UpdateLastName(idUserInfo, lastName);
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
		protected virtual ValidationResult ValidateLastName(Int64 idUserInfo, string lastName)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateUserInfo'. 
				//The validator factory will create the validator object based on its key.
				IUserInfoValidator validator = (IUserInfoValidator)ValidatorFactory.Create(Keywords.UpdateUserInfo);
				
				//Execute validation process
				validationResult = validator.ValidateLastName(idUserInfo, lastName);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to update LastName
		protected virtual OperationResult _UpdateLastName(Int64 idUserInfo, string lastName)
		{
			//Create repository based on its Key name : 'Keywords.UpdateUserInfo'. 
			//The repository factory will create the repository object based on its key.
           	IUpdateUserInfoRepository repository = (IUpdateUserInfoRepository)RepositoryFactory.Create(Keywords.UpdateUserInfo);
            try
            {
            	//Execute UpdateLastName
                repository.UpdateLastName(idUserInfo, lastName);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
            	//Return false if error along with its exception
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Update  User Info data with id User Info, mobile Phone
        /// </summary>
		/// <param name="idUserInfo"> Id User Info</param>
		/// <param name="mobilePhone"> Mobile Phone</param>
		/// <returns>The result of the operation</returns>
		public virtual OperationResult UpdateMobilePhone(Int64 idUserInfo, string mobilePhone)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate MobilePhone
			ValidationResult validationResult = this.ValidateMobilePhone( idUserInfo, mobilePhone );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute Update
				operationResult = _UpdateMobilePhone(idUserInfo, mobilePhone);
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
		protected virtual ValidationResult ValidateMobilePhone(Int64 idUserInfo, string mobilePhone)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateUserInfo'. 
				//The validator factory will create the validator object based on its key.
				IUserInfoValidator validator = (IUserInfoValidator)ValidatorFactory.Create(Keywords.UpdateUserInfo);
				
				//Execute validation process
				validationResult = validator.ValidateMobilePhone(idUserInfo, mobilePhone);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to update MobilePhone
		protected virtual OperationResult _UpdateMobilePhone(Int64 idUserInfo, string mobilePhone)
		{
			//Create repository based on its Key name : 'Keywords.UpdateUserInfo'. 
			//The repository factory will create the repository object based on its key.
           	IUpdateUserInfoRepository repository = (IUpdateUserInfoRepository)RepositoryFactory.Create(Keywords.UpdateUserInfo);
            try
            {
            	//Execute UpdateMobilePhone
                repository.UpdateMobilePhone(idUserInfo, mobilePhone);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
            	//Return false if error along with its exception
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Update  User Info data with id User Info, phone
        /// </summary>
		/// <param name="idUserInfo"> Id User Info</param>
		/// <param name="phone"> Phone</param>
		/// <returns>The result of the operation</returns>
		public virtual OperationResult UpdatePhone(Int64 idUserInfo, string phone)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate Phone
			ValidationResult validationResult = this.ValidatePhone( idUserInfo, phone );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute Update
				operationResult = _UpdatePhone(idUserInfo, phone);
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
		protected virtual ValidationResult ValidatePhone(Int64 idUserInfo, string phone)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateUserInfo'. 
				//The validator factory will create the validator object based on its key.
				IUserInfoValidator validator = (IUserInfoValidator)ValidatorFactory.Create(Keywords.UpdateUserInfo);
				
				//Execute validation process
				validationResult = validator.ValidatePhone(idUserInfo, phone);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to update Phone
		protected virtual OperationResult _UpdatePhone(Int64 idUserInfo, string phone)
		{
			//Create repository based on its Key name : 'Keywords.UpdateUserInfo'. 
			//The repository factory will create the repository object based on its key.
           	IUpdateUserInfoRepository repository = (IUpdateUserInfoRepository)RepositoryFactory.Create(Keywords.UpdateUserInfo);
            try
            {
            	//Execute UpdatePhone
                repository.UpdatePhone(idUserInfo, phone);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
            	//Return false if error along with its exception
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Update  User Info data with id User Info, address
        /// </summary>
		/// <param name="idUserInfo"> Id User Info</param>
		/// <param name="address"> Address</param>
		/// <returns>The result of the operation</returns>
		public virtual OperationResult UpdateAddress(Int64 idUserInfo, string address)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate Address
			ValidationResult validationResult = this.ValidateAddress( idUserInfo, address );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute Update
				operationResult = _UpdateAddress(idUserInfo, address);
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
		protected virtual ValidationResult ValidateAddress(Int64 idUserInfo, string address)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateUserInfo'. 
				//The validator factory will create the validator object based on its key.
				IUserInfoValidator validator = (IUserInfoValidator)ValidatorFactory.Create(Keywords.UpdateUserInfo);
				
				//Execute validation process
				validationResult = validator.ValidateAddress(idUserInfo, address);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to update Address
		protected virtual OperationResult _UpdateAddress(Int64 idUserInfo, string address)
		{
			//Create repository based on its Key name : 'Keywords.UpdateUserInfo'. 
			//The repository factory will create the repository object based on its key.
           	IUpdateUserInfoRepository repository = (IUpdateUserInfoRepository)RepositoryFactory.Create(Keywords.UpdateUserInfo);
            try
            {
            	//Execute UpdateAddress
                repository.UpdateAddress(idUserInfo, address);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
            	//Return false if error along with its exception
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Update  User Info data with id User Info, user Id
        /// </summary>
		/// <param name="idUserInfo"> Id User Info</param>
		/// <param name="userId"> User Id</param>
		/// <returns>The result of the operation</returns>
		public virtual OperationResult UpdateUserId(Int64 idUserInfo, Int64 userId)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate 
			ValidationResult validationResult = this.ValidateUserId( idUserInfo, userId );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute Update
				operationResult = _UpdateUserId(idUserInfo, userId);
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
		protected virtual ValidationResult ValidateUserId(Int64 idUserInfo, Int64 userId)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateUserInfo'. 
				//The validator factory will create the validator object based on its key.
				IUserInfoValidator validator = (IUserInfoValidator)ValidatorFactory.Create(Keywords.UpdateUserInfo);
				
				//Execute validation process
				validationResult = validator.ValidateUserId(idUserInfo, userId);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to update 
		protected virtual OperationResult _UpdateUserId(Int64 idUserInfo, Int64 userId)
		{
			//Create repository based on its Key name : 'Keywords.UpdateUserInfo'. 
			//The repository factory will create the repository object based on its key.
           	IUpdateUserInfoRepository repository = (IUpdateUserInfoRepository)RepositoryFactory.Create(Keywords.UpdateUserInfo);
            try
            {
            	//Execute UpdateUserId
                repository.UpdateUserId(idUserInfo, userId);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
            	//Return false if error along with its exception
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Update  User Info data with id User Info, user Id, gender Id
        /// </summary>
		/// <param name="idUserInfo"> Id User Info</param>
		/// <param name="userId"> User Id</param>
		/// <param name="genderId"> Gender Id</param>
		/// <returns>The result of the operation</returns>
		public virtual OperationResult UpdateUserIdAndGenderId(Int64 idUserInfo, Int64 userId, Int16 genderId)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate 
			ValidationResult validationResult = this.ValidateUserIdAndGenderId( idUserInfo, userId, genderId );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute Update
				operationResult = _UpdateUserIdAndGenderId(idUserInfo, userId, genderId);
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
		protected virtual ValidationResult ValidateUserIdAndGenderId(Int64 idUserInfo, Int64 userId, Int16 genderId)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateUserInfo'. 
				//The validator factory will create the validator object based on its key.
				IUserInfoValidator validator = (IUserInfoValidator)ValidatorFactory.Create(Keywords.UpdateUserInfo);
				
				//Execute validation process
				validationResult = validator.ValidateUserIdAndGenderId(idUserInfo, userId, genderId);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to update 
		protected virtual OperationResult _UpdateUserIdAndGenderId(Int64 idUserInfo, Int64 userId, Int16 genderId)
		{
			//Create repository based on its Key name : 'Keywords.UpdateUserInfo'. 
			//The repository factory will create the repository object based on its key.
           	IUpdateUserInfoRepository repository = (IUpdateUserInfoRepository)RepositoryFactory.Create(Keywords.UpdateUserInfo);
            try
            {
            	//Execute UpdateUserIdAndGenderId
                repository.UpdateUserIdAndGenderId(idUserInfo, userId, genderId);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
            	//Return false if error along with its exception
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Update  User Info data with id User Info, user Id, gender Id, city Id
        /// </summary>
		/// <param name="idUserInfo"> Id User Info</param>
		/// <param name="userId"> User Id</param>
		/// <param name="genderId"> Gender Id</param>
		/// <param name="cityId"> City Id</param>
		/// <returns>The result of the operation</returns>
		public virtual OperationResult UpdateUserIdAndGenderIdAndCityId(Int64 idUserInfo, Int64 userId, Int16 genderId, Int16 cityId)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate 
			ValidationResult validationResult = this.ValidateUserIdAndGenderIdAndCityId( idUserInfo, userId, genderId, cityId );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute Update
				operationResult = _UpdateUserIdAndGenderIdAndCityId(idUserInfo, userId, genderId, cityId);
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
		protected virtual ValidationResult ValidateUserIdAndGenderIdAndCityId(Int64 idUserInfo, Int64 userId, Int16 genderId, Int16 cityId)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateUserInfo'. 
				//The validator factory will create the validator object based on its key.
				IUserInfoValidator validator = (IUserInfoValidator)ValidatorFactory.Create(Keywords.UpdateUserInfo);
				
				//Execute validation process
				validationResult = validator.ValidateUserIdAndGenderIdAndCityId(idUserInfo, userId, genderId, cityId);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to update 
		protected virtual OperationResult _UpdateUserIdAndGenderIdAndCityId(Int64 idUserInfo, Int64 userId, Int16 genderId, Int16 cityId)
		{
			//Create repository based on its Key name : 'Keywords.UpdateUserInfo'. 
			//The repository factory will create the repository object based on its key.
           	IUpdateUserInfoRepository repository = (IUpdateUserInfoRepository)RepositoryFactory.Create(Keywords.UpdateUserInfo);
            try
            {
            	//Execute UpdateUserIdAndGenderIdAndCityId
                repository.UpdateUserIdAndGenderIdAndCityId(idUserInfo, userId, genderId, cityId);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
            	//Return false if error along with its exception
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Update  User Info data with id User Info, user Id, city Id
        /// </summary>
		/// <param name="idUserInfo"> Id User Info</param>
		/// <param name="userId"> User Id</param>
		/// <param name="cityId"> City Id</param>
		/// <returns>The result of the operation</returns>
		public virtual OperationResult UpdateUserIdAndCityId(Int64 idUserInfo, Int64 userId, Int16 cityId)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate 
			ValidationResult validationResult = this.ValidateUserIdAndCityId( idUserInfo, userId, cityId );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute Update
				operationResult = _UpdateUserIdAndCityId(idUserInfo, userId, cityId);
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
		protected virtual ValidationResult ValidateUserIdAndCityId(Int64 idUserInfo, Int64 userId, Int16 cityId)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateUserInfo'. 
				//The validator factory will create the validator object based on its key.
				IUserInfoValidator validator = (IUserInfoValidator)ValidatorFactory.Create(Keywords.UpdateUserInfo);
				
				//Execute validation process
				validationResult = validator.ValidateUserIdAndCityId(idUserInfo, userId, cityId);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to update 
		protected virtual OperationResult _UpdateUserIdAndCityId(Int64 idUserInfo, Int64 userId, Int16 cityId)
		{
			//Create repository based on its Key name : 'Keywords.UpdateUserInfo'. 
			//The repository factory will create the repository object based on its key.
           	IUpdateUserInfoRepository repository = (IUpdateUserInfoRepository)RepositoryFactory.Create(Keywords.UpdateUserInfo);
            try
            {
            	//Execute UpdateUserIdAndCityId
                repository.UpdateUserIdAndCityId(idUserInfo, userId, cityId);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
            	//Return false if error along with its exception
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Update  User Info data with id User Info, gender Id
        /// </summary>
		/// <param name="idUserInfo"> Id User Info</param>
		/// <param name="genderId"> Gender Id</param>
		/// <returns>The result of the operation</returns>
		public virtual OperationResult UpdateGenderId(Int64 idUserInfo, Int16 genderId)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate 
			ValidationResult validationResult = this.ValidateGenderId( idUserInfo, genderId );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute Update
				operationResult = _UpdateGenderId(idUserInfo, genderId);
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
		protected virtual ValidationResult ValidateGenderId(Int64 idUserInfo, Int16 genderId)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateUserInfo'. 
				//The validator factory will create the validator object based on its key.
				IUserInfoValidator validator = (IUserInfoValidator)ValidatorFactory.Create(Keywords.UpdateUserInfo);
				
				//Execute validation process
				validationResult = validator.ValidateGenderId(idUserInfo, genderId);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to update 
		protected virtual OperationResult _UpdateGenderId(Int64 idUserInfo, Int16 genderId)
		{
			//Create repository based on its Key name : 'Keywords.UpdateUserInfo'. 
			//The repository factory will create the repository object based on its key.
           	IUpdateUserInfoRepository repository = (IUpdateUserInfoRepository)RepositoryFactory.Create(Keywords.UpdateUserInfo);
            try
            {
            	//Execute UpdateGenderId
                repository.UpdateGenderId(idUserInfo, genderId);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
            	//Return false if error along with its exception
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Update  User Info data with id User Info, gender Id, city Id
        /// </summary>
		/// <param name="idUserInfo"> Id User Info</param>
		/// <param name="genderId"> Gender Id</param>
		/// <param name="cityId"> City Id</param>
		/// <returns>The result of the operation</returns>
		public virtual OperationResult UpdateGenderIdAndCityId(Int64 idUserInfo, Int16 genderId, Int16 cityId)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate 
			ValidationResult validationResult = this.ValidateGenderIdAndCityId( idUserInfo, genderId, cityId );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute Update
				operationResult = _UpdateGenderIdAndCityId(idUserInfo, genderId, cityId);
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
		protected virtual ValidationResult ValidateGenderIdAndCityId(Int64 idUserInfo, Int16 genderId, Int16 cityId)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateUserInfo'. 
				//The validator factory will create the validator object based on its key.
				IUserInfoValidator validator = (IUserInfoValidator)ValidatorFactory.Create(Keywords.UpdateUserInfo);
				
				//Execute validation process
				validationResult = validator.ValidateGenderIdAndCityId(idUserInfo, genderId, cityId);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to update 
		protected virtual OperationResult _UpdateGenderIdAndCityId(Int64 idUserInfo, Int16 genderId, Int16 cityId)
		{
			//Create repository based on its Key name : 'Keywords.UpdateUserInfo'. 
			//The repository factory will create the repository object based on its key.
           	IUpdateUserInfoRepository repository = (IUpdateUserInfoRepository)RepositoryFactory.Create(Keywords.UpdateUserInfo);
            try
            {
            	//Execute UpdateGenderIdAndCityId
                repository.UpdateGenderIdAndCityId(idUserInfo, genderId, cityId);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
            	//Return false if error along with its exception
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Update  User Info data with id User Info, city Id
        /// </summary>
		/// <param name="idUserInfo"> Id User Info</param>
		/// <param name="cityId"> City Id</param>
		/// <returns>The result of the operation</returns>
		public virtual OperationResult UpdateCityId(Int64 idUserInfo, Int16 cityId)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate 
			ValidationResult validationResult = this.ValidateCityId( idUserInfo, cityId );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute Update
				operationResult = _UpdateCityId(idUserInfo, cityId);
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
		protected virtual ValidationResult ValidateCityId(Int64 idUserInfo, Int16 cityId)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateUserInfo'. 
				//The validator factory will create the validator object based on its key.
				IUserInfoValidator validator = (IUserInfoValidator)ValidatorFactory.Create(Keywords.UpdateUserInfo);
				
				//Execute validation process
				validationResult = validator.ValidateCityId(idUserInfo, cityId);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to update 
		protected virtual OperationResult _UpdateCityId(Int64 idUserInfo, Int16 cityId)
		{
			//Create repository based on its Key name : 'Keywords.UpdateUserInfo'. 
			//The repository factory will create the repository object based on its key.
           	IUpdateUserInfoRepository repository = (IUpdateUserInfoRepository)RepositoryFactory.Create(Keywords.UpdateUserInfo);
            try
            {
            	//Execute UpdateCityId
                repository.UpdateCityId(idUserInfo, cityId);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
            	//Return false if error along with its exception
                return new OperationResult(false, e);
            }			
		}


    }
 }