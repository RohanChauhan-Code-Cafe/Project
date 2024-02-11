USE [HIMS]
GO


DROP PROCEDURE [dbo].[sproc_UpdateSpecialityByID]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[sproc_UpdateSpecialityByID]
	@SpecialityID int,
	@Description nvarchar(100)
	
AS
BEGIN

UPDATE [dbo].[Speciality] SET 
	 [Description]=@Description
	
	
WHERE SpecialityID=@SpecialityID

END
GO


