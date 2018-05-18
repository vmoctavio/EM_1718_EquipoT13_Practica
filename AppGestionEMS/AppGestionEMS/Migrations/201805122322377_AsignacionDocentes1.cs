namespace AppGestionEMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AsignacionDocentes1 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.AsignacionDocentes", name: "GrupoClaseId", newName: "GrupoClasesId");
            RenameIndex(table: "dbo.AsignacionDocentes", name: "IX_GrupoClaseId", newName: "IX_GrupoClasesId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.AsignacionDocentes", name: "IX_GrupoClasesId", newName: "IX_GrupoClaseId");
            RenameColumn(table: "dbo.AsignacionDocentes", name: "GrupoClasesId", newName: "GrupoClaseId");
        }
    }
}
