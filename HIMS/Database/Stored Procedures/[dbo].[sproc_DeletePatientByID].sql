USE [HIMS]
GO

DROP PROCEDURE [dbo].[sproc_DeletePatientByID]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[sproc_DeletePatientByID]
@PatientID int
AS
BEGIN


DELETE FROM [dbo].[Patient] 
where PatientID=@PatientID

END
GO


