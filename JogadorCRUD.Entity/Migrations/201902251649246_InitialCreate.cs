namespace JogadorCRUD.Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Jogadors",
                c => new
                    {
                        IdJogador = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 20),
                        Nascimento = c.DateTime(nullable: false),
                        Endereco = c.String(nullable: false, maxLength: 30),
                        Cpf = c.String(maxLength: 13),
                        Posicao = c.String(nullable: false, maxLength: 20),
                        Time = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.IdJogador);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Jogadors");
        }
    }
}
