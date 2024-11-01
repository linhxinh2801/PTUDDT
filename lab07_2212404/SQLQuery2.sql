SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [InsertFood] 
	@ID int output,
	@Name nvarchar(1000),
	@Unit nvarchar(199),
	@FoodCategoryID int, 
	@Price int,
	@Notes nvarchar(3000)
AS
INSERT INTO [Food]
([Name], [Unit], [FoodCategoryID], [Price], [Notes]) 
VALUES (@Name, @Unit, @FoodCategoryID, @Price, @Notes)

SELECT @ID = SCOPE_IDENTITY();
GO
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT <@Param1, sysname, @p1>, <@Param2, sysname, @p2>
END
GO
