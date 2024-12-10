-- INSERINDO INFORMAÇÕES
INSERT INTO [Categoria](Nome) VALUES ('Backend')
INSERT INTO [Categoria](Nome) VALUES ('Frontend')
INSERT INTO [Categoria](Nome) VALUES ('Mobile')

INSERT INTO [Curso]([Nome], [CategoriaId]) VALUES ('Fundamentos de C#', 1)
INSERT INTO [Curso]([Nome], [CategoriaId]) VALUES ('Fundamentos OOP', 1)
INSERT INTO [Curso]([Nome], [CategoriaId]) VALUES ('Angular', 2)
INSERT INTO [Curso]([Nome], [CategoriaId]) VALUES ('Flutter', 3)


INSERT INTO [Curso]VALUES ('Fluter e SQLite', 3) -- PODE FAZER ASSIM TAMBÉM