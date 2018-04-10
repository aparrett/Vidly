namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeIdsToInts : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Customers", "MembershipTypeId", "dbo.MembershipTypes");
            DropForeignKey("dbo.Movies", "GenreId", "dbo.Genres");
            DropIndex("dbo.Customers", new[] { "MembershipTypeId" });
            DropIndex("dbo.Movies", new[] { "GenreId" });
            DropPrimaryKey("dbo.Customers");
            DropPrimaryKey("dbo.MembershipTypes");
            DropPrimaryKey("dbo.Genres");
            DropPrimaryKey("dbo.Movies");
            AddColumn("dbo.Customers", "MembershipType_Id", c => c.Int());
            AddColumn("dbo.Movies", "Genre_Id", c => c.Int());
            AlterColumn("dbo.Customers", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.MembershipTypes", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Genres", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Movies", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Customers", "Id");
            AddPrimaryKey("dbo.MembershipTypes", "Id");
            AddPrimaryKey("dbo.Genres", "Id");
            AddPrimaryKey("dbo.Movies", "Id");
            CreateIndex("dbo.Customers", "MembershipType_Id");
            CreateIndex("dbo.Movies", "Genre_Id");
            AddForeignKey("dbo.Customers", "MembershipType_Id", "dbo.MembershipTypes", "Id");
            AddForeignKey("dbo.Movies", "Genre_Id", "dbo.Genres", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Movies", "Genre_Id", "dbo.Genres");
            DropForeignKey("dbo.Customers", "MembershipType_Id", "dbo.MembershipTypes");
            DropIndex("dbo.Movies", new[] { "Genre_Id" });
            DropIndex("dbo.Customers", new[] { "MembershipType_Id" });
            DropPrimaryKey("dbo.Movies");
            DropPrimaryKey("dbo.Genres");
            DropPrimaryKey("dbo.MembershipTypes");
            DropPrimaryKey("dbo.Customers");
            AlterColumn("dbo.Movies", "Id", c => c.Byte(nullable: false));
            AlterColumn("dbo.Genres", "Id", c => c.Byte(nullable: false));
            AlterColumn("dbo.MembershipTypes", "Id", c => c.Byte(nullable: false));
            AlterColumn("dbo.Customers", "Id", c => c.Byte(nullable: false, identity: true));
            DropColumn("dbo.Movies", "Genre_Id");
            DropColumn("dbo.Customers", "MembershipType_Id");
            AddPrimaryKey("dbo.Movies", "Id");
            AddPrimaryKey("dbo.Genres", "Id");
            AddPrimaryKey("dbo.MembershipTypes", "Id");
            AddPrimaryKey("dbo.Customers", "Id");
            CreateIndex("dbo.Movies", "GenreId");
            CreateIndex("dbo.Customers", "MembershipTypeId");
            AddForeignKey("dbo.Movies", "GenreId", "dbo.Genres", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Customers", "MembershipTypeId", "dbo.MembershipTypes", "Id", cascadeDelete: true);
        }
    }
}
