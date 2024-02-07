USE [HIMS]
GO

DROP PROCEDURE [dbo].[sproc_InsertAppointment]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[sproc_InsertAppointment]
@DoctorID INT,
@PatientID INT,
@DateOfAppointment datetime

AS
BEGIN

INSERT INTO [dbo].[Appointment]
(
	 [DoctorID]
	,[PatientID]
	,[DateOfAppointment]
	
)
VALUES
(
	 @DoctorID
	,@PatientID
	,@DateOfAppointment
	
)

END
GO


