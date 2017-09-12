CREATE TABLE [dbo].[Products]
(
	[ID] INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[Name] NVARCHAR(1000) NOT NULL,
	[Price] MONEY NOT NULL
)

GO 
CREATE TABLE Persons (
    PersonID int,
    LastName varchar(255),
    FirstName varchar(255),
    Address varchar(255),
    City varchar(255) 
);
