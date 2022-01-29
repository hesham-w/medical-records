CREATE TABLE [Orders].[CasePart]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [CaseId] INT NOT NULL, 
    CONSTRAINT [FK_CasePart_Case] FOREIGN KEY ([CaseId]) REFERENCES [Orders].[Case]([Id])
)
