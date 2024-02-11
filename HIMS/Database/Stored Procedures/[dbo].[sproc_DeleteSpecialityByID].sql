USE [HIMS]
GO

DROP PROCEDURE [dbo].[sproc_DeleteSpecialityByID]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[sproc_DeleteSpecialityByID]
@SpecialityID int
AS
BEGIN


DELETE FROM [dbo].[Speciality] 
where SpecialityID=@SpecialityID

END
GO


