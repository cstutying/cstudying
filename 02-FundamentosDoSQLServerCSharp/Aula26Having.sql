SELECT TOP 100
    [Categoria].[Id],
    [Categoria].[Nome],
        COUNT ([Curso].[CategoriaId]) AS [Cursos]
FROM
    [Categoria]
    INNER JOIN [Curso]on [Curso].[CategoriaId] = [Categoria].[Id]
GROUP BY
    [Categoria].[Id],
    [Categoria].[Nome],
    [Curso].[CategoriaId]
-- (HAVING)= CONTENDO AGRUPADO POR ESSE AQUI 
HAVING
    COUNT ([Curso].[CategoriaId]) > 2
