namespace ECommerce.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departaments",
                c => new
                    {
                        DepartamentsId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.DepartamentsId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Departaments");
        }
    }
}
