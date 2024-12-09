namespace CSharpBootCamp.DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_added_customer_status : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "CustomerStatus", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "CustomerStatus");
        }
    }
}
