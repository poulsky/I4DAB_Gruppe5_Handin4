CREATE TRIGGER [LogTrigger]
	ON [dbo].[Readings]
	FOR INSERT
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
		VALUES (@dateTime, 'INSERT', @apId,@reId)  
	END
