namespace Com.Wiseape.Common.Data.Context
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using Com.Wiseape.Common.Data.Model;

    public partial class CommonDataContext : DbContext
    {
        public CommonDataContext()
            : base("name=CommonDataContext")
        {
        }

        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Gender> Genders { get; set; }
        public virtual DbSet<Language> Languages { get; set; }
        public virtual DbSet<LanguageKeyword> LanguageKeywords { get; set; }
        public virtual DbSet<UserInfo> UserInfoes { get; set; }
        public virtual DbSet<UserLogin> UserLogins { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>()
                .Property(e => e.CityName)
                .IsUnicode(false);

            modelBuilder.Entity<City>()
                .Property(e => e.LangID)
                .IsUnicode(false);

            modelBuilder.Entity<Country>()
                .Property(e => e.CountryName)
                .IsUnicode(false);

            modelBuilder.Entity<Country>()
                .Property(e => e.CountryDesc)
                .IsUnicode(false);

            modelBuilder.Entity<Country>()
                .Property(e => e.CountryFlagIcon)
                .IsUnicode(false);

            modelBuilder.Entity<Gender>()
                .Property(e => e.GenderName)
                .IsUnicode(false);

            modelBuilder.Entity<Gender>()
                .Property(e => e.GenderIcon)
                .IsUnicode(false);

            modelBuilder.Entity<Gender>()
                .Property(e => e.LanguageID)
                .IsUnicode(false);

            modelBuilder.Entity<Language>()
                .Property(e => e.LanguageID)
                .IsUnicode(false);

            modelBuilder.Entity<Language>()
                .Property(e => e.LanguageName)
                .IsUnicode(false);

            modelBuilder.Entity<Language>()
                .Property(e => e.LanguageDesc)
                .IsUnicode(false);

            modelBuilder.Entity<LanguageKeyword>()
                .Property(e => e.Keyword)
                .IsUnicode(false);

            modelBuilder.Entity<LanguageKeyword>()
                .Property(e => e.KeywordText)
                .IsUnicode(false);

            modelBuilder.Entity<LanguageKeyword>()
                .Property(e => e.LanguageID)
                .IsUnicode(false);

            modelBuilder.Entity<UserInfo>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<UserInfo>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<UserInfo>()
                .Property(e => e.MobilePhone)
                .IsUnicode(false);

            modelBuilder.Entity<UserInfo>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<UserInfo>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<UserLogin>()
                .Property(e => e.Username)
                .IsUnicode(false);

            modelBuilder.Entity<UserLogin>()
                .Property(e => e.UserPassword)
                .IsUnicode(false);

            modelBuilder.Entity<UserLogin>()
                .Property(e => e.ApplicationID)
                .IsUnicode(false);
        }
    }
}
