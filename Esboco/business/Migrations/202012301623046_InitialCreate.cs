namespace business.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Fonte",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Autor = c.String(),
                        Livro = c.String(),
                        MensagemId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Mensagem", t => t.MensagemId, cascadeDelete: true)
                .Index(t => t.MensagemId);
            
            CreateTable(
                "dbo.Mensagem",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Tipo = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Fonte", "MensagemId", "dbo.Mensagem");
            DropIndex("dbo.Fonte", new[] { "MensagemId" });
            DropTable("dbo.Mensagem");
            DropTable("dbo.Fonte");
        }
    }
}
