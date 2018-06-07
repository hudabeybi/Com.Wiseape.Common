using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Wiseape.Utility;
using Com.Wiseape.Common.Data.Model;


namespace Com.Wiseape.Common.Resources.Business.Contract
{
    public interface IDeleteGenderBusinessService
    {

        /// <summary>
        /// Delete all  Gender data with gender Name containing specified keyword
        /// </summary>
		/// <param name="genderName"> Gender Name</param>
		/// <returns>List of  Gender</returns>
		OperationResult DeleteByGenderName(string genderName);

        /// <summary>
        /// Delete all  Gender data with gender Icon containing specified keyword
        /// </summary>
		/// <param name="genderIcon"> Gender Icon</param>
		/// <returns>List of  Gender</returns>
		OperationResult DeleteByGenderIcon(string genderIcon);

        /// <summary>
        /// Delete all  Gender data with language I D containing specified keyword
        /// </summary>
		/// <param name="languageID"> Language I D</param>
		/// <returns>List of  Gender</returns>
		OperationResult DeleteByLanguageID(string languageID);

	}
}