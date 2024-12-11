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