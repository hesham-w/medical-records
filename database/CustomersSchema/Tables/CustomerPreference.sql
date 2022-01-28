CREATE TABLE [dbo].[CustomerPreference]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [CustomerId] INT NOT NULL, 
    [EnableCreateCase] BIT NOT NULL DEFAULT 0, 
    [EnableAuth] BIT NOT NULL DEFAULT 0, 
    [EnableSubpoena] BIT NOT NULL DEFAULT 0, 
    [EnableSpecialRequest] BIT NOT NULL DEFAULT 0, 
    [EnableSmartOrg] BIT NOT NULL DEFAULT 0, 
    [Created] DATETIMEOFFSET NOT NULL, 
    [CreatedBy] INT NOT NULL, 
    [Modified] DATETIMEOFFSET NULL, 
    [ModifiedBy] INT NULL, 
    CONSTRAINT [FK_CustomerPreference_Customer] FOREIGN KEY ([CustomerId]) REFERENCES [Customers].[Customer]([Id]),
    CONSTRAINT [FK_CustomerPreference_CreatedBy] FOREIGN KEY ([CreatedBy]) REFERENCES [dbo].[User]([Id]),
    CONSTRAINT [FK_CustomerPreference_ModifiedBy] FOREIGN KEY ([ModifiedBy]) REFERENCES [dbo].[User]([Id])
)
