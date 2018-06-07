namespace Com.Wiseape.Common.Data.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Language")]
    public partial class Language
    {
        [Key]
        public int IdLanguage { get; set; }

        [StringLength(50)]
        public string LanguageID { get; set; }

        [StringLength(250)]
        public string LanguageName { get; set; }

        [Column(TypeName = "text")]
        public string LanguageDesc { get; set; }
    }
}
