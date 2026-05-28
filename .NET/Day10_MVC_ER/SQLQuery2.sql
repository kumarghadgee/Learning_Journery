USE [KaradDB]
GO

DECLARE	@return_value Int

EXEC	@return_value = [dbo].[AddEmployee]
		@name = N'Saheb',
		@address = N'Pune'

SELECT	@return_value as 'Return Value'

GO
