namespace Com.Wiseape.Common.Data.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("City")]
    public partial class City
    {
        [Key]
        public long IdCity { get; set; }

        [StringLength(250)]
        public string CityName { get; set; }

        public double? CityLocationLon { get; set; }

        public double? CityLocationLat { get; set; }

        public int? CountryId { get; set; }

        [StringLength(50)]
        public string LangID { get; set; }
    }
}
