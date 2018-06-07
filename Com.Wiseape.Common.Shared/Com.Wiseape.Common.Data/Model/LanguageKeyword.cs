namespace Com.Wiseape.Common.Data.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LanguageKeyword")]
    public partial class LanguageKeyword
    {
        [Key]
        public long IdKeyword { get; set; }

        [StringLength(50)]
        public string Keyword { get; set; }

        [Column(TypeName = "text")]
        public string KeywordText { get; set; }

        [StringLength(50)]
        public string LanguageID { get; set; }
    }
}
