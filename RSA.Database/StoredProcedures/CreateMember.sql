CREATE PROCEDURE [dbo].[CreateMember]
    @name nvarchar(256),
    @email nvarchar(256),
    @phone nvarchar(512)
AS
    insert into [dbo].[Members] values (@name, @email, @phone)  
go
