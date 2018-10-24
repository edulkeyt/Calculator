namespace VtbCalculator.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CalculationQueue",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        OperationType = c.Int(nullable: false),
                        OperandLeft = c.Decimal(nullable: false, precision: 18, scale: 2),
                        OperandRight = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CalculationQueue");
        }
    }
}
