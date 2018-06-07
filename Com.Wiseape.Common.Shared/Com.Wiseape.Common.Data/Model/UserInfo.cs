namespace Com.Wiseape.Common.Data.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserInfo")]
    public partial class UserInfo
    {
        [Key]
        public long IdUserInfo { get; set; }

        public long? UserId { get; set; }

        [StringLength(250)]
        public string FirstName { get; set; }

        [StringLength(250)]
        public string LastName { get; set; }

        public int? GenderId { get; set; }

        [StringLength(250)]
        public string MobilePhone { get; set; }

        [StringLength(250)]
        public string Phone { get; set; }

        [Column(TypeName = "text")]
        public string Address { get; set; }

        public int? CityId { get; set; }

    }
}
