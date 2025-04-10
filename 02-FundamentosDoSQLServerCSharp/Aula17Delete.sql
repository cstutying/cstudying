USE [Cursos]
select * from [Categoria]

-- EXEMPLO 1
DELETE FROM
    [Curso]
WHERE
    [CategoriaId] = 3

-- EXEMPLO 2
DELETE FROM 
    [Categoria]
WHERE
    [Id] = 3

-- EXEMPLO 3 [EXCLUI DATA BASE]
USE [master];

DECLARE @kill varchar(8000) = '';  
SELECT @kill = @kill + 'kill ' + CONVERT(varchar(5), session_id) + ';'  
FROM sys.dm_exec_sessions
WHERE database_id  = db_id('CSharp')

EXEC(@kill);

DROP DATABASE [CSharp]

-- EXEMPLO 4 [CRIA DATA BASE]
CREATE DATABASE [Blog]
GO

USE [Blog]
GO

-- EXEMPLO 5 [EXCLUI UMA TABELA]
DROP TABLE NomeDaTabela;

-- EXEMPLO 6 [EXCLUI UMA USER]
DELETE FROM [Post]
DELETE FROM [User]
DELETE FROM [Category]