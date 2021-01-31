namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'3e1b54c2-e1bc-4d2b-b04a-fd4e3a45f657', N'guest@vidly.com', 0, N'ANn1ac5E60dH4cbPNcRIYP1nTRYmNfTHNkrli66kkcwjX5jT2pf4WXh3HCFwlg8LFg==', N'0c9b4960-eb95-4dc4-9aab-2faf2cc19641', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'c623b378-060e-4fc5-9463-8938c81174bd', N'admin@vidly.com', 0, N'ANEhSIE9AVRK5y3Q6Pi0+BNp8D1/9F/1Rno+L5xnRoJQYOsGlBDxEI9pMGKhA6lyIw==', N'05ba0e47-4ee6-41a8-9d81-538b1df0595b', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'989b324d-edbe-4f14-80c6-a5aaa2e13a6e', N'CanManageMovies')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'c623b378-060e-4fc5-9463-8938c81174bd', N'989b324d-edbe-4f14-80c6-a5aaa2e13a6e')

");
        }
        
        public override void Down()
        {
        }
    }
}
