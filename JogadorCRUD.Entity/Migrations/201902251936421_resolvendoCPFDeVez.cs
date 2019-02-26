namespace JogadorCRUD.Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class resolvendoCPFDeVez : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Jogadors", "Cpf", c => c.String(nullable: false, maxLength: 14));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Jogadors", "Cpf", c => c.String(nullable: false, maxLength: 15));
        }
    }
}
