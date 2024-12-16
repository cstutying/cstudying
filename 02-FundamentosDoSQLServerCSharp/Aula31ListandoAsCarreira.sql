-- EXEMPLO 1
SELECT 
  [Id],
  [Title],
  [Url],
  (SELECT COUNT ([CareerId]) FROM [CareerItem] WHERE [CareerId] = [Id]) AS [Course]
FROM
  [Career]

-- EXEMPLO 2
SELECT
  [Career].[Id],
  [Career].[Title],
  [Career].[Url],
  COUNT([Id]) AS [Course]
FROM
  [Career]
  INNER JOIN [CareerItem] ON [CareerItem].[CareerId] = [Career].[Id]
GROUP BY
  [Career].[Id],
  [Career].[Title],
  [Career].[Url]