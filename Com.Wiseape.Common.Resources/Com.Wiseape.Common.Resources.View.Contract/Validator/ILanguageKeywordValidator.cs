using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Wiseape.Framework;

namespace Com.Wiseape.Common.Resources.View.Contract.Validator
{
    public interface ILanguageKeywordValidator
    {

		ValidationResult ValidateKeyword(Int64 idKeyword, string keyword);

		ValidationResult ValidateKeyword(string keyword);

		ValidationResult ValidateKeywordText(Int64 idKeyword, string keywordText);

		ValidationResult ValidateKeywordText(string keywordText);

		ValidationResult ValidateLanguageID(Int64 idKeyword, string languageID);

		ValidationResult ValidateLanguageID(string languageID);

	}
}