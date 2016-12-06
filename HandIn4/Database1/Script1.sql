CREATE FUNCTION [dbo].[GetApSensorsFunction]
(
	@apartmentId int = 0
	
)
RETURNS TABLE AS RETURN
(
	
	SELECT Readings.sensorId, Readings.appartmentId, Sensorcharacteristics.description
	From Readings
	INNER JOIN Sensorcharacteristics
	ON Readings.appartmentId = @apartmentId	
)
