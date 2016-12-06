CREATE TABLE [dbo].[Sensorcharacteristics] (
    [SensorcharacteristicId] INT            IDENTITY (1, 1) NOT NULL,
    [calibrationCoeff]       NVARCHAR (MAX) NULL,
    [description]            NVARCHAR (MAX) NULL,
    [calibrationDate]        DATETIME       NOT NULL,
    [externalRef]            NVARCHAR (MAX) NULL,
    [sensorId]               INT            NOT NULL,
    [unit]                   NVARCHAR (MAX) NULL,
    [calibrationEquation]    NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_dbo.Sensorcharacteristics] PRIMARY KEY CLUSTERED ([SensorcharacteristicId] ASC)
);

