CREATE PROCEDURE [dbo].[GetApartmentSensors]
	@apartmentId int = 0
AS
SELECT * from dbo.GetApSensorsFunction(@apartmentId)

