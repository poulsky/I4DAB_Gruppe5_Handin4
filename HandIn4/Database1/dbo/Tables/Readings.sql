CREATE TABLE [dbo].[Readings] (
    [ReadingId]    BIGINT   IDENTITY (1, 1) NOT NULL,
    [sensorId]     INT      NOT NULL,
    [appartmentId] INT      NOT NULL,
    [value]        REAL     NOT NULL,
    [timestamp]    DATETIME NOT NULL,
    CONSTRAINT [PK_dbo.Readings] PRIMARY KEY CLUSTERED ([ReadingId] ASC)
);

