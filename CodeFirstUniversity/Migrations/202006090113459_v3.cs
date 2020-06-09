namespace CodeFirstUniversity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v3 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.People", "Activo");
        }
        
        public override void Down()
        {
            AddColumn("dbo.People", "Activo", c => c.Boolean());
        }
    }
}
