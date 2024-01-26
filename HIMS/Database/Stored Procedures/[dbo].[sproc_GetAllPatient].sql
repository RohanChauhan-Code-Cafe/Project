USE [HIMS]
GO

DROP PROCEDURE [dbo].[sproc_GetAllPatient]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[sproc_GetAllPatient]
AS
BEGIN

SELECT 
	 [PatientID]
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
FROM [dbo].[Patient] WITH (NOLOCK)

END
GO


