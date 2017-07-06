CREATE TABLE [dbo].[Members]
(
    [Id] INT NOT NULL PRIMARY KEY identity(1, 1),
    [Name] nvarchar(256) not null,
    [Email] nvarchar(256) not null,
    [Phone] nvarchar(512) not null
)
