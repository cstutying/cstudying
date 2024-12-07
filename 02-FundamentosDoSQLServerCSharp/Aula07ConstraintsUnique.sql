-- ConstraintsUnique

USE [Curso]
DROP TABLE [Aluno]

CREATE TABLE [Aluno](
    [Id] INT NOT NULL UNIQUE,
    [Nome] NVARCHAR(80) NOT NULL,
    [Email]NVARCHAR(180) NOT NULL UNIQUE,
    [Nascimento] DATETIME NOT NULL,
    [Active] BIT NOT NULL,
)
GO
