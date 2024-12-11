SELECT TOP 100
    *
FROM
    [Curso]
-- (LIKE) SIMILAR PARA FUNCIONAR EXIGE QUE COLOQUE (%) EX: ABAIXO
-- LIKE (%Fundamentos%) COMEÇA COM (%) OU TERMINA COM (%) OU OS DOIS (%)Fundamentos(%)
WHERE
    [Nome] LIKE '%Fundamentos%'