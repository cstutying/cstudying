-- PrimaryKey

USE [Curso]

DROP TABLE [Aluno]

CREATE TABLE [Aluno](
    [Id] INT NOT NULL,
    [Nome] NVARCHAR(80) NOT NULL,
    [Email]NVARCHAR(180) NOT NULL UNIQUE,
    [Nascimento] DATETIME NOT NULL,
    [Active] BIT NOT NULL,

    CONSTRAINT [PK_Aluno] PRIMARY KEY([Id]),
    CONSTRAINT [UQ_Aluno_Email] UNIQUE([Email]),
)
GO
-- Dropa (Exclui) Chave Primaria
ALTER TABLE [Aluno]
   DROP CONSTRAINT[PK_Aluno]
