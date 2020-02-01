namespace PetGrooming.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GroomService : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.GroomServices",
                c => new
                    {
                        GroomServiceID = c.Int(nullable: false, identity: true),
                        GroomServiceName = c.String(),
                        GroomServiceDuration = c.Int(nullable: false),
                        GroomSericeCost = c.Decimal(nullable: false, precision: 18, scale: 2),
                        GroomServiceGrommer = c.String(),
                    })
                .PrimaryKey(t => t.GroomServiceID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.GroomServices");
        }
    }
}
