create type dbo.ReadingsTable as table
(
	--[ReadingId]    BIGINT   IDENTITY (1, 1) NOT NULL,
    [sensorId1]     INT      NOT NULL,
    [appartmentId1] INT      NOT NULL,
    [value1]        REAL     NOT NULL,
    [timestamp1]    DATETIME NOT NULL
)
go
CREATE PROCEDURE [dbo].[InsertProcedure]
(
	
	@Items [ReadingsTable] readonly
	
)
AS
begin

insert into dbo.Readings([appartmentId],[sensorId],[value],[timestamp])

select [appartmentId1],[sensorId1],[value1],[timestamp1] from @Items

end
go
--{"Operand type clash: datetime2 is incompatible with real\r\nThe data for table-valued parameter
-- \"@Items\" doesn't conform to the table type of the parameter. SQL Server error is: 200, state: 7"}