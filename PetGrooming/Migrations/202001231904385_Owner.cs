namespace PetGrooming.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Owner : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Owners",
                c => new
                    {
                        OwnerID = c.Int(nullable: false, identity: true),
                        OwnerFname = c.String(),
                        OwnerLname = c.String(),
                        OwnerWorkPhone = c.String(),
                        OwnerHomePhone = c.String(),
                        OwnerEmail = c.String(),
                        OwnerAddress = c.String(),
                        OwnerPetname = c.String(),
                    })
                .PrimaryKey(t => t.OwnerID);
            
            AlterColumn("dbo.Pets", "PetWeight", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Pets", "PetWeight", c => c.Double(nullable: false));
            DropTable("dbo.Owners");
        }
    }
}
