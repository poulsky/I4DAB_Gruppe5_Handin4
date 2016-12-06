CREATE TABLE [dbo].[SystemDatas] (
    [SystemDataId] INT      IDENTITY (1, 1) NOT NULL,
    [timestamp]    DATETIME NOT NULL,
    [version]      INT      NOT NULL,
    CONSTRAINT [PK_dbo.SystemDatas] PRIMARY KEY CLUSTERED ([SystemDataId] ASC)
);

