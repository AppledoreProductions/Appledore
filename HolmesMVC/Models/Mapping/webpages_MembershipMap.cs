using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HolmesMVC.Models.Mapping
{
    public class Webpages_MembershipMap : EntityTypeConfiguration<Webpages_Membership>
    {
        public Webpages_MembershipMap()
        {
            // Primary Key
            HasKey(t => t.UserId);

            // Properties
            Property(t => t.ConfirmationToken)
                .HasMaxLength(128);

            Property(t => t.Password)
                .IsRequired()
                .HasMaxLength(128);

            Property(t => t.PasswordSalt)
                .IsRequired()
                .HasMaxLength(128);

            Property(t => t.PasswordVerificationToken)
                .HasMaxLength(128);

            Property(t => t.UserId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            ToTable("webpages_Membership");
            Property(t => t.CreateDate).HasColumnName("CreateDate");
            Property(t => t.ConfirmationToken).HasColumnName("ConfirmationToken");
            Property(t => t.IsConfirmed).HasColumnName("IsConfirmed");
            Property(t => t.LastPasswordFailureDate).HasColumnName("LastPasswordFailureDate");
            Property(t => t.PasswordFailuresSinceLastSuccess).HasColumnName("PasswordFailuresSinceLastSuccess");
            Property(t => t.Password).HasColumnName("Password");
            Property(t => t.PasswordChangedDate).HasColumnName("PasswordChangedDate");
            Property(t => t.PasswordSalt).HasColumnName("PasswordSalt");
            Property(t => t.PasswordVerificationToken).HasColumnName("PasswordVerificationToken");
            Property(t => t.PasswordVerificationTokenExpirationDate).HasColumnName("PasswordVerificationTokenExpirationDate");
            Property(t => t.UserId).HasColumnName("UserId");
        }
    }
}
