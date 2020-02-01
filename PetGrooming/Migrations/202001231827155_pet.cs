namespace PetGrooming.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class pet : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Pets", "PetWeight", c => c.Double(nullable: false));
            AddColumn("dbo.Pets", "PetColor", c => c.String());
            AddColumn("dbo.Pets", "PetNotes", c => c.String());
            AddColumn("dbo.Pets", "PetAge", c => c.Int(nullable: false));
            AlterColumn("dbo.Groomers", "GroomerHourlyRate", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Groomers", "GroomerExperience", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.Pets", "Weight");
            DropColumn("dbo.Pets", "Color");
            DropColumn("dbo.Pets", "Notes");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Pets", "Notes", c => c.String());
            AddColumn("dbo.Pets", "Color", c => c.String());
            AddColumn("dbo.Pets", "Weight", c => c.Double(nullable: false));
            AlterColumn("dbo.Groomers", "GroomerExperience", c => c.Single(nullable: false));
            AlterColumn("dbo.Groomers", "GroomerHourlyRate", c => c.Double(nullable: false));
            DropColumn("dbo.Pets", "PetAge");
            DropColumn("dbo.Pets", "PetNotes");
            DropColumn("dbo.Pets", "PetColor");
            DropColumn("dbo.Pets", "PetWeight");
        }
    }
}
