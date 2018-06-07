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
    /// Business Service for Language module.
    /// </summary>
    public class DeleteLanguageBusinessService : BaseBusinessService<Language>, IDeleteLanguageBusinessService
    {
        class Keywords
        {
            public static string DeleteLanguage = "Delete.Common.Resources.Language";
        }
        
        public DeleteLanguageBusinessService(string repoKey) : base(repoKey)
        {
        }
        
        public DeleteLanguageBusinessService()
        {
            this.RepoKey = Keywords.DeleteLanguage;
        }

        /// <summary>
        /// Delete  Language data by language I D
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
				//Create Validator based on its Key name : 'Keywords.UpdateLanguage'. 
				//The validator factory will create the validator object based on its key.
				ILanguageValidator validator = (ILanguageValidator)ValidatorFactory.Create(Keywords.DeleteLanguage);
				
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
			//Create repository based on its Key name : 'Keywords.DeleteLanguage'. 
			//The repository factory will create the repository object based on its key. 
            IDeleteLanguageRepository repository = (IDeleteLanguageRepository)RepositoryFactory.Create(Keywords.DeleteLanguage);
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

        /// <summary>
        /// Delete  Language data by language Name
        /// </summary>
		/// <param name="languageName"> Language Name</param>
		/// <returns>The result of the operation</returns>
		public OperationResult DeleteByLanguageName(string languageName)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate LanguageName
			ValidationResult validationResult = this.ValidateLanguageName( languageName );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute delete
				operationResult = this._DeleteByLanguageName(languageName);
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
		
		//Validate LanguageName
		protected virtual ValidationResult ValidateLanguageName(string languageName)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateLanguage'. 
				//The validator factory will create the validator object based on its key.
				ILanguageValidator validator = (ILanguageValidator)ValidatorFactory.Create(Keywords.DeleteLanguage);
				
				//Execute validation process
				validationResult = validator.ValidateLanguageName(languageName);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to delete LanguageName
		protected virtual OperationResult _DeleteByLanguageName(string languageName)
		{
			//Create repository based on its Key name : 'Keywords.DeleteLanguage'. 
			//The repository factory will create the repository object based on its key. 
            IDeleteLanguageRepository repository = (IDeleteLanguageRepository)RepositoryFactory.Create(Keywords.DeleteLanguage);
            try
            {
            	//Execute DeleteByLanguageName
                repository.DeleteByLanguageName(languageName);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Delete  Language data by language Desc
        /// </summary>
		/// <param name="languageDesc"> Language Desc</param>
		/// <returns>The result of the operation</returns>
		public OperationResult DeleteByLanguageDesc(string languageDesc)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate LanguageDesc
			ValidationResult validationResult = this.ValidateLanguageDesc( languageDesc );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute delete
				operationResult = this._DeleteByLanguageDesc(languageDesc);
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
		
		//Validate LanguageDesc
		protected virtual ValidationResult ValidateLanguageDesc(string languageDesc)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateLanguage'. 
				//The validator factory will create the validator object based on its key.
				ILanguageValidator validator = (ILanguageValidator)ValidatorFactory.Create(Keywords.DeleteLanguage);
				
				//Execute validation process
				validationResult = validator.ValidateLanguageDesc(languageDesc);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to delete LanguageDesc
		protected virtual OperationResult _DeleteByLanguageDesc(string languageDesc)
		{
			//Create repository based on its Key name : 'Keywords.DeleteLanguage'. 
			//The repository factory will create the repository object based on its key. 
            IDeleteLanguageRepository repository = (IDeleteLanguageRepository)RepositoryFactory.Create(Keywords.DeleteLanguage);
            try
            {
            	//Execute DeleteByLanguageDesc
                repository.DeleteByLanguageDesc(languageDesc);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}


    }
 }