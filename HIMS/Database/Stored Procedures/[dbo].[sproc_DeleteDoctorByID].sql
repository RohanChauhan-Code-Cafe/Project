USE [HIMS]
GO

DROP PROCEDURE [dbo].[sproc_DeleteDoctorByID]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[sproc_DeleteDoctorByID]
@DoctorID int
AS
BEGIN


DELETE FROM [dbo].[Doctor] 
where DoctorID=@DoctorID

END
GO


