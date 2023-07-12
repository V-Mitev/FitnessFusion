namespace FitnessFusion.Data.Configuration
{
    using FitnessFusion.Data.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class ApplicationUserConfiguration /*: IEntityTypeConfiguration<ApplicationUser>*/
    {
        //public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        //{
        //    builder.HasData(GenerateUsers());
        //}

        //private ICollection<ApplicationUser> GenerateUsers()
        //{
        //    var users = new List<ApplicationUser>();

        //    ApplicationUser user;

        //    user = new ApplicationUser()
        //    {
        //        FirstName = "Test",
        //        LastName = "User",
        //        IsTrainer = false,
        //        IsSubscribeValid = false,
        //        Email = "test@abv.bg",
        //        Pas
        //    };
        //    users.Add(user);

        //    return users;
        //}
    }
}
