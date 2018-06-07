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
    /// Business Service for UserLogin module.
    /// </summary>
    public class DeleteUserLoginBusinessService : BaseBusinessService<UserLogin>, IDeleteUserLoginBusinessService
    {
        class Keywords
        {
            public static string DeleteUserLogin = "Delete.Common.Resources.UserLogin";
        }
        
        public DeleteUserLoginBusinessService(string repoKey) : base(repoKey)
        {
        }
        
        public DeleteUserLoginBusinessService()
        {
            this.RepoKey = Keywords.DeleteUserLogin;
        }

        /// <summary>
        /// Delete  User Login data by username
        /// </summary>
		/// <param name="username"> Username</param>
		/// <returns>The result of the operation</returns>
		public OperationResult DeleteByUsername(string username)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate Username
			ValidationResult validationResult = this.ValidateUsername( username );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute delete
				operationResult = this._DeleteByUsername(username);
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
		
		//Validate Username
		protected virtual ValidationResult ValidateUsername(string username)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateUserLogin'. 
				//The validator factory will create the validator object based on its key.
				IUserLoginValidator validator = (IUserLoginValidator)ValidatorFactory.Create(Keywords.DeleteUserLogin);
				
				//Execute validation process
				validationResult = validator.ValidateUsername(username);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to delete Username
		protected virtual OperationResult _DeleteByUsername(string username)
		{
			//Create repository based on its Key name : 'Keywords.DeleteUserLogin'. 
			//The repository factory will create the repository object based on its key. 
            IDeleteUserLoginRepository repository = (IDeleteUserLoginRepository)RepositoryFactory.Create(Keywords.DeleteUserLogin);
            try
            {
            	//Execute DeleteByUsername
                repository.DeleteByUsername(username);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Delete  User Login data by user Password
        /// </summary>
		/// <param name="userPassword"> User Password</param>
		/// <returns>The result of the operation</returns>
		public OperationResult DeleteByUserPassword(string userPassword)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate UserPassword
			ValidationResult validationResult = this.ValidateUserPassword( userPassword );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute delete
				operationResult = this._DeleteByUserPassword(userPassword);
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
		
		//Validate UserPassword
		protected virtual ValidationResult ValidateUserPassword(string userPassword)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateUserLogin'. 
				//The validator factory will create the validator object based on its key.
				IUserLoginValidator validator = (IUserLoginValidator)ValidatorFactory.Create(Keywords.DeleteUserLogin);
				
				//Execute validation process
				validationResult = validator.ValidateUserPassword(userPassword);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to delete UserPassword
		protected virtual OperationResult _DeleteByUserPassword(string userPassword)
		{
			//Create repository based on its Key name : 'Keywords.DeleteUserLogin'. 
			//The repository factory will create the repository object based on its key. 
            IDeleteUserLoginRepository repository = (IDeleteUserLoginRepository)RepositoryFactory.Create(Keywords.DeleteUserLogin);
            try
            {
            	//Execute DeleteByUserPassword
                repository.DeleteByUserPassword(userPassword);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Delete  User Login data by created Date
        /// </summary>
		/// <param name="createdDate"> Created Date</param>
		/// <returns>The result of the operation</returns>
		public OperationResult DeleteByCreatedDate(DateTime createdDate)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate CreatedDate
			ValidationResult validationResult = this.ValidateCreatedDate( createdDate );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute delete
				operationResult = this._DeleteByCreatedDate(createdDate);
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
		
		//Validate CreatedDate
		protected virtual ValidationResult ValidateCreatedDate(DateTime createdDate)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateUserLogin'. 
				//The validator factory will create the validator object based on its key.
				IUserLoginValidator validator = (IUserLoginValidator)ValidatorFactory.Create(Keywords.DeleteUserLogin);
				
				//Execute validation process
				validationResult = validator.ValidateCreatedDate(createdDate);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to delete CreatedDate
		protected virtual OperationResult _DeleteByCreatedDate(DateTime createdDate)
		{
			//Create repository based on its Key name : 'Keywords.DeleteUserLogin'. 
			//The repository factory will create the repository object based on its key. 
            IDeleteUserLoginRepository repository = (IDeleteUserLoginRepository)RepositoryFactory.Create(Keywords.DeleteUserLogin);
            try
            {
            	//Execute DeleteByCreatedDate
                repository.DeleteByCreatedDate(createdDate);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Delete  User Login data by application I D
        /// </summary>
		/// <param name="applicationID"> Application I D</param>
		/// <returns>The result of the operation</returns>
		public OperationResult DeleteByApplicationID(string applicationID)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate ApplicationID
			ValidationResult validationResult = this.ValidateApplicationID( applicationID );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute delete
				operationResult = this._DeleteByApplicationID(applicationID);
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
		
		//Validate ApplicationID
		protected virtual ValidationResult ValidateApplicationID(string applicationID)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateUserLogin'. 
				//The validator factory will create the validator object based on its key.
				IUserLoginValidator validator = (IUserLoginValidator)ValidatorFactory.Create(Keywords.DeleteUserLogin);
				
				//Execute validation process
				validationResult = validator.ValidateApplicationID(applicationID);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to delete ApplicationID
		protected virtual OperationResult _DeleteByApplicationID(string applicationID)
		{
			//Create repository based on its Key name : 'Keywords.DeleteUserLogin'. 
			//The repository factory will create the repository object based on its key. 
            IDeleteUserLoginRepository repository = (IDeleteUserLoginRepository)RepositoryFactory.Create(Keywords.DeleteUserLogin);
            try
            {
            	//Execute DeleteByApplicationID
                repository.DeleteByApplicationID(applicationID);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Delete  User Login data by is Active
        /// </summary>
		/// <param name="isActive"> Is Active</param>
		/// <returns>The result of the operation</returns>
		public OperationResult DeleteByIsActive(Int16 isActive)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate 
			ValidationResult validationResult = this.ValidateIsActive( isActive );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute delete
				operationResult = this._DeleteByIsActive(isActive);
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
		protected virtual ValidationResult ValidateIsActive(Int16 isActive)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateUserLogin'. 
				//The validator factory will create the validator object based on its key.
				IUserLoginValidator validator = (IUserLoginValidator)ValidatorFactory.Create(Keywords.DeleteUserLogin);
				
				//Execute validation process
				validationResult = validator.ValidateIsActive(isActive);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to delete 
		protected virtual OperationResult _DeleteByIsActive(Int16 isActive)
		{
			//Create repository based on its Key name : 'Keywords.DeleteUserLogin'. 
			//The repository factory will create the repository object based on its key. 
            IDeleteUserLoginRepository repository = (IDeleteUserLoginRepository)RepositoryFactory.Create(Keywords.DeleteUserLogin);
            try
            {
            	//Execute DeleteByIsActive
                repository.DeleteByIsActive(isActive);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}


    }
 }