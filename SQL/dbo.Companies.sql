CREATE TABLE [dbo].[Companies] (
    [CompanyId]  INT            IDENTITY (1, 1) NOT NULL,
    [FstUser]    NVARCHAR (128) NOT NULL,
    [InsDate]    DATETIME       NOT NULL,
    [Name]       VARCHAR (MAX)  NOT NULL,
    [Archived]   SMALLINT       DEFAULT ((0)) NOT NULL,
    [Email]      VARCHAR (MAX)  NOT NULL,
    [Website]    VARCHAR (50)   NULL,
    [MainPhone]  VARCHAR (50)   NULL,
    [FaxNumber]  VARCHAR (50)   NULL,
    [Address]    VARCHAR (50)   NULL,
    [Address2]   VARCHAR (50)   NULL,
    [City]       VARCHAR (50)   NULL,
    [State]      VARCHAR (50)   NULL,
    [Zip]        VARCHAR (50)   NULL,
    [Country]    VARCHAR (MAX)  NULL,
    [RowVersion] ROWVERSION     NOT NULL,
    PRIMARY KEY CLUSTERED ([CompanyId] ASC),
    CONSTRAINT [FK_Companies_AspNetUsers] FOREIGN KEY ([FstUser]) REFERENCES [dbo].[AspNetUsers] ([Id])
);

