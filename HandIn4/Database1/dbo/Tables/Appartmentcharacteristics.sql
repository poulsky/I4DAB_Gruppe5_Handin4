CREATE TABLE [dbo].[Appartmentcharacteristics] (
    [appartmentId] INT  IDENTITY (1, 1) NOT NULL,
    [No]           INT  NOT NULL,
    [Size]         REAL NOT NULL,
    [Floor]        INT  NOT NULL,
    CONSTRAINT [PK_dbo.Appartmentcharacteristics] PRIMARY KEY CLUSTERED ([appartmentId] ASC)
);

