CREATE TABLE [Orders].[Case]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [PlaintiffName] VARCHAR(50) NULL, 
    [DefendantName] VARCHAR(50) NULL, 
    [WorkflowTypeId] INT NOT NULL, 
    CONSTRAINT [FK_Case_WorkflowType] FOREIGN KEY ([WorkflowTypeId]) REFERENCES [Orders].[WorkflowType]([Id])
)
