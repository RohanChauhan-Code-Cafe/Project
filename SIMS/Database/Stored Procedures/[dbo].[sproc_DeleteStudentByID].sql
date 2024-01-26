USE [SIMS]
GO

DROP PROCEDURE [dbo].[sproc_DeleteStudentByID]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[sproc_DeleteStudentByID]
@StudentID int
AS
BEGIN

DELETE FROM [dbo].[Student] where StudentID=@StudentID

END
GO


