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
    public class UpdateGenderBusinessService : BaseBusinessService<Gender>, IUpdateGenderBusinessService
    {
        class Keywords
        {
            public static string UpdateGender = "Update.Common.Resources.Gender";
        }
        
        public UpdateGenderBusinessService(string repoKey) : base(repoKey)
        {
        }
        
        public UpdateGenderBusinessService()
        {
            this.RepoKey = Keywords.UpdateGender;
        }


        /// <summary>
        /// Update  Gender data with id Gender, gender Name
        /// </summary>
		/// <param name="idGender"> Id Gender</param>
		/// <param name="genderName"> Gender Name</param>
		/// <returns>The result of the operation</returns>
		public virtual OperationResult UpdateGenderName(Int16 idGender, string genderName)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate GenderName
			ValidationResult validationResult = this.ValidateGenderName( idGender, genderName );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute Update
				operationResult = _UpdateGenderName(idGender, genderName);
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
		protected virtual ValidationResult ValidateGenderName(Int16 idGender, string genderName)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateGender'. 
				//The validator factory will create the validator object based on its key.
				IGenderValidator validator = (IGenderValidator)ValidatorFactory.Create(Keywords.UpdateGender);
				
				//Execute validation process
				validationResult = validator.ValidateGenderName(idGender, genderName);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to update GenderName
		protected virtual OperationResult _UpdateGenderName(Int16 idGender, string genderName)
		{
			//Create repository based on its Key name : 'Keywords.UpdateGender'. 
			//The repository factory will create the repository object based on its key.
           	IUpdateGenderRepository repository = (IUpdateGenderRepository)RepositoryFactory.Create(Keywords.UpdateGender);
            try
            {
            	//Execute UpdateGenderName
                repository.UpdateGenderName(idGender, genderName);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
            	//Return false if error along with its exception
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Update  Gender data with id Gender, gender Icon
        /// </summary>
		/// <param name="idGender"> Id Gender</param>
		/// <param name="genderIcon"> Gender Icon</param>
		/// <returns>The result of the operation</returns>
		public virtual OperationResult UpdateGenderIcon(Int16 idGender, string genderIcon)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate GenderIcon
			ValidationResult validationResult = this.ValidateGenderIcon( idGender, genderIcon );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute Update
				operationResult = _UpdateGenderIcon(idGender, genderIcon);
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
		protected virtual ValidationResult ValidateGenderIcon(Int16 idGender, string genderIcon)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateGender'. 
				//The validator factory will create the validator object based on its key.
				IGenderValidator validator = (IGenderValidator)ValidatorFactory.Create(Keywords.UpdateGender);
				
				//Execute validation process
				validationResult = validator.ValidateGenderIcon(idGender, genderIcon);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to update GenderIcon
		protected virtual OperationResult _UpdateGenderIcon(Int16 idGender, string genderIcon)
		{
			//Create repository based on its Key name : 'Keywords.UpdateGender'. 
			//The repository factory will create the repository object based on its key.
           	IUpdateGenderRepository repository = (IUpdateGenderRepository)RepositoryFactory.Create(Keywords.UpdateGender);
            try
            {
            	//Execute UpdateGenderIcon
                repository.UpdateGenderIcon(idGender, genderIcon);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
            	//Return false if error along with its exception
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Update  Gender data with id Gender, language I D
        /// </summary>
		/// <param name="idGender"> Id Gender</param>
		/// <param name="languageID"> Language I D</param>
		/// <returns>The result of the operation</returns>
		public virtual OperationResult UpdateLanguageID(Int16 idGender, string languageID)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate LanguageID
			ValidationResult validationResult = this.ValidateLanguageID( idGender, languageID );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute Update
				operationResult = _UpdateLanguageID(idGender, languageID);
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
		protected virtual ValidationResult ValidateLanguageID(Int16 idGender, string languageID)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateGender'. 
				//The validator factory will create the validator object based on its key.
				IGenderValidator validator = (IGenderValidator)ValidatorFactory.Create(Keywords.UpdateGender);
				
				//Execute validation process
				validationResult = validator.ValidateLanguageID(idGender, languageID);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to update LanguageID
		protected virtual OperationResult _UpdateLanguageID(Int16 idGender, string languageID)
		{
			//Create repository based on its Key name : 'Keywords.UpdateGender'. 
			//The repository factory will create the repository object based on its key.
           	IUpdateGenderRepository repository = (IUpdateGenderRepository)RepositoryFactory.Create(Keywords.UpdateGender);
            try
            {
            	//Execute UpdateLanguageID
                repository.UpdateLanguageID(idGender, languageID);
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