namespace ECommerce.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlteraAnotationsTabDepartaments : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Departaments", "Name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Departaments", "Name", c => c.String());
        }
    }
}
