using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Wiseape.Common.Data.Model
{
    public partial class UserInfo
    {

        [NotMapped]
        public string Username { get; set; }
    }
}
