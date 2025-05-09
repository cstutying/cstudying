CREATE TABLE [Category](
    [Id] INT NOT NULL IDENTITY(1,1),
    [Name] VARCHAR(80),
    [Slug] VARCHAR(80),

    CONSTRAINT [PK_Category] PRIMARY KEY ([Id]),
    CONSTRAINT [UQ_Category] UNIQUE ([Slug])
)
CREATE NONCLUSTERED INDEX[IX_Category_Slug] ON [Category]([Slug])