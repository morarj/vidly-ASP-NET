namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'2648fc38-f148-4394-b49a-07f7b5bbbba8', N'guest@vidly.com', 0, N'AKfYOtkbk6dqSTiaTBaTf3/nHhSxy4XNPEjW2+H2t7CbF0sDidXa05BsMm0zPGhqPw==', N'443ede04-dfd1-481d-b5fd-6743d3b69eb5', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'5f10804b-cb3f-4c6b-99f7-bb2a4189bb55', N'admin@vidly.com', 0, N'AHt0fSkWIR40Oj4rjIuyVyUBVUjez2ZhWEuOoL/l/lrwCjkM9UCq+7/Ryehk+jMcGw==', N'6dfd277e-c06f-44ab-806a-48938fd4780e', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
                
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'a5c8abc6-c8a8-43a2-ac97-b9d34116df45', N'CanManageMovie')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'5f10804b-cb3f-4c6b-99f7-bb2a4189bb55', N'a5c8abc6-c8a8-43a2-ac97-b9d34116df45')
                ");
        }
        
        public override void Down()
        {
        }
    }
}
