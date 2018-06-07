using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Wiseape.Framework;

namespace Com.Wiseape.Common.Resources.View.Contract.Validator
{
    public interface ILanguageValidator
    {

		ValidationResult ValidateLanguageID(Int16 idLanguage, string languageID);

		ValidationResult ValidateLanguageID(string languageID);

		ValidationResult ValidateLanguageName(Int16 idLanguage, string languageName);

		ValidationResult ValidateLanguageName(string languageName);

		ValidationResult ValidateLanguageDesc(Int16 idLanguage, string languageDesc);

		ValidationResult ValidateLanguageDesc(string languageDesc);

	}
}