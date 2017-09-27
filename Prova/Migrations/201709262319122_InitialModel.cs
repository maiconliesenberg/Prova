namespace Prova.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Faixas(Name, Grau) VALUES ('Branca', '6k')");
            Sql("INSERT INTO Faixas(Name, Grau) VALUES ('Amarela', '5k')");
            Sql("INSERT INTO Faixas(Name, Grau) VALUES ('Roxa', '4k')");
            Sql("INSERT INTO Faixas(Name, Grau) VALUES ('Verde', '3k')");
            Sql("INSERT INTO Faixas(Name, Grau) VALUES ('Azul', '2k')");
            Sql("INSERT INTO Faixas(Name, Grau) VALUES ('Marrom', '1k')");
            Sql("INSERT INTO Faixas(Name, Grau) VALUES ('Preta', '1d')");

            Sql("INSERT INTO TipoDeAssociacaos(Nome, periodo, Mensalidade) VALUES ('Mensal', 1 , 140)");
            Sql("INSERT INTO TipoDeAssociacaos(Nome, periodo, Mensalidade) VALUES ('Trimestral', 3 , 400)");
            Sql("INSERT INTO TipoDeAssociacaos(Nome, periodo, Mensalidade) VALUES ('Semestral', 6 , 600)");
            Sql("INSERT INTO TipoDeAssociacaos(Nome, periodo, Mensalidade) VALUES ('Anual', 12 , 1400)");

            Sql("INSERT INTO Alunos(Faixa_Id, TipoDeAssociacao_Id, Nome, CPF) VALUES (1, 1 , 'Martim Castro Ribeiro', '158.778.735-04')");
            Sql("INSERT INTO Alunos(Faixa_Id, TipoDeAssociacao_Id, Nome, CPF) VALUES (4, 3 , 'Lucas Alves Melo', '916.749.332-74')");
            Sql("INSERT INTO Alunos(Faixa_Id, TipoDeAssociacao_Id, Nome, CPF) VALUES (2, 2 , 'Breno Castro Carvalho', '454.019.800-94')");
            Sql("INSERT INTO Alunos(Faixa_Id, TipoDeAssociacao_Id, Nome, CPF) VALUES (6, 4 , 'Laura Cardoso Rocha', '361.089.665-56')");
        }
        
        public override void Down()
        {
        }
    }
}
