USE [SIMS]
GO

DROP PROCEDURE [dbo].[sproc_GetAllStudent]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[sproc_GetAllStudent]
AS
BEGIN

SELECT 
	 [StudentID]
	,[Firstname]
	,[LastName]
	,[DOB]
	,[Address]
	,[City]
	,[State]
	,[Country]
	,[Zip]
	,[MobileNumber]
	,[IsActive]
	,[DateAdded]
	,[AddedBy]
	,[DateLastModified]
	,[ModifiedBy]
FROM [dbo].[Student] WITH (NOLOCK)

END
GO


