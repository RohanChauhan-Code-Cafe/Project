USE [HIMS]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Doctor]') AND type in (N'U'))
DROP TABLE [dbo].[Doctor]

GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Doctor](
	[DoctorID] [int] IDENTITY(1,1) NOT NULL,
	[Firstname] [nvarchar](100) NOT NULL,
	[LastName] [nvarchar](100) NOT NULL,
	[SpecialityID] int FOREIGN KEY REFERENCES Speciality(SpecialityID), 
	[DOB] [datetime] NOT NULL,
	[Address] [nvarchar](500) NULL,
	[City] [nvarchar](100) NOT NULL,
	[State] [nvarchar](100) NOT NULL,
	[Country] [nvarchar](100) NOT NULL,
	[Zip] [nvarchar](20) NOT NULL,
	[MobileNumber] [varchar](10) NOT NULL,
	[IsActive] [bit] NOT NULL,
	[DateAdded] [datetime] NOT NULL,
	[AddedBy] [nvarchar](100) NOT NULL,
	[DateLastModified] [datetime] NOT NULL,
	[ModifiedBy] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[DoctorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Doctor] ADD  DEFAULT ((1)) FOR [IsActive]
GO

ALTER TABLE [dbo].[Doctor] ADD  DEFAULT (getdate()) FOR [DateAdded]
GO

ALTER TABLE [dbo].[Doctor] ADD  DEFAULT ('Admin') FOR [AddedBy]
GO

ALTER TABLE [dbo].[Doctor] ADD  DEFAULT (getdate()) FOR [DateLastModified]
GO

ALTER TABLE [dbo].[Doctor] ADD  DEFAULT ('Admin') FOR [ModifiedBy]
GO


