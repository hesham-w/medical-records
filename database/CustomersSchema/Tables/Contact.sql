CREATE TABLE [Customers].[Contact]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [CustomerId] INT NOT NULL, 
    [UserId] INT NOT NULL, 
    [Disabled] BIT NOT NULL DEFAULT 0, 
    CONSTRAINT [FK_Contact_Customer] FOREIGN KEY ([CustomerId]) REFERENCES [Customers].[Customer]([Id]),
    CONSTRAINT [FK_Contact_User] FOREIGN KEY ([UserId]) REFERENCES [dbo].[User]([Id])
)
