
SELECT TOP 100
   [Id], [Nome], [CategoriaId]
FROM 
    [Curso]
WHERE
--TIPOS DE WHERE
[Id] = 1 AND -- OR, AND, IS NULL, IS NOT NULL
   [CategoriaId] IS NOT NULL
-- [CategoriaId] != 1
-- [CategoriaId] = 1 -- COMPARADOR
-- [CategoriaId] > 1
-- [CategoriaId] >= 1
-- [CategoriaId] < 1
-- [CategoriaId] <= 1
