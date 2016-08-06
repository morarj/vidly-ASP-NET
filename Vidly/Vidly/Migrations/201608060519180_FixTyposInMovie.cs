namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixTyposInMovie : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "NumberInStock", c => c.Byte(nullable: false));
            AlterColumn("dbo.Movies", "DateAdded", c => c.DateTime());
            DropColumn("dbo.Movies", "NumbreInStock");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movies", "NumbreInStock", c => c.Byte(nullable: false));
            AlterColumn("dbo.Movies", "DateAdded", c => c.DateTime(nullable: false));
            DropColumn("dbo.Movies", "NumberInStock");
        }
    }
}
