namespace Com.Wiseape.Common.Data.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Gender")]
    public partial class Gender
    {
        [Key]
        public int IdGender { get; set; }

        [StringLength(50)]
        public string GenderName { get; set; }

        [Column(TypeName = "text")]
        public string GenderIcon { get; set; }

        [StringLength(50)]
        public string LanguageID { get; set; }
    }
}
