using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Wiseape.Framework;

namespace Com.Wiseape.Common.Resources.View.Contract.Validator
{
    public interface IUserInfoValidator
    {

		ValidationResult ValidateFirstName(Int64 idUserInfo, string firstName);

		ValidationResult ValidateFirstName(string firstName);

		ValidationResult ValidateLastName(Int64 idUserInfo, string lastName);

		ValidationResult ValidateLastName(string lastName);

		ValidationResult ValidateMobilePhone(Int64 idUserInfo, string mobilePhone);

		ValidationResult ValidateMobilePhone(string mobilePhone);

		ValidationResult ValidatePhone(Int64 idUserInfo, string phone);

		ValidationResult ValidatePhone(string phone);

		ValidationResult ValidateAddress(Int64 idUserInfo, string address);

		ValidationResult ValidateAddress(string address);

		ValidationResult ValidateUserId(Int64 idUserInfo, Int64 userId);

		ValidationResult ValidateUserId(Int64 userId);

		ValidationResult ValidateUserIdAndGenderId(Int64 idUserInfo, Int64 userId, Int16 genderId);

		ValidationResult ValidateUserIdAndGenderId(Int64 userId, Int16 genderId);

		ValidationResult ValidateUserIdAndGenderIdAndCityId(Int64 idUserInfo, Int64 userId, Int16 genderId, Int16 cityId);

		ValidationResult ValidateUserIdAndGenderIdAndCityId(Int64 userId, Int16 genderId, Int16 cityId);

		ValidationResult ValidateUserIdAndCityId(Int64 idUserInfo, Int64 userId, Int16 cityId);

		ValidationResult ValidateUserIdAndCityId(Int64 userId, Int16 cityId);

		ValidationResult ValidateGenderId(Int64 idUserInfo, Int16 genderId);

		ValidationResult ValidateGenderId(Int16 genderId);

		ValidationResult ValidateGenderIdAndCityId(Int64 idUserInfo, Int16 genderId, Int16 cityId);

		ValidationResult ValidateGenderIdAndCityId(Int16 genderId, Int16 cityId);

		ValidationResult ValidateCityId(Int64 idUserInfo, Int16 cityId);

		ValidationResult ValidateCityId(Int16 cityId);

	}
}