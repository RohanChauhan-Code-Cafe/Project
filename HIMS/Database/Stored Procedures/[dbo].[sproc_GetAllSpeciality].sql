USE [HIMS]
GO

DROP PROCEDURE [dbo].[sproc_GetAllSpeciality]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[sproc_GetAllSpeciality]
AS
BEGIN

SELECT 
	 [SpecialityID]
	,[Description]
	,[DateAdded]
	,[AddedBy]
	,[DateLastModified]
	,[ModifiedBy]
FROM [dbo].[Speciality] WITH (NOLOCK)

END
GO


