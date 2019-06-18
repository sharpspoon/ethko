CREATE TABLE [dbo].[CaseStages] (
    [CaseStageId]   INT           IDENTITY (1, 1) NOT NULL,
    [CaseStageName] NVARCHAR (50) NOT NULL,
	[FstUser]        NVARCHAR (128) NOT NULL,
    [InsDate]        DATETIME2 (7)  NOT NULL,
    [RowVersion]     ROWVERSION     NOT NULL,
    PRIMARY KEY CLUSTERED ([CaseStageId] ASC)
);

