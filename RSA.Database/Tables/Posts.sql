CREATE TABLE [dbo].[Posts]
(
    [Id] INT NOT NULL PRIMARY KEY identity(1, 1),
    [Title] nvarchar(256) null,
    [Body] nvarchar(max) null
)
