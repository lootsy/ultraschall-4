USE ultraschall;
GO

IF OBJECT_ID(N'idx_external_feeds', N'U') IS NOT NULL
BEGIN
   DROP TABLE external_feeds;
END
GO

IF OBJECT_ID(N'external_feeds', N'U') IS NOT NULL
BEGIN
   DROP TABLE external_feeds;
END
GO

CREATE TABLE external_feeds
(
   id UNIQUEIDENTIFIER DEFAULT NEWID(),
   reference_id bigint UNIQUE NOT NULL,
   feed_url NVARCHAR(768) NOT NULL
);
GO

CREATE UNIQUE CLUSTERED INDEX idx_external_feeds ON external_feeds(id, reference_id);
GO

