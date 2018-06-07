using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Wiseape.Framework;

namespace Com.Wiseape.Common.Resources.View.Contract.Validator
{
    public interface IGenderValidator
    {

		ValidationResult ValidateGenderName(Int16 idGender, string genderName);

		ValidationResult ValidateGenderName(string genderName);

		ValidationResult ValidateGenderIcon(Int16 idGender, string genderIcon);

		ValidationResult ValidateGenderIcon(string genderIcon);

		ValidationResult ValidateLanguageID(Int16 idGender, string languageID);

		ValidationResult ValidateLanguageID(string languageID);

	}
}