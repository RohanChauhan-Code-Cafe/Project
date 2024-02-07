USE [HIMS]
GO

DROP PROCEDURE [dbo].[sproc_GetAllAppointment]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[sproc_GetAllAppointment]
AS
BEGIN

SELECT 
	 [AppointmentID]
	,[DoctorID]
	,[PatientID]
	,[DateOfAppointment]
	,[DateAdded]
	,[AddedBy]
	,[DateLastModified]
	,[ModifiedBy]
FROM [dbo].[Appointment] WITH (NOLOCK)

END
GO


