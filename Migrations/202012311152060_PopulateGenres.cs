namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenres : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Genres SET Id=1 WHERE Name='Thriller'");
            Sql("UPDATE Genres SET Id=2 WHERE Name='Family'");
            Sql("UPDATE Genres SET Id=3 WHERE Name='Romance'");
            Sql("UPDATE Genres SET Id=4 WHERE Name='Comedy'");
        }
        
        public override void Down()
        {
        }
    }
}
