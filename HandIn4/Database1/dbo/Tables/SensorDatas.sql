CREATE TABLE [dbo].[SensorDatas] (
    [SensorDataId] INT      IDENTITY (1, 1) NOT NULL,
    [version]      INT      NOT NULL,
    [timestamp]    DATETIME NOT NULL,
    CONSTRAINT [PK_dbo.SensorDatas] PRIMARY KEY CLUSTERED ([SensorDataId] ASC)
);

