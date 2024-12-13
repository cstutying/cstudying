CREATE OR ALTER PROCEDURE [spListCourse]
  @Category NVARCHAR(60),
  @Par2 NVARCHAR(60)
AS -- PARAMENTO DE ENTRADA 
  DECLARE @CategoryId INT -- PEGA OS CURSO DA CATEGORIA BACKEND
  SET @CategoryId = (SELECT TOP 1 [Id] FROM [Categoria] WHERE [Nome] = @Category) -- BACKEND

  SELECT * FROM [Curso] WHERE [CategoriaId] = @CategoryId

  -- DECLARE @Id INT -- DECLAREI UMA VARIÁVEL
  -- SET @Id = 9 -- ATRIBUI UMA VARIÁVEL
  -- SELECT * FROM [Curso] WHERE [Id] = @Id -- PARA USAR ESSA VARIÁVEL 

  EXEC[spListCourse] 'Data','parametro 2'