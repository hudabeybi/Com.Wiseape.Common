using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Wiseape.Framework;

namespace Com.Wiseape.Common.Resources.View.Contract.Validator
{
    public interface ICountryValidator
    {

		ValidationResult ValidateCountryName(Int16 idCountry, string countryName);

		ValidationResult ValidateCountryName(string countryName);

		ValidationResult ValidateCountryDesc(Int16 idCountry, string countryDesc);

		ValidationResult ValidateCountryDesc(string countryDesc);

		ValidationResult ValidateCountryFlagIcon(Int16 idCountry, string countryFlagIcon);

		ValidationResult ValidateCountryFlagIcon(string countryFlagIcon);

		ValidationResult ValidateIsActive(Int16 idCountry, Int16 isActive);

		ValidationResult ValidateIsActive(Int16 isActive);

	}
}