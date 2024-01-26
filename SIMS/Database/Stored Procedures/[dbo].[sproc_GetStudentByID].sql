USE [SIMS]
GO

DROP PROCEDURE [dbo].[sproc_GetStudentByID]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[sproc_GetStudentByID]
@StudentID INT
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
FROM [dbo].[Student] WITH (NOLOCK) WHERE [StudentID]=@StudentID

END
GO


