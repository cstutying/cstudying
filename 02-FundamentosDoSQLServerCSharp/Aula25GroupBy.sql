-- (COUNT) TODA VEZ QUE FOR USA (COUNT) É OBRIGATORIAMENTE USAR O (GROUP BY)
-- (GROUP BY) ESSA É UMA FORMA QUE TEM QUANDO QUEREMOS USAR ITENS EM UM PEDIDO, SABER QUANTOS CURSO TEM EM UMA CATEGORIA
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