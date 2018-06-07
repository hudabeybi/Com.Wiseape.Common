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
    /// Business Service for Country module.
    /// </summary>
    public class UpdateCountryBusinessService : BaseBusinessService<Country>, IUpdateCountryBusinessService
    {
        class Keywords
        {
            public static string UpdateCountry = "Update.Common.Resources.Country";
        }
        
        public UpdateCountryBusinessService(string repoKey) : base(repoKey)
        {
        }
        
        public UpdateCountryBusinessService()
        {
            this.RepoKey = Keywords.UpdateCountry;
        }


        /// <summary>
        /// Update  Country data with id Country, country Name
        /// </summary>
		/// <param name="idCountry"> Id Country</param>
		/// <param name="countryName"> Country Name</param>
		/// <returns>The result of the operation</returns>
		public virtual OperationResult UpdateCountryName(Int16 idCountry, string countryName)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate CountryName
			ValidationResult validationResult = this.ValidateCountryName( idCountry, countryName );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute Update
				operationResult = _UpdateCountryName(idCountry, countryName);
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
		
		//Validate CountryName
		protected virtual ValidationResult ValidateCountryName(Int16 idCountry, string countryName)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateCountry'. 
				//The validator factory will create the validator object based on its key.
				ICountryValidator validator = (ICountryValidator)ValidatorFactory.Create(Keywords.UpdateCountry);
				
				//Execute validation process
				validationResult = validator.ValidateCountryName(idCountry, countryName);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to update CountryName
		protected virtual OperationResult _UpdateCountryName(Int16 idCountry, string countryName)
		{
			//Create repository based on its Key name : 'Keywords.UpdateCountry'. 
			//The repository factory will create the repository object based on its key.
           	IUpdateCountryRepository repository = (IUpdateCountryRepository)RepositoryFactory.Create(Keywords.UpdateCountry);
            try
            {
            	//Execute UpdateCountryName
                repository.UpdateCountryName(idCountry, countryName);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
            	//Return false if error along with its exception
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Update  Country data with id Country, country Desc
        /// </summary>
		/// <param name="idCountry"> Id Country</param>
		/// <param name="countryDesc"> Country Desc</param>
		/// <returns>The result of the operation</returns>
		public virtual OperationResult UpdateCountryDesc(Int16 idCountry, string countryDesc)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate CountryDesc
			ValidationResult validationResult = this.ValidateCountryDesc( idCountry, countryDesc );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute Update
				operationResult = _UpdateCountryDesc(idCountry, countryDesc);
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
		
		//Validate CountryDesc
		protected virtual ValidationResult ValidateCountryDesc(Int16 idCountry, string countryDesc)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateCountry'. 
				//The validator factory will create the validator object based on its key.
				ICountryValidator validator = (ICountryValidator)ValidatorFactory.Create(Keywords.UpdateCountry);
				
				//Execute validation process
				validationResult = validator.ValidateCountryDesc(idCountry, countryDesc);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to update CountryDesc
		protected virtual OperationResult _UpdateCountryDesc(Int16 idCountry, string countryDesc)
		{
			//Create repository based on its Key name : 'Keywords.UpdateCountry'. 
			//The repository factory will create the repository object based on its key.
           	IUpdateCountryRepository repository = (IUpdateCountryRepository)RepositoryFactory.Create(Keywords.UpdateCountry);
            try
            {
            	//Execute UpdateCountryDesc
                repository.UpdateCountryDesc(idCountry, countryDesc);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
            	//Return false if error along with its exception
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Update  Country data with id Country, country Flag Icon
        /// </summary>
		/// <param name="idCountry"> Id Country</param>
		/// <param name="countryFlagIcon"> Country Flag Icon</param>
		/// <returns>The result of the operation</returns>
		public virtual OperationResult UpdateCountryFlagIcon(Int16 idCountry, string countryFlagIcon)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate CountryFlagIcon
			ValidationResult validationResult = this.ValidateCountryFlagIcon( idCountry, countryFlagIcon );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute Update
				operationResult = _UpdateCountryFlagIcon(idCountry, countryFlagIcon);
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
		
		//Validate CountryFlagIcon
		protected virtual ValidationResult ValidateCountryFlagIcon(Int16 idCountry, string countryFlagIcon)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateCountry'. 
				//The validator factory will create the validator object based on its key.
				ICountryValidator validator = (ICountryValidator)ValidatorFactory.Create(Keywords.UpdateCountry);
				
				//Execute validation process
				validationResult = validator.ValidateCountryFlagIcon(idCountry, countryFlagIcon);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to update CountryFlagIcon
		protected virtual OperationResult _UpdateCountryFlagIcon(Int16 idCountry, string countryFlagIcon)
		{
			//Create repository based on its Key name : 'Keywords.UpdateCountry'. 
			//The repository factory will create the repository object based on its key.
           	IUpdateCountryRepository repository = (IUpdateCountryRepository)RepositoryFactory.Create(Keywords.UpdateCountry);
            try
            {
            	//Execute UpdateCountryFlagIcon
                repository.UpdateCountryFlagIcon(idCountry, countryFlagIcon);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
            	//Return false if error along with its exception
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Update  Country data with id Country, is Active
        /// </summary>
		/// <param name="idCountry"> Id Country</param>
		/// <param name="isActive"> Is Active</param>
		/// <returns>The result of the operation</returns>
		public virtual OperationResult UpdateIsActive(Int16 idCountry, Int16 isActive)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate 
			ValidationResult validationResult = this.ValidateIsActive( idCountry, isActive );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute Update
				operationResult = _UpdateIsActive(idCountry, isActive);
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
		protected virtual ValidationResult ValidateIsActive(Int16 idCountry, Int16 isActive)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateCountry'. 
				//The validator factory will create the validator object based on its key.
				ICountryValidator validator = (ICountryValidator)ValidatorFactory.Create(Keywords.UpdateCountry);
				
				//Execute validation process
				validationResult = validator.ValidateIsActive(idCountry, isActive);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to update 
		protected virtual OperationResult _UpdateIsActive(Int16 idCountry, Int16 isActive)
		{
			//Create repository based on its Key name : 'Keywords.UpdateCountry'. 
			//The repository factory will create the repository object based on its key.
           	IUpdateCountryRepository repository = (IUpdateCountryRepository)RepositoryFactory.Create(Keywords.UpdateCountry);
            try
            {
            	//Execute UpdateIsActive
                repository.UpdateIsActive(idCountry, isActive);
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