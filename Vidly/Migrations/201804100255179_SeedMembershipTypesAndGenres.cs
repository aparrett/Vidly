namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedMembershipTypesAndGenres : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MembershipTypes (Name, SignUpFee, DurationInMonths, DiscountRate) VALUES ('Pay as You Go', 0, 0, 0)");
            Sql("INSERT INTO MembershipTypes (Name, SignUpFee, DurationInMonths, DiscountRate) VALUES ('Monthly', 30, 1, 10)");
            Sql("INSERT INTO MembershipTypes (Name, SignUpFee, DurationInMonths, DiscountRate) VALUES ('Quarterly', 90, 3, 15)");
            Sql("INSERT INTO MembershipTypes (Name, SignUpFee, DurationInMonths, DiscountRate) VALUES ('Annual', 300, 12, 30)");

            Sql("INSERT INTO Genres (Name) VALUES ('Comedy')");
            Sql("INSERT INTO Genres (Name) VALUES ('Action')");
            Sql("INSERT INTO Genres (Name) VALUES ('Drama')");
            Sql("INSERT INTO Genres (Name) VALUES ('Romance')");
            Sql("INSERT INTO Genres (Name) VALUES ('Horror')");
        }
        
        public override void Down()
        {
        }
    }
}
