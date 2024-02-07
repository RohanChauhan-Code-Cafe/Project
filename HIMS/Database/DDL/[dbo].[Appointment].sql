USE [HIMS]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].Appointment') AND type in (N'U'))
DROP TABLE [dbo].Appointment
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].Appointment(
	[AppointmentID] [int] IDENTITY(1,1) NOT NULL,
	[DoctorID] [int] FOREIGN KEY REFERENCES Doctor(DoctorID),
	[PatientID] [int] FOREIGN KEY REFERENCES Patient(PatientID),
	[DateOfAppointment] datetime,
	[DateAdded] [datetime] NOT NULL,
	[AddedBy] [nvarchar](100) NOT NULL,
	[DateLastModified] [datetime] NOT NULL,
	[ModifiedBy] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[AppointmentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO



ALTER TABLE [dbo].Appointment ADD  DEFAULT (getdate()) FOR [DateAdded]
GO

ALTER TABLE [dbo].Appointment ADD  DEFAULT ('Admin') FOR [AddedBy]
GO

ALTER TABLE [dbo].Appointment ADD  DEFAULT (getdate()) FOR [DateLastModified]
GO

ALTER TABLE [dbo].Appointment ADD  DEFAULT ('Admin') FOR [ModifiedBy]
GO


