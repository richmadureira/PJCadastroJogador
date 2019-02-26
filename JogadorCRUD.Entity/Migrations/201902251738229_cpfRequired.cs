namespace JogadorCRUD.Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cpfRequired : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Jogadors", "Cpf", c => c.String(nullable: false, maxLength: 13));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Jogadors", "Cpf", c => c.String(maxLength: 13));
        }
    }
}
