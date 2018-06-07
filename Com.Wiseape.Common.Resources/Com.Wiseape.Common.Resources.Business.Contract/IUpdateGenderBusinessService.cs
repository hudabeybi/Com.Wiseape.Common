using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Wiseape.Utility;
using Com.Wiseape.Common.Data.Model;


namespace Com.Wiseape.Common.Resources.Business.Contract
{
    public interface IUpdateGenderBusinessService
    {

        /// <summary>
        /// Updates  Gender's gender Name which has specified idGender
        /// </summary>
		/// <param name="idGender">id Gender</param>
		/// <param name="genderName">gender Name</param>
		/// <returns>List of  Gender</returns>
		OperationResult UpdateGenderName(Int16 idGender, string genderName);

        /// <summary>
        /// Updates  Gender's gender Icon which has specified idGender
        /// </summary>
		/// <param name="idGender">id Gender</param>
		/// <param name="genderIcon">gender Icon</param>
		/// <returns>List of  Gender</returns>
		OperationResult UpdateGenderIcon(Int16 idGender, string genderIcon);

        /// <summary>
        /// Updates  Gender's language I D which has specified idGender
        /// </summary>
		/// <param name="idGender">id Gender</param>
		/// <param name="languageID">language I D</param>
		/// <returns>List of  Gender</returns>
		OperationResult UpdateLanguageID(Int16 idGender, string languageID);

	}
}