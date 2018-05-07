namespace AppGestionEMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TipoUsuario : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cursos", "Cod_Curso", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Cursos", "Cod_Curso");
        }
    }
}
