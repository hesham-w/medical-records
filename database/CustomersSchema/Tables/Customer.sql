CREATE TABLE [Customers].[Customer]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Name] VARCHAR(50) NOT NULL, 
    [AddressLine1] VARCHAR(200) NULL, 
    [AddressLine2] VARCHAR(200) NOT NULL, 
    [City] VARCHAR(50) NULL, 
    [Created] DATETIMEOFFSET NULL, 
    [CreatedBy] INT NOT NULL, 
    [Modified] DATETIMEOFFSET NOT NULL, 
    [ModifiedBy] INT NULL, 
    CONSTRAINT [FK_ModifiedBy_User] FOREIGN KEY ([ModifiedBy]) REFERENCES [User]([Id]),
    CONSTRAINT [FK_CreatedBy_User] FOREIGN KEY ([CreatedBy]) REFERENCES [User]([Id])
)
