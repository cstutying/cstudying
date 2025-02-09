-- EXEMPLO 1
CREATE OR ALTER PROCEDURE spDeleteStudent (
  @StudentId UNIQUEIDENTIFIER
)
AS
BEGIN TRANSACTION
  DELETE FROM 
    [StudentCourse] 
  WHERE 
    [StudentId] = @StudentId

  DELETE FROM 
    [Student] 
  WHERE 
    [Id] = @StudentId
COMMIT


-- EXEMPLO 2
DELETE FROM [Post]
DELETE FROM [User]
DELETE FROM [Category]

SELECT * FROM __EFMigrationsHistory

DROP TABLE __EFMigrationsHistory

SELECT * FROM [User]
SELECT * FROM [Category]
SELECT * FROM [Post]

USE [Master];
GO

ALTER DATABASE [Blog] SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
GO

DROP DATABASE [Blog];
GO