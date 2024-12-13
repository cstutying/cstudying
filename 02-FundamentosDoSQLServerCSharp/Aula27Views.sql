CREATE OR ALTER VIEW vwCursosPorCategoria AS
    SELECT TOP 100
        [Categoria].[Nome],
            COUNT ([Curso].[CategoriaId]) AS [Cursos],[Categoria].[Id]
    FROM
        [Categoria]
        INNER JOIN [Curso]on [Curso].[CategoriaId] = [Categoria].[Id]
    GROUP BY
        [Categoria].[Id],
        [Categoria].[Nome],
        [Curso].[CategoriaId]
    -- (HAVING) AGRUPADO POR ESSE AQUI CONTENDO
    HAVING
        COUNT ([Curso].[CategoriaId]) > 1


-- CHAMA A VIEW EM UMA NOVA GUIA 
SELECT * FROM vwCursosPorCategoria
WHERE Nome = 'Backend'