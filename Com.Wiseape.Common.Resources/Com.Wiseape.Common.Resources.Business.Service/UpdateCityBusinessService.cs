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
    public class UpdateCityBusinessService : BaseBusinessService<City>, IUpdateCityBusinessService
    {
        class Keywords
        {
            public static string UpdateCity = "Update.Common.Resources.City";
        }
        
        public UpdateCityBusinessService(string repoKey) : base(repoKey)
        {
        }
        
        public UpdateCityBusinessService()
        {
            this.RepoKey = Keywords.UpdateCity;
        }


        /// <summary>
        /// Update  City data with id City, city Name
        /// </summary>
		/// <param name="idCity"> Id City</param>
		/// <param name="cityName"> City Name</param>
		/// <returns>The result of the operation</returns>
		public virtual OperationResult UpdateCityName(Int64 idCity, string cityName)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate CityName
			ValidationResult validationResult = this.ValidateCityName( idCity, cityName );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute Update
				operationResult = _UpdateCityName(idCity, cityName);
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
		protected virtual ValidationResult ValidateCityName(Int64 idCity, string cityName)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateCity'. 
				//The validator factory will create the validator object based on its key.
				ICityValidator validator = (ICityValidator)ValidatorFactory.Create(Keywords.UpdateCity);
				
				//Execute validation process
				validationResult = validator.ValidateCityName(idCity, cityName);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to update CityName
		protected virtual OperationResult _UpdateCityName(Int64 idCity, string cityName)
		{
			//Create repository based on its Key name : 'Keywords.UpdateCity'. 
			//The repository factory will create the repository object based on its key.
           	IUpdateCityRepository repository = (IUpdateCityRepository)RepositoryFactory.Create(Keywords.UpdateCity);
            try
            {
            	//Execute UpdateCityName
                repository.UpdateCityName(idCity, cityName);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
            	//Return false if error along with its exception
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Update  City data with id City, city Location Lon
        /// </summary>
		/// <param name="idCity"> Id City</param>
		/// <param name="cityLocationLon"> City Location Lon</param>
		/// <returns>The result of the operation</returns>
		public virtual OperationResult UpdateCityLocationLon(Int64 idCity, float cityLocationLon)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate CityLocationLon
			ValidationResult validationResult = this.ValidateCityLocationLon( idCity, cityLocationLon );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute Update
				operationResult = _UpdateCityLocationLon(idCity, cityLocationLon);
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
		protected virtual ValidationResult ValidateCityLocationLon(Int64 idCity, float cityLocationLon)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateCity'. 
				//The validator factory will create the validator object based on its key.
				ICityValidator validator = (ICityValidator)ValidatorFactory.Create(Keywords.UpdateCity);
				
				//Execute validation process
				validationResult = validator.ValidateCityLocationLon(idCity, cityLocationLon);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to update CityLocationLon
		protected virtual OperationResult _UpdateCityLocationLon(Int64 idCity, float cityLocationLon)
		{
			//Create repository based on its Key name : 'Keywords.UpdateCity'. 
			//The repository factory will create the repository object based on its key.
           	IUpdateCityRepository repository = (IUpdateCityRepository)RepositoryFactory.Create(Keywords.UpdateCity);
            try
            {
            	//Execute UpdateCityLocationLon
                repository.UpdateCityLocationLon(idCity, cityLocationLon);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
            	//Return false if error along with its exception
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Update  City data with id City, city Location Lat
        /// </summary>
		/// <param name="idCity"> Id City</param>
		/// <param name="cityLocationLat"> City Location Lat</param>
		/// <returns>The result of the operation</returns>
		public virtual OperationResult UpdateCityLocationLat(Int64 idCity, float cityLocationLat)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate CityLocationLat
			ValidationResult validationResult = this.ValidateCityLocationLat( idCity, cityLocationLat );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute Update
				operationResult = _UpdateCityLocationLat(idCity, cityLocationLat);
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
		protected virtual ValidationResult ValidateCityLocationLat(Int64 idCity, float cityLocationLat)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateCity'. 
				//The validator factory will create the validator object based on its key.
				ICityValidator validator = (ICityValidator)ValidatorFactory.Create(Keywords.UpdateCity);
				
				//Execute validation process
				validationResult = validator.ValidateCityLocationLat(idCity, cityLocationLat);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to update CityLocationLat
		protected virtual OperationResult _UpdateCityLocationLat(Int64 idCity, float cityLocationLat)
		{
			//Create repository based on its Key name : 'Keywords.UpdateCity'. 
			//The repository factory will create the repository object based on its key.
           	IUpdateCityRepository repository = (IUpdateCityRepository)RepositoryFactory.Create(Keywords.UpdateCity);
            try
            {
            	//Execute UpdateCityLocationLat
                repository.UpdateCityLocationLat(idCity, cityLocationLat);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
            	//Return false if error along with its exception
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Update  City data with id City, lang I D
        /// </summary>
		/// <param name="idCity"> Id City</param>
		/// <param name="langID"> Lang I D</param>
		/// <returns>The result of the operation</returns>
		public virtual OperationResult UpdateLangID(Int64 idCity, string langID)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate LangID
			ValidationResult validationResult = this.ValidateLangID( idCity, langID );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute Update
				operationResult = _UpdateLangID(idCity, langID);
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
		protected virtual ValidationResult ValidateLangID(Int64 idCity, string langID)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateCity'. 
				//The validator factory will create the validator object based on its key.
				ICityValidator validator = (ICityValidator)ValidatorFactory.Create(Keywords.UpdateCity);
				
				//Execute validation process
				validationResult = validator.ValidateLangID(idCity, langID);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to update LangID
		protected virtual OperationResult _UpdateLangID(Int64 idCity, string langID)
		{
			//Create repository based on its Key name : 'Keywords.UpdateCity'. 
			//The repository factory will create the repository object based on its key.
           	IUpdateCityRepository repository = (IUpdateCityRepository)RepositoryFactory.Create(Keywords.UpdateCity);
            try
            {
            	//Execute UpdateLangID
                repository.UpdateLangID(idCity, langID);
                return new OperationResult(true, null);
            }
            catch (Exception e)
            {
            	//Return false if error along with its exception
                return new OperationResult(false, e);
            }			
		}

        /// <summary>
        /// Update  City data with id City, country Id
        /// </summary>
		/// <param name="idCity"> Id City</param>
		/// <param name="countryId"> Country Id</param>
		/// <returns>The result of the operation</returns>
		public virtual OperationResult UpdateCountryId(Int64 idCity, Int16 countryId)
		{
			OperationResult operationResult = new OperationResult(false);
			
			//Validate 
			ValidationResult validationResult = this.ValidateCountryId( idCity, countryId );
			
			//If validation result is ok
			if(validationResult.Result)
			{
				//Execute Update
				operationResult = _UpdateCountryId(idCity, countryId);
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
		protected virtual ValidationResult ValidateCountryId(Int64 idCity, Int16 countryId)
		{
			ValidationResult validationResult = new ValidationResult(true);
			try
			{
				//Create Validator based on its Key name : 'Keywords.UpdateCity'. 
				//The validator factory will create the validator object based on its key.
				ICityValidator validator = (ICityValidator)ValidatorFactory.Create(Keywords.UpdateCity);
				
				//Execute validation process
				validationResult = validator.ValidateCountryId(idCity, countryId);
			}
			catch
			{
				//The program will throw error if the validation object doesn't exist. And the default of validation result is true.
			}	
			return validationResult;
		}
		
		//Function to update 
		protected virtual OperationResult _UpdateCountryId(Int64 idCity, Int16 countryId)
		{
			//Create repository based on its Key name : 'Keywords.UpdateCity'. 
			//The repository factory will create the repository object based on its key.
           	IUpdateCityRepository repository = (IUpdateCityRepository)RepositoryFactory.Create(Keywords.UpdateCity);
            try
            {
            	//Execute UpdateCountryId
                repository.UpdateCountryId(idCity, countryId);
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