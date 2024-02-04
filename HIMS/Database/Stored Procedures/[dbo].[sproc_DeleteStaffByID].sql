USE [HIMS]
GO

DROP PROCEDURE [dbo].[sproc_DeleteStaffByID]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[sproc_DeleteStaffByID]
@StaffID int
AS
BEGIN


DELETE FROM [dbo].[Staff] 
where StaffID=@StaffID

END
GO


