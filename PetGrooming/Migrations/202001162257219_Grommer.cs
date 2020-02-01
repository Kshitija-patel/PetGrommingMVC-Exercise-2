namespace PetGrooming.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Grommer : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Groomers",
                c => new
                    {
                        GroomerID = c.Int(nullable: false, identity: true),
                        GroomerFname = c.String(),
                        GroomerLname = c.String(),
                        GroomerPhone = c.String(),
                        GroomerHourlyRate = c.Double(nullable: false),
                        GroomerAddress = c.String(),
                        GroomerExperience = c.Single(nullable: false),
                        GroomerDOB = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.GroomerID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Groomers");
        }
    }
}
