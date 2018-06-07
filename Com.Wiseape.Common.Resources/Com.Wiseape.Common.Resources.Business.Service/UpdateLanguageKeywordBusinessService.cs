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
    public class UpdateLanguageKeywordBusinessService : BaseBusinessService<LanguageKeyword>, IUpdateLanguageKeywordBusinessService
    {
        class Keywords
        {
            public static string UpdateLanguageKeyword = "Update.Common.Resources.LanguageKeyword";
        }
        
        public UpdateLanguageKeywordBusinessService(string repoKey) : base(repoKey)
        {
        }
        
        public UpdateLanguageKeywordBusinessService()
        {
            this.RepoKey = Keywords.UpdateLanguageKeyword;
        }


        /// <summary>
        /// Update  Language Keyword data with id Keyword, keyword
        /// </summary>
		/// <param name="idKeyword"> Id Keyword</param>
		/// <param name="keyword"> Keyword</param>
		/// <returns>The result of the operation</returns>
		public virtual OperationResult UpdateKeyword(Int64 idKeyword, string keyword)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate Keyword
			ValidationResult validationResult = this.ValidateKeyword( idKeyword, keyword );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute Update
				operationResult = _UpdateKeyword(idKeyword, keyword);
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
		protected virtual ValidationResult ValidateKeyword(Int64 idKeyword, string keyword)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateLanguageKeyword'. 
				//The validator factory will create the validator object based on its key.
				ILanguageKeywordValidator validator = (ILanguageKeywordValidator)ValidatorFactory.Create(Keywords.UpdateLanguageKeyword);
				
				//Execute validation process
				validationResult = validator.ValidateKeyword(idKeyword, keyword);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to update Keyword
		protected virtual OperationResult _UpdateKeyword(Int64 idKeyword, string keyword)
		{
			//Create repository based on its Key name : 'Keywords.UpdateLanguageKeyword'. 
			//The repository factory will create the repository object based on its key.
           	IUpdateLanguageKeywordRepository repository = (IUpdateLanguageKeywordRepository)RepositoryFactory.Create(Keywords.UpdateLanguageKeyword);
            try
            {
            	//Execute UpdateKeyword
                repository.UpdateKeyword(idKeyword, keyword);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
            	//Return false if error along with its exception
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Update  Language Keyword data with id Keyword, keyword Text
        /// </summary>
		/// <param name="idKeyword"> Id Keyword</param>
		/// <param name="keywordText"> Keyword Text</param>
		/// <returns>The result of the operation</returns>
		public virtual OperationResult UpdateKeywordText(Int64 idKeyword, string keywordText)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate KeywordText
			ValidationResult validationResult = this.ValidateKeywordText( idKeyword, keywordText );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute Update
				operationResult = _UpdateKeywordText(idKeyword, keywordText);
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
		protected virtual ValidationResult ValidateKeywordText(Int64 idKeyword, string keywordText)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateLanguageKeyword'. 
				//The validator factory will create the validator object based on its key.
				ILanguageKeywordValidator validator = (ILanguageKeywordValidator)ValidatorFactory.Create(Keywords.UpdateLanguageKeyword);
				
				//Execute validation process
				validationResult = validator.ValidateKeywordText(idKeyword, keywordText);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to update KeywordText
		protected virtual OperationResult _UpdateKeywordText(Int64 idKeyword, string keywordText)
		{
			//Create repository based on its Key name : 'Keywords.UpdateLanguageKeyword'. 
			//The repository factory will create the repository object based on its key.
           	IUpdateLanguageKeywordRepository repository = (IUpdateLanguageKeywordRepository)RepositoryFactory.Create(Keywords.UpdateLanguageKeyword);
            try
            {
            	//Execute UpdateKeywordText
                repository.UpdateKeywordText(idKeyword, keywordText);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
            	//Return false if error along with its exception
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Update  Language Keyword data with id Keyword, language I D
        /// </summary>
		/// <param name="idKeyword"> Id Keyword</param>
		/// <param name="languageID"> Language I D</param>
		/// <returns>The result of the operation</returns>
		public virtual OperationResult UpdateLanguageID(Int64 idKeyword, string languageID)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate LanguageID
			ValidationResult validationResult = this.ValidateLanguageID( idKeyword, languageID );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute Update
				operationResult = _UpdateLanguageID(idKeyword, languageID);
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
		protected virtual ValidationResult ValidateLanguageID(Int64 idKeyword, string languageID)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateLanguageKeyword'. 
				//The validator factory will create the validator object based on its key.
				ILanguageKeywordValidator validator = (ILanguageKeywordValidator)ValidatorFactory.Create(Keywords.UpdateLanguageKeyword);
				
				//Execute validation process
				validationResult = validator.ValidateLanguageID(idKeyword, languageID);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to update LanguageID
		protected virtual OperationResult _UpdateLanguageID(Int64 idKeyword, string languageID)
		{
			//Create repository based on its Key name : 'Keywords.UpdateLanguageKeyword'. 
			//The repository factory will create the repository object based on its key.
           	IUpdateLanguageKeywordRepository repository = (IUpdateLanguageKeywordRepository)RepositoryFactory.Create(Keywords.UpdateLanguageKeyword);
            try
            {
            	//Execute UpdateLanguageID
                repository.UpdateLanguageID(idKeyword, languageID);
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