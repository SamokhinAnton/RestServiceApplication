CREATE PROCEDURE [dbo].[CreatePost]
    @title nvarchar(256),
    @body nvarchar(max)
AS
    insert into [dbo].[Posts] values(@title, @body)  
go
