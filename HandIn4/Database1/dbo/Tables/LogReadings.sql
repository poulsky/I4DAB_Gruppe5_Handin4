CREATE TABLE [dbo].[LogReadings] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [DateTime]    DATETIME       NOT NULL,
    [Operations]  NVARCHAR (MAX) NULL,
    [apartmentId] INT            NOT NULL,
    [ReadingId]   INT            NOT NULL,
    CONSTRAINT [PK_dbo.LogReadings] PRIMARY KEY CLUSTERED ([Id] ASC)
);

