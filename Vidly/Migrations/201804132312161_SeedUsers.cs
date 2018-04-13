namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'34f94026-5a30-4915-b51e-1a526978f399', N'anthonyparrett7@gmail.com', 0, N'ADNHOdoOofIyHRxih+xjovi3iYmZs1mXub55/LrvkYcbIZ/P9K/9kCGJRuU1e1TpZQ==', N'bb557376-1093-450f-8894-a304049934ef', NULL, 0, 0, NULL, 1, 0, N'anthonyparrett7@gmail.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'da1b15dd-8b6c-461a-bb5c-442bd4d112ae', N'admin@vidly.com', 0, N'AMP2xt3g8FIRWpQ/dJG5Zhz/ueap12xU7h6cfvm3Vxv0Boapo1Fq2w/cEpZg88Yxfg==', N'79bb47a6-fae5-4f0a-8370-ac1cb29b7464', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'05d88b31-3e18-4d68-a75a-4923015d2863', N'CanManageMovies')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'da1b15dd-8b6c-461a-bb5c-442bd4d112ae', N'05d88b31-3e18-4d68-a75a-4923015d2863')
");
        }
        
        public override void Down()
        {
        }
    }
}
