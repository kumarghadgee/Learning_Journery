USE [KaradDB]
GO

DECLARE	@return_value Int

EXEC	@return_value = [dbo].[AddEmployee]
		@name = N'Vishwajeet',
		@address = N'Rethare'

SELECT	@return_value as 'Return Value'

GO
