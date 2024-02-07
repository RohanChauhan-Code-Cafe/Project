USE [HIMS]
GO

DROP PROCEDURE [dbo].[sproc_GetAppointmentByID]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[sproc_GetAppointmentByID]
@AppointmentID INT
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
FROM [dbo].[Appointment] WITH (NOLOCK) WHERE [AppointmentID]=@AppointmentID

END
GO


