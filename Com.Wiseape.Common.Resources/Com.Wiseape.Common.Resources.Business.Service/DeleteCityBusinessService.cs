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
    /// Business Service for City module.
    /// </summary>
    public class DeleteCityBusinessService : BaseBusinessService<City>, IDeleteCityBusinessService
    {
        class Keywords
        {
            public static string DeleteCity = "Delete.Common.Resources.City";
        }
        
        public DeleteCityBusinessService(string repoKey) : base(repoKey)
        {
        }
        
        public DeleteCityBusinessService()
        {
            this.RepoKey = Keywords.DeleteCity;
        }

        /// <summary>
        /// Delete  City data by city Name
        /// </summary>
		/// <param name="cityName"> City Name</param>
		/// <returns>The result of the operation</returns>
		public OperationResult DeleteByCityName(string cityName)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate CityName
			ValidationResult validationResult = this.ValidateCityName( cityName );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute delete
				operationResult = this._DeleteByCityName(cityName);
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
		
		//Validate CityName
		protected virtual ValidationResult ValidateCityName(string cityName)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateCity'. 
				//The validator factory will create the validator object based on its key.
				ICityValidator validator = (ICityValidator)ValidatorFactory.Create(Keywords.DeleteCity);
				
				//Execute validation process
				validationResult = validator.ValidateCityName(cityName);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to delete CityName
		protected virtual OperationResult _DeleteByCityName(string cityName)
		{
			//Create repository based on its Key name : 'Keywords.DeleteCity'. 
			//The repository factory will create the repository object based on its key. 
            IDeleteCityRepository repository = (IDeleteCityRepository)RepositoryFactory.Create(Keywords.DeleteCity);
            try
            {
            	//Execute DeleteByCityName
                repository.DeleteByCityName(cityName);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Delete  City data by city Location Lon
        /// </summary>
		/// <param name="cityLocationLon"> City Location Lon</param>
		/// <returns>The result of the operation</returns>
		public OperationResult DeleteByCityLocationLon(float cityLocationLon)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate CityLocationLon
			ValidationResult validationResult = this.ValidateCityLocationLon( cityLocationLon );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute delete
				operationResult = this._DeleteByCityLocationLon(cityLocationLon);
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
		
		//Validate CityLocationLon
		protected virtual ValidationResult ValidateCityLocationLon(float cityLocationLon)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateCity'. 
				//The validator factory will create the validator object based on its key.
				ICityValidator validator = (ICityValidator)ValidatorFactory.Create(Keywords.DeleteCity);
				
				//Execute validation process
				validationResult = validator.ValidateCityLocationLon(cityLocationLon);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to delete CityLocationLon
		protected virtual OperationResult _DeleteByCityLocationLon(float cityLocationLon)
		{
			//Create repository based on its Key name : 'Keywords.DeleteCity'. 
			//The repository factory will create the repository object based on its key. 
            IDeleteCityRepository repository = (IDeleteCityRepository)RepositoryFactory.Create(Keywords.DeleteCity);
            try
            {
            	//Execute DeleteByCityLocationLon
                repository.DeleteByCityLocationLon(cityLocationLon);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Delete  City data by city Location Lat
        /// </summary>
		/// <param name="cityLocationLat"> City Location Lat</param>
		/// <returns>The result of the operation</returns>
		public OperationResult DeleteByCityLocationLat(float cityLocationLat)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate CityLocationLat
			ValidationResult validationResult = this.ValidateCityLocationLat( cityLocationLat );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute delete
				operationResult = this._DeleteByCityLocationLat(cityLocationLat);
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
		
		//Validate CityLocationLat
		protected virtual ValidationResult ValidateCityLocationLat(float cityLocationLat)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateCity'. 
				//The validator factory will create the validator object based on its key.
				ICityValidator validator = (ICityValidator)ValidatorFactory.Create(Keywords.DeleteCity);
				
				//Execute validation process
				validationResult = validator.ValidateCityLocationLat(cityLocationLat);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to delete CityLocationLat
		protected virtual OperationResult _DeleteByCityLocationLat(float cityLocationLat)
		{
			//Create repository based on its Key name : 'Keywords.DeleteCity'. 
			//The repository factory will create the repository object based on its key. 
            IDeleteCityRepository repository = (IDeleteCityRepository)RepositoryFactory.Create(Keywords.DeleteCity);
            try
            {
            	//Execute DeleteByCityLocationLat
                repository.DeleteByCityLocationLat(cityLocationLat);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Delete  City data by lang I D
        /// </summary>
		/// <param name="langID"> Lang I D</param>
		/// <returns>The result of the operation</returns>
		public OperationResult DeleteByLangID(string langID)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate LangID
			ValidationResult validationResult = this.ValidateLangID( langID );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute delete
				operationResult = this._DeleteByLangID(langID);
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
		
		//Validate LangID
		protected virtual ValidationResult ValidateLangID(string langID)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateCity'. 
				//The validator factory will create the validator object based on its key.
				ICityValidator validator = (ICityValidator)ValidatorFactory.Create(Keywords.DeleteCity);
				
				//Execute validation process
				validationResult = validator.ValidateLangID(langID);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to delete LangID
		protected virtual OperationResult _DeleteByLangID(string langID)
		{
			//Create repository based on its Key name : 'Keywords.DeleteCity'. 
			//The repository factory will create the repository object based on its key. 
            IDeleteCityRepository repository = (IDeleteCityRepository)RepositoryFactory.Create(Keywords.DeleteCity);
            try
            {
            	//Execute DeleteByLangID
                repository.DeleteByLangID(langID);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Delete  City data by country Id
        /// </summary>
		/// <param name="countryId"> Country Id</param>
		/// <returns>The result of the operation</returns>
		public OperationResult DeleteByCountryId(Int16 countryId)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate 
			ValidationResult validationResult = this.ValidateCountryId( countryId );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute delete
				operationResult = this._DeleteByCountryId(countryId);
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
		protected virtual ValidationResult ValidateCountryId(Int16 countryId)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateCity'. 
				//The validator factory will create the validator object based on its key.
				ICityValidator validator = (ICityValidator)ValidatorFactory.Create(Keywords.DeleteCity);
				
				//Execute validation process
				validationResult = validator.ValidateCountryId(countryId);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to delete 
		protected virtual OperationResult _DeleteByCountryId(Int16 countryId)
		{
			//Create repository based on its Key name : 'Keywords.DeleteCity'. 
			//The repository factory will create the repository object based on its key. 
            IDeleteCityRepository repository = (IDeleteCityRepository)RepositoryFactory.Create(Keywords.DeleteCity);
            try
            {
            	//Execute DeleteByCountryId
                repository.DeleteByCountryId(countryId);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }			
		}


    }
 }