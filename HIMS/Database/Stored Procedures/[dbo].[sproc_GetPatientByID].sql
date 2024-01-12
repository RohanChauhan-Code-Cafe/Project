USE [HIMS]
GO

DROP PROCEDURE [dbo].[sproc_GetPatientByID]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[sproc_GetPatientByID]
@PatientID INT
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
FROM [dbo].[Patient] WITH (NOLOCK) WHERE [PatientID]=@PatientID

END
GO


