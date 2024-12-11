-- (JOIN) JUNÇÃO 
-- INNER JOIN FAZ UMA JUNÇÃO DA TABELA DE CURSO E CATEGORIA
SELECT TOP 100
  [Curso].[Id],
  [Curso].[Nome],
  [Categoria].[Id] AS [Categoria],
  [Categoria].[Nome]
FROM
    [Curso]
    INNER JOIN[Categoria]
    ON[Curso].[CategoriaId]=[Categoria].[Id]
