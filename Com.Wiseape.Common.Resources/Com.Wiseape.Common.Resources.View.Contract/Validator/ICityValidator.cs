using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Wiseape.Framework;

namespace Com.Wiseape.Common.Resources.View.Contract.Validator
{
    public interface ICityValidator
    {

		ValidationResult ValidateCityName(Int64 idCity, string cityName);

		ValidationResult ValidateCityName(string cityName);

		ValidationResult ValidateCityLocationLon(Int64 idCity, float cityLocationLon);

		ValidationResult ValidateCityLocationLon(float cityLocationLon);

		ValidationResult ValidateCityLocationLat(Int64 idCity, float cityLocationLat);

		ValidationResult ValidateCityLocationLat(float cityLocationLat);

		ValidationResult ValidateLangID(Int64 idCity, string langID);

		ValidationResult ValidateLangID(string langID);

		ValidationResult ValidateCountryId(Int64 idCity, Int16 countryId);

		ValidationResult ValidateCountryId(Int16 countryId);

	}
}