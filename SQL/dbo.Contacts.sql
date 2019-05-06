CREATE TABLE [dbo].[Contacts]
(
	[ContactId] INT NOT NULL , 
    [UserId] NVARCHAR(128) NOT NULL, 
    [InsDate] TIMESTAMP NOT NULL, 
    [FName] VARCHAR(MAX) NOT NULL, 
    [LName] VARCHAR(MAX) NOT NULL, 
    [Email] VARCHAR(MAX) NOT NULL, 
    PRIMARY KEY ([ContactId]), 
    CONSTRAINT [FK_Table_ToTable] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers]([Id]) 
)

GO