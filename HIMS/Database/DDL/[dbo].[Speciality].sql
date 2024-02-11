USE [HIMS]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].Speciality') AND type in (N'U'))
DROP TABLE [dbo].Speciality
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].Speciality(
	[SpecialityID] [int] IDENTITY(1,1) NOT NULL,
	[Description] [nvarchar](100) NOT NULL,
	[DateAdded] [datetime] NOT NULL,
	[AddedBy] [nvarchar](100) NOT NULL,
	[DateLastModified] [datetime] NOT NULL,
	[ModifiedBy] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[SpecialityID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO



ALTER TABLE [dbo].Speciality ADD  DEFAULT (getdate()) FOR [DateAdded]
GO

ALTER TABLE [dbo].Speciality ADD  DEFAULT ('Admin') FOR [AddedBy]
GO

ALTER TABLE [dbo].Speciality ADD  DEFAULT (getdate()) FOR [DateLastModified]
GO

ALTER TABLE [dbo].Speciality ADD  DEFAULT ('Admin') FOR [ModifiedBy]
GO


