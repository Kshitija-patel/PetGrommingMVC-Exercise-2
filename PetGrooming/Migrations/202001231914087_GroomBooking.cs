namespace PetGrooming.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GroomBooking : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.GroomBookings", "GroomBookingTotalCost", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.GroomBookings", "GroomBookingGroomerName");
            DropColumn("dbo.GroomBookings", "GroomBookingServices");
        }
        
        public override void Down()
        {
            AddColumn("dbo.GroomBookings", "GroomBookingServices", c => c.String());
            AddColumn("dbo.GroomBookings", "GroomBookingGroomerName", c => c.String());
            AlterColumn("dbo.GroomBookings", "GroomBookingTotalCost", c => c.String());
        }
    }
}
