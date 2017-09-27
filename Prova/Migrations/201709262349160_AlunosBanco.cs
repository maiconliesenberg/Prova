namespace Prova.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlunosBanco : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Alunos(Faixa_Id, TipoDeAssociacao_Id, Nome, CPF) VALUES (16, 10 , 'Martim Castro Ribeiro', '158.778.735-04')");
            Sql("INSERT INTO Alunos(Faixa_Id, TipoDeAssociacao_Id, Nome, CPF) VALUES (19, 12 , 'Lucas Alves Melo', '916.749.332-74')");
            Sql("INSERT INTO Alunos(Faixa_Id, TipoDeAssociacao_Id, Nome, CPF) VALUES (17, 11 , 'Breno Castro Carvalho', '454.019.800-94')");
            Sql("INSERT INTO Alunos(Faixa_Id, TipoDeAssociacao_Id, Nome, CPF) VALUES (21, 13 , 'Laura Cardoso Rocha', '361.089.665-56')");
        }
        
        public override void Down()
        {
        }
    }
}
