USE [HIMS]
GO

DROP PROCEDURE [dbo].[sproc_InsertPatient]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[sproc_InsertPatient]
@Firstname [nvarchar](100),
@LastName [nvarchar](100),
@DOB [datetime],
@Address [nvarchar](500),
@City [nvarchar](100),
@State [nvarchar](100),
@Country [nvarchar](100),
@Zip nvarchar(20),
@MobileNumber varchar(10),
@IsActive [bit]
AS
BEGIN

INSERT INTO [dbo].[Patient]
(
	 [Firstname]
	,[LastName]
	,[DOB]
	,[Address]
	,[City]
	,[State]
	,[Country]
	,[Zip]
	,[MobileNumber]
	,[IsActive]
)
VALUES
(
	 @Firstname
	,@LastName
	,@DOB
	,@Address
	,@City
	,@State
	,@Country
	,@Zip
	,@MobileNumber
	,@IsActive
)

END
GO


