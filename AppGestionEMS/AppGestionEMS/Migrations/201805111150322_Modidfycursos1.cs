namespace AppGestionEMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Modidfycursos1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Cursos", "Actual", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Cursos", "Actual", c => c.Byte(nullable: false));
        }
    }
}
