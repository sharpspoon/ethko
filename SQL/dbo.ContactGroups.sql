CREATE TABLE [dbo].[ContactGroups] (
    [ContactGroupId]   INT            IDENTITY (1, 1) NOT NULL,
    [ContactGroupName] NVARCHAR (50)  NOT NULL,
    [InsDate]          DATETIME2 (7)  NOT NULL,
    [FstUser]          NVARCHAR (128) NOT NULL,
    PRIMARY KEY CLUSTERED ([ContactGroupId] ASC),
    CONSTRAINT [FK_ContactGroups_AspNetUsers] FOREIGN KEY ([FstUser]) REFERENCES [dbo].[AspNetUsers] ([Id])
);

