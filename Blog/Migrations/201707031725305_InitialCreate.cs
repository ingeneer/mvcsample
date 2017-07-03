namespace Blog.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Comentarios",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Contenido = c.String(nullable: false, maxLength: 100),
                        Aprobado = c.Boolean(nullable: false),
                        FechaPublicacion = c.DateTime(nullable: false),
                        EnPublicacion_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Publicacions", t => t.EnPublicacion_Id)
                .Index(t => t.EnPublicacion_Id);
            
            CreateTable(
                "dbo.Publicacions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Titulo = c.String(nullable: false, maxLength: 40),
                        Contenido = c.String(nullable: false),
                        Imagen = c.String(),
                        Habilitada = c.Boolean(nullable: false),
                        Resumen = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Comentarios", "EnPublicacion_Id", "dbo.Publicacions");
            DropIndex("dbo.Comentarios", new[] { "EnPublicacion_Id" });
            DropTable("dbo.Publicacions");
            DropTable("dbo.Comentarios");
        }
    }
}
