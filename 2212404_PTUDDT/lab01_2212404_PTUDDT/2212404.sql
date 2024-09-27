CREATE PROCEDURE Category_GetAll
AS
BEGIN
	SELECT FROM dbo. Category
END
GO
CREATE PROCEDURE Category_GetAll
AS
BEGIN
	SELECT FROM dbo. Category
END
GO
CREATE PROCEDURE Category_GetAll
( 
@ID INT
)
AS
BEGIN
	SELECT FROM dbo. Category WHERE ID = @ID
END
GO
CREATE PROCEDURE Category_Insert
(
@Name NVARCHAR(1000),
@Type INT
)
AS
BEGIN
 IF (NOT EXISTS (SELECT Name FROM dbo. Category WHERE Name = @Name 
 INSERT INTO dbo. Category (Name, Type) 
	VALUES (@Name, @Type)
END 
GO
CREATE PROCEDURE Category_Update
(
@ID INT,
@Name NVARCHAR(1000),
@Type INT
)
AS
BEGIN
	UPDATE dbo.Category
	SET [Name] =@Name, [Type] =@Type
	WHERE ID = @ID
END
GO
CREATE PROCEDURE Category_Delete
(
@ID INT
)
AS
BEGIN
	DELETE FROM dbo. Category
	WHERE ID = @ID
END
GO
EXEC dbo.Category_Insert N'Tráng miệng', 1
ALTER PROCEDURE dbo. Category_Insert_
(
@ID INT OUTPUT,
@Name NVARCHAR(1000),
@Type INT
)
AS
BEGIN

	IF (NOT EXISTS (SELECT Name FROM dbo. Category WHERE Name = @Name))
		INSERT INTO dbo. Category (Name, Type)
			VALUES (@Name, @Type)
	SET @ID = @@IDENTITY 
END
DECLARE @ID INT = 0;
EXEC dbo.Category_Insert_ @ID = @ID OUTPUT, 
						  @Name = N'Món rau', 
						  @Type = 1
SELECT*FROM dbo. Category WHERE ID = @ID
CREATE PROCEDURE [dbo].[GetAll]
(
@TableName NVARCHAR(200)
)
AS
BEGIN
	DECLARE @Sq1 NVARCHAR(1000) 
	SET @Sql = 'Select * from '+@TableName 
	EXEC (@Sql)
END
EXEC dbo._GetAll 'Category'