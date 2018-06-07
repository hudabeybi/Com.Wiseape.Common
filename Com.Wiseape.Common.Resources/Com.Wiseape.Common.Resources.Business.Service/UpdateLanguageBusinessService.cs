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
    public class UpdateLanguageBusinessService : BaseBusinessService<Language>, IUpdateLanguageBusinessService
    {
        class Keywords
        {
            public static string UpdateLanguage = "Update.Common.Resources.Language";
        }
        
        public UpdateLanguageBusinessService(string repoKey) : base(repoKey)
        {
        }
        
        public UpdateLanguageBusinessService()
        {
            this.RepoKey = Keywords.UpdateLanguage;
        }


        /// <summary>
        /// Update  Language data with id Language, language I D
        /// </summary>
		/// <param name="idLanguage"> Id Language</param>
		/// <param name="languageID"> Language I D</param>
		/// <returns>The result of the operation</returns>
		public virtual OperationResult UpdateLanguageID(Int16 idLanguage, string languageID)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate LanguageID
			ValidationResult validationResult = this.ValidateLanguageID( idLanguage, languageID );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute Update
				operationResult = _UpdateLanguageID(idLanguage, languageID);
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
		protected virtual ValidationResult ValidateLanguageID(Int16 idLanguage, string languageID)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateLanguage'. 
				//The validator factory will create the validator object based on its key.
				ILanguageValidator validator = (ILanguageValidator)ValidatorFactory.Create(Keywords.UpdateLanguage);
				
				//Execute validation process
				validationResult = validator.ValidateLanguageID(idLanguage, languageID);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to update LanguageID
		protected virtual OperationResult _UpdateLanguageID(Int16 idLanguage, string languageID)
		{
			//Create repository based on its Key name : 'Keywords.UpdateLanguage'. 
			//The repository factory will create the repository object based on its key.
           	IUpdateLanguageRepository repository = (IUpdateLanguageRepository)RepositoryFactory.Create(Keywords.UpdateLanguage);
            try
            {
            	//Execute UpdateLanguageID
                repository.UpdateLanguageID(idLanguage, languageID);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
            	//Return false if error along with its exception
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Update  Language data with id Language, language Name
        /// </summary>
		/// <param name="idLanguage"> Id Language</param>
		/// <param name="languageName"> Language Name</param>
		/// <returns>The result of the operation</returns>
		public virtual OperationResult UpdateLanguageName(Int16 idLanguage, string languageName)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate LanguageName
			ValidationResult validationResult = this.ValidateLanguageName( idLanguage, languageName );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute Update
				operationResult = _UpdateLanguageName(idLanguage, languageName);
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
		protected virtual ValidationResult ValidateLanguageName(Int16 idLanguage, string languageName)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateLanguage'. 
				//The validator factory will create the validator object based on its key.
				ILanguageValidator validator = (ILanguageValidator)ValidatorFactory.Create(Keywords.UpdateLanguage);
				
				//Execute validation process
				validationResult = validator.ValidateLanguageName(idLanguage, languageName);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to update LanguageName
		protected virtual OperationResult _UpdateLanguageName(Int16 idLanguage, string languageName)
		{
			//Create repository based on its Key name : 'Keywords.UpdateLanguage'. 
			//The repository factory will create the repository object based on its key.
           	IUpdateLanguageRepository repository = (IUpdateLanguageRepository)RepositoryFactory.Create(Keywords.UpdateLanguage);
            try
            {
            	//Execute UpdateLanguageName
                repository.UpdateLanguageName(idLanguage, languageName);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
            	//Return false if error along with its exception
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Update  Language data with id Language, language Desc
        /// </summary>
		/// <param name="idLanguage"> Id Language</param>
		/// <param name="languageDesc"> Language Desc</param>
		/// <returns>The result of the operation</returns>
		public virtual OperationResult UpdateLanguageDesc(Int16 idLanguage, string languageDesc)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate LanguageDesc
			ValidationResult validationResult = this.ValidateLanguageDesc( idLanguage, languageDesc );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute Update
				operationResult = _UpdateLanguageDesc(idLanguage, languageDesc);
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
		protected virtual ValidationResult ValidateLanguageDesc(Int16 idLanguage, string languageDesc)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateLanguage'. 
				//The validator factory will create the validator object based on its key.
				ILanguageValidator validator = (ILanguageValidator)ValidatorFactory.Create(Keywords.UpdateLanguage);
				
				//Execute validation process
				validationResult = validator.ValidateLanguageDesc(idLanguage, languageDesc);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to update LanguageDesc
		protected virtual OperationResult _UpdateLanguageDesc(Int16 idLanguage, string languageDesc)
		{
			//Create repository based on its Key name : 'Keywords.UpdateLanguage'. 
			//The repository factory will create the repository object based on its key.
           	IUpdateLanguageRepository repository = (IUpdateLanguageRepository)RepositoryFactory.Create(Keywords.UpdateLanguage);
            try
            {
            	//Execute UpdateLanguageDesc
                repository.UpdateLanguageDesc(idLanguage, languageDesc);
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