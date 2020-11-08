namespace Tool_World.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateSeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
            INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'139a63a5-9b6e-497d-8537-c0280459f270', N'admin@toolworld.com', 0, N'AK4M8pa/xI4kKTrHWAozHheD5MdWwH6TeF7Tk485JXSPfjoax0bgpBErWd3HLk2X8g==', N'f940496b-8a5b-40cf-a020-4eb7b6a01abf', NULL, 0, 0, NULL, 1, 0, N'admin@toolworld.com')
            INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'd61eb907-f827-407e-afb2-008348d7ce64', N'user125@toolworld.com', 0, N'APY3w2eUBf91k3LE5DxM1Ccnap0wXCmHr+q1PixiY+OUZGGe1ymNeO6/0H50PAsmsA==', N'bb892883-f35f-4384-b955-6a0bb61729ff', NULL, 0, 0, NULL, 1, 0, N'user125@toolworld.com')
            INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'9fefd9c4-9c35-4c64-9af4-e61653edd14f', N'guest@toolworld.com', 0, N'ACDyiFqt6171/VRF2fz7Ina4nVqvDNEspSjvIDQ2qHoqfv5NMMsMs1lAK9fVc5WWbA==', N'c2ae6a64-eaed-4f55-801f-95865495a378', NULL, 0, 0, NULL, 1, 0, N'guest@toolworld.com')

            
            INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'ba15d30e-d26d-4654-9793-7a0ba098d178', N'CanManageTools')
            INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'4c9906c3-eded-470f-b536-aeb0ae32ad26', N'CanManageRentals')

            INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'139a63a5-9b6e-497d-8537-c0280459f270', N'ba15d30e-d26d-4654-9793-7a0ba098d178')
            INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'd61eb907-f827-407e-afb2-008348d7ce64', N'4c9906c3-eded-470f-b536-aeb0ae32ad26')
            ");
        }
           

        public override void Down()
        {
        }
    }
}
