USE [SIMS]
GO


DROP PROCEDURE [dbo].[sproc_UpdateStudentByID]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[sproc_UpdateStudentByID]
	@StudentID int,
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

UPDATE [dbo].[Student] SET 
	 [Firstname]=@Firstname
	,[LastName]=@LastName
	,[Address]=@Address
	,[City]=@City
	,[State]=@State
	,[Country]=@Country
	,[Zip]=@Zip
	,[MobileNumber]=@MobileNumber
	,[IsActive]=@IsActive
	,[DateLastModified]=getdate()
	,[ModifiedBy]='Admin'
WHERE StudentID=@StudentID

END
GO


