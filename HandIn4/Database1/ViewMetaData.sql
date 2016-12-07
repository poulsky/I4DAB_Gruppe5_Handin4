CREATE VIEW [dbo].[MetaData]
	AS SELECT Readings.timestamp, Readings.value, Sensorcharacteristics.unit, Sensorcharacteristics.description
	FROM
	 dbo.Readings INNER JOIN dbo.Sensorcharacteristics
	  ON dbo.Readings.sensorId = dbo.Sensorcharacteristics.sensorId
	  GO