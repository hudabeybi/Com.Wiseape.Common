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
    /// Business Service for LanguageKeyword module.
    /// </summary>
    public class DeleteLanguageKeywordBusinessService : BaseBusinessService<LanguageKeyword>, IDeleteLanguageKeywordBusinessService
    {
        class Keywords
        {
            public static string DeleteLanguageKeyword = "Delete.Common.Resources.LanguageKeyword";
        }
        
        public DeleteLanguageKeywordBusinessService(string repoKey) : base(repoKey)
        {
        }
        
        public DeleteLanguageKeywordBusinessService()
        {
            this.RepoKey = Keywords.DeleteLanguageKeyword;
        }

        /// <summary>
        /// Delete  Language Keyword data by keyword
        /// </summary>
		/// <param name="keyword"> Keyword</param>
		/// <returns>The result of the operation</returns>
		public OperationResult DeleteByKeyword(string keyword)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate Keyword
			ValidationResult validationResult = this.ValidateKeyword( keyword );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute delete
				operationResult = this._DeleteByKeyword(keyword);
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
		
		//Validate Keyword
		protected virtual ValidationResult ValidateKeyword(string keyword)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateLanguageKeyword'. 
				//The validator factory will create the validator object based on its key.
				ILanguageKeywordValidator validator = (ILanguageKeywordValidator)ValidatorFactory.Create(Keywords.DeleteLanguageKeyword);
				
				//Execute validation process
				validationResult = validator.ValidateKeyword(keyword);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to delete Keyword
		protected virtual OperationResult _DeleteByKeyword(string keyword)
		{
			//Create repository based on its Key name : 'Keywords.DeleteLanguageKeyword'. 
			//The repository factory will create the repository object based on its key. 
            IDeleteLanguageKeywordRepository repository = (IDeleteLanguageKeywordRepository)RepositoryFactory.Create(Keywords.DeleteLanguageKeyword);
            try
            {
            	//Execute DeleteByKeyword
                repository.DeleteByKeyword(keyword);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Delete  Language Keyword data by keyword Text
        /// </summary>
		/// <param name="keywordText"> Keyword Text</param>
		/// <returns>The result of the operation</returns>
		public OperationResult DeleteByKeywordText(string keywordText)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate KeywordText
			ValidationResult validationResult = this.ValidateKeywordText( keywordText );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute delete
				operationResult = this._DeleteByKeywordText(keywordText);
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
		
		//Validate KeywordText
		protected virtual ValidationResult ValidateKeywordText(string keywordText)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateLanguageKeyword'. 
				//The validator factory will create the validator object based on its key.
				ILanguageKeywordValidator validator = (ILanguageKeywordValidator)ValidatorFactory.Create(Keywords.DeleteLanguageKeyword);
				
				//Execute validation process
				validationResult = validator.ValidateKeywordText(keywordText);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to delete KeywordText
		protected virtual OperationResult _DeleteByKeywordText(string keywordText)
		{
			//Create repository based on its Key name : 'Keywords.DeleteLanguageKeyword'. 
			//The repository factory will create the repository object based on its key. 
            IDeleteLanguageKeywordRepository repository = (IDeleteLanguageKeywordRepository)RepositoryFactory.Create(Keywords.DeleteLanguageKeyword);
            try
            {
            	//Execute DeleteByKeywordText
                repository.DeleteByKeywordText(keywordText);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Delete  Language Keyword data by language I D
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
				//Create Validator based on its Key name : 'Keywords.UpdateLanguageKeyword'. 
				//The validator factory will create the validator object based on its key.
				ILanguageKeywordValidator validator = (ILanguageKeywordValidator)ValidatorFactory.Create(Keywords.DeleteLanguageKeyword);
				
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
			//Create repository based on its Key name : 'Keywords.DeleteLanguageKeyword'. 
			//The repository factory will create the repository object based on its key. 
            IDeleteLanguageKeywordRepository repository = (IDeleteLanguageKeywordRepository)RepositoryFactory.Create(Keywords.DeleteLanguageKeyword);
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