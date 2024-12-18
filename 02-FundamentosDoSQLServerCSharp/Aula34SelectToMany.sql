SELECT 
  [Career].[Id], -- ID DA CARRERA 
  [Career].[Title], -- TITULO DA CARRERA 
  [CareerItem].[CareerId], -- SELECIONAR O CARRER ID (ESSE É O MESMO DO [CARRER].[ID])
  [CareerItem].[Title] -- E O TITULO DA CARRER ITEM
FROM
  [Career] -- FROM DA CARRERA 
INNER JOIN
  [CareerItem] ON [CareerItem].[CareerId] = [Career].[Id]
ORDER BY 
  [Career].[Title]