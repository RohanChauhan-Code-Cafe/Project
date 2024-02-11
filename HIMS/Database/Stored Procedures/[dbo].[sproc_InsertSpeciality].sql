USE [HIMS]
GO

DROP PROCEDURE [dbo].[sproc_InsertSpeciality]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[sproc_InsertSpeciality]
@Description nvarchar(100)

AS
BEGIN

INSERT INTO [dbo].[Speciality]
(
	 [Description]
	
)
VALUES
(
	 @Description
	
)

END
GO


