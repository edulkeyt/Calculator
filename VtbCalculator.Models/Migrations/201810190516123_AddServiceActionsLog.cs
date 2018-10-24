namespace VtbCalculator.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddServiceActionsLog : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ServiceActionsLog",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Time = c.DateTime(nullable: false),
                        Source = c.String(nullable: false),
                        Action = c.String(nullable: false),
                        Message = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ServiceActionsLog");
        }
    }
}
