namespace Com.Wiseape.Common.Data.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Country")]
    public partial class Country
    {
        [Key]
        public int IdCountry { get; set; }

        [StringLength(250)]
        public string CountryName { get; set; }

        [Column(TypeName = "text")]
        public string CountryDesc { get; set; }

        [Column(TypeName = "text")]
        public string CountryFlagIcon { get; set; }

        public int? IsActive { get; set; }
    }
}
