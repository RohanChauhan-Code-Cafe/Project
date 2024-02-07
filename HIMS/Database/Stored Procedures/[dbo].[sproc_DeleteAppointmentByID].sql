USE [HIMS]
GO

DROP PROCEDURE [dbo].[sproc_DeleteAppointmentByID]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[sproc_DeleteAppointmentByID]
@AppointmentID int
AS
BEGIN


DELETE FROM [dbo].[Appointment] 
where AppointmentID=@AppointmentID

END
GO


