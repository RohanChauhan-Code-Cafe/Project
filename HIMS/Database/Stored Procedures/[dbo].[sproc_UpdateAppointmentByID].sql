USE [HIMS]
GO


DROP PROCEDURE [dbo].[sproc_UpdateAppointmentByID]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[sproc_UpdateAppointmentByID]
	@AppointmentID int,
	@DoctorID INT,
	@PatientID INT,
	@DateOfAppointment datetime
	
AS
BEGIN

UPDATE [dbo].[Appointment] SET 
	 [DoctorID]=@DoctorID
	,[PatientID]=@PatientID
	,[DateOfAppointment]= @DateOfAppointment
	
WHERE AppointmentID=@AppointmentID

END
GO


