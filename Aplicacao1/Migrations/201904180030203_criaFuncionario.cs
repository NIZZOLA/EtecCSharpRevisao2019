namespace Aplicacao1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class criaFuncionario : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Funcionario",
                c => new
                    {
                        FuncionarioId = c.Int(nullable: false, identity: true),
                        Nome = c.String(maxLength: 50),
                        Cargo = c.String(maxLength: 50),
                        Fone = c.String(maxLength: 15),
                        Email = c.String(maxLength: 80),
                        Senha = c.String(maxLength: 10),
                        Nascimento = c.DateTime(nullable: false),
                        Ativo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.FuncionarioId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Funcionario");
        }
    }
}
