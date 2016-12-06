CREATE TRIGGER [LogTrigger1]
	ON [dbo].[Readings]
	FOR DELETE
	AS
	DECLARE @dateTime DATETIME
	DECLARE @apId INT
	DECLARE @reId INT

	SELECT @dateTime = (SELECT timestamp FROM deleted)
	SELECT @apId = (SELECT appartmentId from deleted)
	SELECT @reId = (SELECT ReadingId from deleted)

	
	BEGIN
		SET NOCOUNT ON
		INSERT INTO dbo.LogReadings (DateTime, Operations, apartmentId, ReadingId) 
		VALUES (@dateTime, 'DELETE', @apId,@reId)  
	END
