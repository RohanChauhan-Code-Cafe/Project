USE [HIMS]
GO

DROP PROCEDURE [dbo].[sproc_GetDoctorByID]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[sproc_GetDoctorByID]
@DoctorID INT
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
FROM [dbo].[Doctor] WITH (NOLOCK) WHERE [DoctorID]=@DoctorID

END
GO


