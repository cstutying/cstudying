-- (UNION) ELE UNE AS TABELA
-- (UNION ALL)ELE EVITA QUE PEGUE TABELA DUPLICADA
    SELECT TOP 100
        [Id],[Nome]
    FROM
        [Curso]

UNION ALL

    SELECT TOP 100
        [Id],[Nome]
    FROM
        [Categoria]