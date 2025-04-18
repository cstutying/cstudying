CREATE TABLE [User](
    [Id] INT NOT NULL IDENTITY(1, 1),
    [Name] NVARCHAR(80) NOT NULL,
    [Email] VARCHAR (200) NOT NULL,
    [PasswordHash] VARCHAR (255) NOT NULL,
    [Bio] TEXT NOT NULL,
    [Image] VARCHAR (2000) NOT NULL,
    [Slug] VARCHAR(80) NOT NULL,

    CONSTRAINT [PK_User] PRIMARY KEY ([Id]),
    CONSTRAINT [UQ_User_Email] UNIQUE([Email]),
    CONSTRAINT [UQ_User-Slug] UNIQUE ([Slug]),
)
CREATE NONCLUSTERED INDEX [IX_User_Email] ON [User] ([Email])
CREATE NONCLUSTERED INDEX [IX_User_Slug] ON [User] ([Slug])


INSERT INTO
    [User]
VALUES(
    'Christian CSharp',
    'christian@chsarp.com',
    'HASH',
    'Aprendendo CSharp',
    'https://...',
    'christian-csharp')
