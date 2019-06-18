CREATE TABLE [dbo].[BillingMethods]
(
	[BillingMethodId] INT            IDENTITY (1, 1) NOT NULL,
	[BillingMethodName]              VARCHAR (MAX)  NOT NULL,
	[FstUser]             NVARCHAR (128) NOT NULL,
    [InsDate]            DATETIME2 (7)  NOT NULL,
	[RowVersion]         ROWVERSION     NOT NULL,
	PRIMARY KEY CLUSTERED ([BillingMethodId] ASC)
)
