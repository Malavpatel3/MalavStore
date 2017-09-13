CREATE TABLE [dbo].[CustomerMovies]
(
	[CustomerID] INT NOT NULL , 
    [MovieID] INT NOT NULL, 
    CONSTRAINT [PK_CustomerMovies] PRIMARY KEY ([MovieID], [CustomerID]), 
    CONSTRAINT [FK_CustomerMovies_Movies] FOREIGN KEY (MovieID) REFERENCES Movies(ID), 
    CONSTRAINT [FK_CustomerMovies_Customers] FOREIGN KEY (CustomerID) REFERENCES Customers(ID)
)
