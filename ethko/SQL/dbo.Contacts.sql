﻿CREATE TABLE [dbo].[Contacts] (
    [ContactId]          INT            IDENTITY (1, 1) NOT NULL,
    [UserId]             NVARCHAR (128) NOT NULL,
    [InsDate]            DATETIME     NOT NULL,
    [FName]              VARCHAR (MAX)  NOT NULL,
    [LName]              VARCHAR (MAX)  NOT NULL,
    [MName]              VARCHAR (MAX)  NULL,
    [Archived]           SMALLINT       DEFAULT ((0)) NOT NULL,
    [Email]              VARCHAR (MAX)  NOT NULL,
    [ContactGroupId]     INT            NULL,
    [EnableClientPortal] SMALLINT       DEFAULT ((0)) NOT NULL,
    [CellPhone]          VARCHAR (50)   NULL,
    [WorkPhone]          VARCHAR (50)   NULL,
    [HomePhone]          VARCHAR (50)   NULL,
    [Address]            VARCHAR (50)   NULL,
    [Address2]           VARCHAR (50)   NULL,
    [City]               VARCHAR (50)   NULL,
    [State]              VARCHAR (50)   NULL,
    [Zip]                VARCHAR (50)   NULL,
    [Country]            VARCHAR (MAX)  NULL,
    [RowVersion] ROWVERSION NOT NULL, 
    PRIMARY KEY CLUSTERED ([ContactId] ASC),
    CONSTRAINT [FK_Table_ToTable] FOREIGN KEY ([UserId]) REFERENCES [dbo].[AspNetUsers] ([Id]),
    CONSTRAINT [FK_Contacts_ToTable] FOREIGN KEY ([ContactGroupId]) REFERENCES [dbo].[ContactGroups] ([ContactGroupId])
);
