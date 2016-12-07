CREATE PROCEDURE [dbo].[InsertProcedure]
(
	
	@Items [ReadingsTable] readonly
	
)
AS
begin

insert into dbo.Readings([appartmentId],[ReadingId],[sensorId],[timestamp],[value])

select [appartmentId],[ReadingId],[sensorId],[timestamp],[value] from @Items

end
go