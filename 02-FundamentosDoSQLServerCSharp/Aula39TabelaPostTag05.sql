CREATE TABLE [Tag](
    [Id] INT NOT NULL IDENTITY (1, 1),
    [Name] VARCHAR (80) NOT NULL,
    [Slug] VARCHAR (80) NOT NULL,

    CONSTRAINT [PK_Tag] PRIMARY KEY ([Id]),
    CONSTRAINT [UQ_Tag_Slug] UNIQUE ([Slug])
)
CREATE NONCLUSTERED INDEX [IX_Tag_Slug] ON [Tag]([Slug])

CREATE TABLE [PostTag](
    [PostId] INT NOT NULL,
    [TagId] INT NOT NULL,
    
    CONSTRAINT PK_PostTag PRIMARY KEY ([PostId], [TagId])
)
-- CRIA UMA TABELA DE CONTACT

CREATE TABLE [Contact](
    [Id] INT NOT NULL IDENTITY (1, 1),
    [Name] VARCHAR(255) NOT NULL,
    [Number] VARCHAR(20) NOT NULL,
    [Email] VARCHAR (255) NOT NULL,
    [Date] DATE NOT NULL, 
    [Socials] VARCHAR(100) NOT NULL,
   

    CONSTRAINT [PK_Contact] PRIMARY KEY ([Id]),
    CONSTRAINT [UQ_Contact_Socials] UNIQUE ([Socials])
)