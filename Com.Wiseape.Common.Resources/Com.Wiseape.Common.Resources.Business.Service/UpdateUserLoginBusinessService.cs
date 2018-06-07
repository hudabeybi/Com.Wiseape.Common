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
    public class UpdateUserLoginBusinessService : BaseBusinessService<UserLogin>, IUpdateUserLoginBusinessService
    {
        class Keywords
        {
            public static string UpdateUserLogin = "Update.Common.Resources.UserLogin";
        }
        
        public UpdateUserLoginBusinessService(string repoKey) : base(repoKey)
        {
        }
        
        public UpdateUserLoginBusinessService()
        {
            this.RepoKey = Keywords.UpdateUserLogin;
        }


        /// <summary>
        /// Update  User Login data with id User, username
        /// </summary>
		/// <param name="idUser"> Id User</param>
		/// <param name="username"> Username</param>
		/// <returns>The result of the operation</returns>
		public virtual OperationResult UpdateUsername(Int64 idUser, string username)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate Username
			ValidationResult validationResult = this.ValidateUsername( idUser, username );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute Update
				operationResult = _UpdateUsername(idUser, username);
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
		protected virtual ValidationResult ValidateUsername(Int64 idUser, string username)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateUserLogin'. 
				//The validator factory will create the validator object based on its key.
				IUserLoginValidator validator = (IUserLoginValidator)ValidatorFactory.Create(Keywords.UpdateUserLogin);
				
				//Execute validation process
				validationResult = validator.ValidateUsername(idUser, username);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to update Username
		protected virtual OperationResult _UpdateUsername(Int64 idUser, string username)
		{
			//Create repository based on its Key name : 'Keywords.UpdateUserLogin'. 
			//The repository factory will create the repository object based on its key.
           	IUpdateUserLoginRepository repository = (IUpdateUserLoginRepository)RepositoryFactory.Create(Keywords.UpdateUserLogin);
            try
            {
            	//Execute UpdateUsername
                repository.UpdateUsername(idUser, username);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
            	//Return false if error along with its exception
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Update  User Login data with id User, user Password
        /// </summary>
		/// <param name="idUser"> Id User</param>
		/// <param name="userPassword"> User Password</param>
		/// <returns>The result of the operation</returns>
		public virtual OperationResult UpdateUserPassword(Int64 idUser, string userPassword)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate UserPassword
			ValidationResult validationResult = this.ValidateUserPassword( idUser, userPassword );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute Update
				operationResult = _UpdateUserPassword(idUser, userPassword);
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
		protected virtual ValidationResult ValidateUserPassword(Int64 idUser, string userPassword)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateUserLogin'. 
				//The validator factory will create the validator object based on its key.
				IUserLoginValidator validator = (IUserLoginValidator)ValidatorFactory.Create(Keywords.UpdateUserLogin);
				
				//Execute validation process
				validationResult = validator.ValidateUserPassword(idUser, userPassword);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to update UserPassword
		protected virtual OperationResult _UpdateUserPassword(Int64 idUser, string userPassword)
		{
			//Create repository based on its Key name : 'Keywords.UpdateUserLogin'. 
			//The repository factory will create the repository object based on its key.
           	IUpdateUserLoginRepository repository = (IUpdateUserLoginRepository)RepositoryFactory.Create(Keywords.UpdateUserLogin);
            try
            {
            	//Execute UpdateUserPassword
                repository.UpdateUserPassword(idUser, userPassword);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
            	//Return false if error along with its exception
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Update  User Login data with id User, created Date
        /// </summary>
		/// <param name="idUser"> Id User</param>
		/// <param name="createdDate"> Created Date</param>
		/// <returns>The result of the operation</returns>
		public virtual OperationResult UpdateCreatedDate(Int64 idUser, DateTime createdDate)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate CreatedDate
			ValidationResult validationResult = this.ValidateCreatedDate( idUser, createdDate );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute Update
				operationResult = _UpdateCreatedDate(idUser, createdDate);
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
		protected virtual ValidationResult ValidateCreatedDate(Int64 idUser, DateTime createdDate)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateUserLogin'. 
				//The validator factory will create the validator object based on its key.
				IUserLoginValidator validator = (IUserLoginValidator)ValidatorFactory.Create(Keywords.UpdateUserLogin);
				
				//Execute validation process
				validationResult = validator.ValidateCreatedDate(idUser, createdDate);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to update CreatedDate
		protected virtual OperationResult _UpdateCreatedDate(Int64 idUser, DateTime createdDate)
		{
			//Create repository based on its Key name : 'Keywords.UpdateUserLogin'. 
			//The repository factory will create the repository object based on its key.
           	IUpdateUserLoginRepository repository = (IUpdateUserLoginRepository)RepositoryFactory.Create(Keywords.UpdateUserLogin);
            try
            {
            	//Execute UpdateCreatedDate
                repository.UpdateCreatedDate(idUser, createdDate);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
            	//Return false if error along with its exception
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Update  User Login data with id User, application I D
        /// </summary>
		/// <param name="idUser"> Id User</param>
		/// <param name="applicationID"> Application I D</param>
		/// <returns>The result of the operation</returns>
		public virtual OperationResult UpdateApplicationID(Int64 idUser, string applicationID)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate ApplicationID
			ValidationResult validationResult = this.ValidateApplicationID( idUser, applicationID );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute Update
				operationResult = _UpdateApplicationID(idUser, applicationID);
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
		protected virtual ValidationResult ValidateApplicationID(Int64 idUser, string applicationID)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateUserLogin'. 
				//The validator factory will create the validator object based on its key.
				IUserLoginValidator validator = (IUserLoginValidator)ValidatorFactory.Create(Keywords.UpdateUserLogin);
				
				//Execute validation process
				validationResult = validator.ValidateApplicationID(idUser, applicationID);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to update ApplicationID
		protected virtual OperationResult _UpdateApplicationID(Int64 idUser, string applicationID)
		{
			//Create repository based on its Key name : 'Keywords.UpdateUserLogin'. 
			//The repository factory will create the repository object based on its key.
           	IUpdateUserLoginRepository repository = (IUpdateUserLoginRepository)RepositoryFactory.Create(Keywords.UpdateUserLogin);
            try
            {
            	//Execute UpdateApplicationID
                repository.UpdateApplicationID(idUser, applicationID);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
            	//Return false if error along with its exception
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Update  User Login data with id User, is Active
        /// </summary>
		/// <param name="idUser"> Id User</param>
		/// <param name="isActive"> Is Active</param>
		/// <returns>The result of the operation</returns>
		public virtual OperationResult UpdateIsActive(Int64 idUser, Int16 isActive)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate 
			ValidationResult validationResult = this.ValidateIsActive( idUser, isActive );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute Update
				operationResult = _UpdateIsActive(idUser, isActive);
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
		protected virtual ValidationResult ValidateIsActive(Int64 idUser, Int16 isActive)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateUserLogin'. 
				//The validator factory will create the validator object based on its key.
				IUserLoginValidator validator = (IUserLoginValidator)ValidatorFactory.Create(Keywords.UpdateUserLogin);
				
				//Execute validation process
				validationResult = validator.ValidateIsActive(idUser, isActive);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to update 
		protected virtual OperationResult _UpdateIsActive(Int64 idUser, Int16 isActive)
		{
			//Create repository based on its Key name : 'Keywords.UpdateUserLogin'. 
			//The repository factory will create the repository object based on its key.
           	IUpdateUserLoginRepository repository = (IUpdateUserLoginRepository)RepositoryFactory.Create(Keywords.UpdateUserLogin);
            try
            {
            	//Execute UpdateIsActive
                repository.UpdateIsActive(idUser, isActive);
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