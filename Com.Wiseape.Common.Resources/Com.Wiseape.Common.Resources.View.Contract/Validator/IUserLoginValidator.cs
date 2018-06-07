using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Wiseape.Framework;

namespace Com.Wiseape.Common.Resources.View.Contract.Validator
{
    public interface IUserLoginValidator
    {

		ValidationResult ValidateUsername(Int64 idUser, string username);

		ValidationResult ValidateUsername(string username);

		ValidationResult ValidateUserPassword(Int64 idUser, string userPassword);

		ValidationResult ValidateUserPassword(string userPassword);

		ValidationResult ValidateCreatedDate(Int64 idUser, DateTime createdDate);

		ValidationResult ValidateCreatedDate(DateTime createdDate);

		ValidationResult ValidateApplicationID(Int64 idUser, string applicationID);

		ValidationResult ValidateApplicationID(string applicationID);

		ValidationResult ValidateIsActive(Int64 idUser, Int16 isActive);

		ValidationResult ValidateIsActive(Int16 isActive);

	}
}