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
    public class DeleteCountryBusinessService : BaseBusinessService<Country>, IDeleteCountryBusinessService
    {
        class Keywords
        {
            public static string DeleteCountry = "Delete.Common.Resources.Country";
        }
        
        public DeleteCountryBusinessService(string repoKey) : base(repoKey)
        {
        }
        
        public DeleteCountryBusinessService()
        {
            this.RepoKey = Keywords.DeleteCountry;
        }

        /// <summary>
        /// Delete  Country data by country Name
        /// </summary>
		/// <param name="countryName"> Country Name</param>
		/// <returns>The result of the operation</returns>
		public OperationResult DeleteByCountryName(string countryName)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate CountryName
			ValidationResult validationResult = this.ValidateCountryName( countryName );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute delete
				operationResult = this._DeleteByCountryName(countryName);
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
		protected virtual ValidationResult ValidateCountryName(string countryName)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateCountry'. 
				//The validator factory will create the validator object based on its key.
				ICountryValidator validator = (ICountryValidator)ValidatorFactory.Create(Keywords.DeleteCountry);
				
				//Execute validation process
				validationResult = validator.ValidateCountryName(countryName);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to delete CountryName
		protected virtual OperationResult _DeleteByCountryName(string countryName)
		{
			//Create repository based on its Key name : 'Keywords.DeleteCountry'. 
			//The repository factory will create the repository object based on its key. 
            IDeleteCountryRepository repository = (IDeleteCountryRepository)RepositoryFactory.Create(Keywords.DeleteCountry);
            try
            {
            	//Execute DeleteByCountryName
                repository.DeleteByCountryName(countryName);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Delete  Country data by country Desc
        /// </summary>
		/// <param name="countryDesc"> Country Desc</param>
		/// <returns>The result of the operation</returns>
		public OperationResult DeleteByCountryDesc(string countryDesc)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate CountryDesc
			ValidationResult validationResult = this.ValidateCountryDesc( countryDesc );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute delete
				operationResult = this._DeleteByCountryDesc(countryDesc);
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
		protected virtual ValidationResult ValidateCountryDesc(string countryDesc)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateCountry'. 
				//The validator factory will create the validator object based on its key.
				ICountryValidator validator = (ICountryValidator)ValidatorFactory.Create(Keywords.DeleteCountry);
				
				//Execute validation process
				validationResult = validator.ValidateCountryDesc(countryDesc);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to delete CountryDesc
		protected virtual OperationResult _DeleteByCountryDesc(string countryDesc)
		{
			//Create repository based on its Key name : 'Keywords.DeleteCountry'. 
			//The repository factory will create the repository object based on its key. 
            IDeleteCountryRepository repository = (IDeleteCountryRepository)RepositoryFactory.Create(Keywords.DeleteCountry);
            try
            {
            	//Execute DeleteByCountryDesc
                repository.DeleteByCountryDesc(countryDesc);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Delete  Country data by country Flag Icon
        /// </summary>
		/// <param name="countryFlagIcon"> Country Flag Icon</param>
		/// <returns>The result of the operation</returns>
		public OperationResult DeleteByCountryFlagIcon(string countryFlagIcon)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate CountryFlagIcon
			ValidationResult validationResult = this.ValidateCountryFlagIcon( countryFlagIcon );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute delete
				operationResult = this._DeleteByCountryFlagIcon(countryFlagIcon);
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
		protected virtual ValidationResult ValidateCountryFlagIcon(string countryFlagIcon)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateCountry'. 
				//The validator factory will create the validator object based on its key.
				ICountryValidator validator = (ICountryValidator)ValidatorFactory.Create(Keywords.DeleteCountry);
				
				//Execute validation process
				validationResult = validator.ValidateCountryFlagIcon(countryFlagIcon);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to delete CountryFlagIcon
		protected virtual OperationResult _DeleteByCountryFlagIcon(string countryFlagIcon)
		{
			//Create repository based on its Key name : 'Keywords.DeleteCountry'. 
			//The repository factory will create the repository object based on its key. 
            IDeleteCountryRepository repository = (IDeleteCountryRepository)RepositoryFactory.Create(Keywords.DeleteCountry);
            try
            {
            	//Execute DeleteByCountryFlagIcon
                repository.DeleteByCountryFlagIcon(countryFlagIcon);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Delete  Country data by is Active
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
				//Create Validator based on its Key name : 'Keywords.UpdateCountry'. 
				//The validator factory will create the validator object based on its key.
				ICountryValidator validator = (ICountryValidator)ValidatorFactory.Create(Keywords.DeleteCountry);
				
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
			//Create repository based on its Key name : 'Keywords.DeleteCountry'. 
			//The repository factory will create the repository object based on its key. 
            IDeleteCountryRepository repository = (IDeleteCountryRepository)RepositoryFactory.Create(Keywords.DeleteCountry);
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