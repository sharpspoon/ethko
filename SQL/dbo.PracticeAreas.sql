CREATE TABLE [dbo].[PracticeAreas]
(
	[PracticeAreaId] INT            IDENTITY (1, 1) NOT NULL,
	[PracticeAreaName]              VARCHAR (MAX)  NOT NULL,
	[FstUser]             NVARCHAR (128) NOT NULL,
    [InsDate]            DATETIME2 (7)  NOT NULL,
	[RowVersion]         ROWVERSION     NOT NULL,
	PRIMARY KEY CLUSTERED ([PracticeAreaId] ASC)
)
