CREATE TRIGGER [LogTrigger2]
	ON [dbo].[Readings]
	FOR UPDATE
	AS
	DECLARE @dateTime DATETIME
	DECLARE @apId INT
	DECLARE @reId INT

	SELECT @dateTime = (SELECT timestamp FROM inserted)
	SELECT @apId = (SELECT appartmentId from inserted)
	SELECT @reId = (SELECT ReadingId from inserted)

	
	BEGIN
		SET NOCOUNT ON
		INSERT INTO dbo.LogReadings (DateTime, Operations, apartmentId, ReadingId) 
		VALUES (@dateTime, 'UPDATE', @apId,@reId)  
	END
