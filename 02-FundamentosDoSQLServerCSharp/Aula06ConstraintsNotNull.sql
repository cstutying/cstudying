USE [Curso]

DROP TABLE [Aluno]

CREATE TABLE [Aluno](
    [Id] INT NOT NULL,
    [Nome] NVARCHAR(80) NOT NULL,
    [Nascimento] DATETIME NOT NULL,
    [Active] BIT NOT NULL,
)
GO

ALTER TABLE [Aluno]
ALTER COLUMN [Active] BIT NOT NULL