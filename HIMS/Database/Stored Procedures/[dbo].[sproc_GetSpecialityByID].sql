USE [HIMS]
GO

DROP PROCEDURE [dbo].[sproc_GetSpecialityByID]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[sproc_GetSpecialityByID]
@SpecialityID INT
AS
BEGIN

SELECT 
	 [SpecialityID]
	,[Description]
	,[DateAdded]
	,[AddedBy]
	,[DateLastModified]
	,[ModifiedBy]
FROM [dbo].[Speciality] WITH (NOLOCK) WHERE [SpecialityID]=@SpecialityID

END
GO


