namespace vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MovieModelNullableAttributesChanged : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Movies", "Name", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Movies", "ReleaseDate", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Movies", "DateAdded", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "DateAdded", c => c.String());
            AlterColumn("dbo.Movies", "ReleaseDate", c => c.String());
            AlterColumn("dbo.Movies", "Name", c => c.String());
        }
    }
}
