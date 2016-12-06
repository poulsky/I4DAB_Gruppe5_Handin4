CREATE FUNCTION [dbo].[GetApSensorsFunction]
(
	@apartmentId int = 0
	
)

DECLARE #temptable table

RETURNS TABLE AS RETURN
(
	SELECT Readings.sensorId, Sensorcharacteristics.description
	From Readings
	INNER JOIN Sensorcharacteristics
	ON Readings.appartmentId = @apartmentId
	
	
)
