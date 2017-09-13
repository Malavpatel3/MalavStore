CREATE TABLE [dbo].[Customers]
(
	[Id] INT NOT NULL PRIMARY KEY,
	[AspNetUserID] NVARCHAR(128) NULL, 
	[FirstName] NVARCHAR(1000),
	[LastName] NVARCHAR(1000),
	[DateOfBirth] DATETIME2,

    CONSTRAINT [FK_Customers_AspNetUsers] FOREIGN KEY (AspnetUserID) REFERENCES AspNetUsers(ID),

)
