CREATE OR REPLACE TABLE SQL_RAW.Doctor(
	DoctorID int,
	Firstname varchar(100),
	LastName varchar(100),
	DOB datetime,
	Address varchar(500) NULL,
	City varchar(100),
	State varchar(100),
	Country varchar(100),
	Zip varchar(20),
	MobileNumber varchar(10),
	IsActive BOOLEAN,
	DateAdded TIMESTAMP_NTZ,
	AddedBy varchar(100),
	DateLastModified TIMESTAMP_NTZ,
	ModifiedBy varchar(100) 
);