namespace Com.Wiseape.Common.Data.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserLogin")]
    public partial class UserLogin
    {
        [Key]
        public long IdUser { get; set; }

        [StringLength(50)]
        public string Username { get; set; }

        [StringLength(50)]
        public string UserPassword { get; set; }

        public DateTime? CreatedDate { get; set; }

        public int? IsActive { get; set; }

        [StringLength(50)]
        public string ApplicationID { get; set; }
    }
}
