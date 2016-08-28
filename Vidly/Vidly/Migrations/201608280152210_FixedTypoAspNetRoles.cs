namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixedTypoAspNetRoles : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                UPDATE [dbo].[AspNetRoles] SET Name = N'CanManageMovies' WHERE Id = N'a5c8abc6-c8a8-43a2-ac97-b9d34116df45'
                ");
        }
        
        public override void Down()
        {
        }
    }
}
