USE [HIMS]
GO

DROP PROCEDURE [dbo].[sproc_GetAllDoctor]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[sproc_GetAllDoctor]
AS
BEGIN

SELECT 
	 [DoctorID]
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
FROM [dbo].[Doctor] WITH (NOLOCK)

END
GO


