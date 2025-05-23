-- Indices
-- SEMPRE CRIAR ÍNDICES(INDEX) PARA COLUNAS QUE MAIS É UTILIZADA NA TABELA

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

--INDICES
CREATE INDEX[IX_Aluno_Email] ON [Aluno]([Email])
DROP INDEX [IX_Aluno_Email] ON [Aluno]

DROP TABLE[Curso]
CREATE TABLE [Curso](
    [Id] INT NOT NULL,
    [Nome] NVARCHAR(80) NOT NULL,
    [CategoriaId] INT NOT NULL,

    CONSTRAINT [PK_Curso] PRIMARY KEY([Id]),
    CONSTRAINT [PK_Curso_Categoria] FOREIGN KEY([CategoriaId])
        REFERENCES[Categoria]([Id])
)
GO

CREATE TABLE [Categoria](
    [Id] INT NOT NULL,
    [Nome] NVARCHAR(80) NOT NULL,

    CONSTRAINT [PK_Categoria] PRIMARY KEY([Id]),

)
GO

DROP TABLE [ProgressoCurso]
CREATE TABLE [ProgressoCurso](
    [AlunoId] INT NOT NULL,
    [CursoId] INT NOT NULL,
    [Progresso] INT NOT NULL,
    [UltimaAtualizacao] DATETIME NOT NULL DEFAULT(GETDATE()),

    CONSTRAINT PK_ProgressoCurso PRIMARY KEY([AlunoId],[CursoId]),
)
GO
