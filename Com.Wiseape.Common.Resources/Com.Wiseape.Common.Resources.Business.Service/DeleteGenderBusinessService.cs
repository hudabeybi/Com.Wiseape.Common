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
    /// Business Service for Gender module.
    /// </summary>
    public class DeleteGenderBusinessService : BaseBusinessService<Gender>, IDeleteGenderBusinessService
    {
        class Keywords
        {
            public static string DeleteGender = "Delete.Common.Resources.Gender";
        }
        
        public DeleteGenderBusinessService(string repoKey) : base(repoKey)
        {
        }
        
        public DeleteGenderBusinessService()
        {
            this.RepoKey = Keywords.DeleteGender;
        }

        /// <summary>
        /// Delete  Gender data by gender Name
        /// </summary>
		/// <param name="genderName"> Gender Name</param>
		/// <returns>The result of the operation</returns>
		public OperationResult DeleteByGenderName(string genderName)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate GenderName
			ValidationResult validationResult = this.ValidateGenderName( genderName );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute delete
				operationResult = this._DeleteByGenderName(genderName);
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
		
		//Validate GenderName
		protected virtual ValidationResult ValidateGenderName(string genderName)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateGender'. 
				//The validator factory will create the validator object based on its key.
				IGenderValidator validator = (IGenderValidator)ValidatorFactory.Create(Keywords.DeleteGender);
				
				//Execute validation process
				validationResult = validator.ValidateGenderName(genderName);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to delete GenderName
		protected virtual OperationResult _DeleteByGenderName(string genderName)
		{
			//Create repository based on its Key name : 'Keywords.DeleteGender'. 
			//The repository factory will create the repository object based on its key. 
            IDeleteGenderRepository repository = (IDeleteGenderRepository)RepositoryFactory.Create(Keywords.DeleteGender);
            try
            {
            	//Execute DeleteByGenderName
                repository.DeleteByGenderName(genderName);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Delete  Gender data by gender Icon
        /// </summary>
		/// <param name="genderIcon"> Gender Icon</param>
		/// <returns>The result of the operation</returns>
		public OperationResult DeleteByGenderIcon(string genderIcon)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate GenderIcon
			ValidationResult validationResult = this.ValidateGenderIcon( genderIcon );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute delete
				operationResult = this._DeleteByGenderIcon(genderIcon);
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
		
		//Validate GenderIcon
		protected virtual ValidationResult ValidateGenderIcon(string genderIcon)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateGender'. 
				//The validator factory will create the validator object based on its key.
				IGenderValidator validator = (IGenderValidator)ValidatorFactory.Create(Keywords.DeleteGender);
				
				//Execute validation process
				validationResult = validator.ValidateGenderIcon(genderIcon);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to delete GenderIcon
		protected virtual OperationResult _DeleteByGenderIcon(string genderIcon)
		{
			//Create repository based on its Key name : 'Keywords.DeleteGender'. 
			//The repository factory will create the repository object based on its key. 
            IDeleteGenderRepository repository = (IDeleteGenderRepository)RepositoryFactory.Create(Keywords.DeleteGender);
            try
            {
            	//Execute DeleteByGenderIcon
                repository.DeleteByGenderIcon(genderIcon);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Delete  Gender data by language I D
        /// </summary>
		/// <param name="languageID"> Language I D</param>
		/// <returns>The result of the operation</returns>
		public OperationResult DeleteByLanguageID(string languageID)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate LanguageID
			ValidationResult validationResult = this.ValidateLanguageID( languageID );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute delete
				operationResult = this._DeleteByLanguageID(languageID);
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
		
		//Validate LanguageID
		protected virtual ValidationResult ValidateLanguageID(string languageID)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateGender'. 
				//The validator factory will create the validator object based on its key.
				IGenderValidator validator = (IGenderValidator)ValidatorFactory.Create(Keywords.DeleteGender);
				
				//Execute validation process
				validationResult = validator.ValidateLanguageID(languageID);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to delete LanguageID
		protected virtual OperationResult _DeleteByLanguageID(string languageID)
		{
			//Create repository based on its Key name : 'Keywords.DeleteGender'. 
			//The repository factory will create the repository object based on its key. 
            IDeleteGenderRepository repository = (IDeleteGenderRepository)RepositoryFactory.Create(Keywords.DeleteGender);
            try
            {
            	//Execute DeleteByLanguageID
                repository.DeleteByLanguageID(languageID);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}


    }
 }