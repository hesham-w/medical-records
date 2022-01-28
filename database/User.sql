CREATE TABLE [dbo].[User]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [FirstName] VARCHAR(50) NULL, 
    [MiddleName] VARCHAR(50) NOT NULL, 
    [LastName] VARCHAR(50) NULL, 
    [Disabled] BIT NOT NULL DEFAULT 0, 
    [Created] DATETIMEOFFSET NOT NULL, 
    [Modified] DATETIMEOFFSET NULL
)
